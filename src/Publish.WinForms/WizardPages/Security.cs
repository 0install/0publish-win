// Copyright Bastian Eicher et al.
// Licensed under the GNU Lesser Public License

using System.Diagnostics;
using AeroWizard;
using NanoByte.Common.Threading;
using ZeroInstall.Store.Trust;

namespace ZeroInstall.Publish.WinForms;

partial class NewFeedWizard
{
    /// <summary>Used to get a list of <see cref="OpenPgpSecretKey"/>s.</summary>
    private readonly IOpenPgp _openPgp;

    private void pageSecurity_Initialize(object sender, WizardPageInitEventArgs e) => ListKeys();

    private void ListKeys()
    {
        comboBoxKeys.Items.Clear();
        comboBoxKeys.Items.Add("");
        comboBoxKeys.Items.AddRange(_openPgp.ListSecretKeys().Cast<object>().ToArray());

        comboBoxKeys.SelectedItem = _feedBuilder.SecretKey;
    }

    private void comboBoxKeys_SelectedIndexChanged(object sender, EventArgs e)
        => _feedBuilder.SecretKey = comboBoxKeys.SelectedItem as OpenPgpSecretKey;

    private void buttonNewKey_Click(object sender, EventArgs e)
    {
        Process process;
        try
        {
            process = GnuPG.GenerateKey();
        }
        #region Error handling
        catch (IOException ex)
        {
            Log.Error("Failed to generate GnuPG key", ex);
            Msg.Inform(this, ex.GetMessageWithInner(), MsgSeverity.Error);
            return;
        }
        #endregion

        ThreadUtils.StartBackground(() =>
        {
            process.WaitForExit();

            // Update key list when done
            try
            {
                this.Invoke(ListKeys);
            }
            #region Sanity checks
            catch (InvalidOperationException)
            {
                // Ignore if window has been dispoed
            }
            #endregion
        }, name: "WaitForOpenPgp");
    }

    private void pageSecurity_Commit(object sender, WizardPageConfirmEventArgs e)
    {
        _feedBuilder.SecretKey = comboBoxKeys.SelectedItem as OpenPgpSecretKey;
        try
        {
            _feedBuilder.Uri = (textBoxInterfaceUri.Uri == null) ? null : new FeedUri(textBoxInterfaceUri.Uri);
        }
        #region Error handling
        catch (UriFormatException ex)
        {
            e.Cancel = true;
            Log.Warn(ex);
            Msg.Inform(this, ex.Message, MsgSeverity.Warn);
            return;
        }
        #endregion

        if (_feedBuilder.SecretKey == null || _feedBuilder.Uri == null)
            if (!Msg.YesNo(this, Resources.AskSkipSecurity, MsgSeverity.Info))
                e.Cancel = true;
    }
}
