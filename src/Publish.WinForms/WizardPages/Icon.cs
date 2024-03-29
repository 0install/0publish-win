// Copyright Bastian Eicher et al.
// Licensed under the GNU Lesser Public License

using System.Diagnostics;
using System.Drawing.Imaging;
using AeroWizard;

namespace ZeroInstall.Publish.WinForms;

partial class NewFeedWizard
{
    private System.Drawing.Icon? _icon;

    private void pageIcon_Initialize(object sender, WizardPageInitEventArgs e)
    {
        pictureBoxIcon.Visible = buttonSaveIco.Enabled = buttonSavePng.Enabled = false;

        if (_feedBuilder.MainCandidate is EntryPoints.IIconContainer iconContainer)
        {
            try
            {
                _icon = iconContainer.ExtractIcon();
                pictureBoxIcon.Image = _icon.ToBitmap();
            }
            #region Error handling
            catch (IOException ex)
            {
                Log.Warn("Feed Wizard: Failed to extract icon", ex);
                Msg.Inform(this, ex.GetMessageWithInner(), MsgSeverity.Warn);
                return;
            }
            #endregion

            pictureBoxIcon.Visible = buttonSaveIco.Enabled = buttonSavePng.Enabled = true;
        }
    }

    [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "System.Drawing exceptions are not clearly documented")]
    private void buttonSaveIco_Click(object sender, EventArgs e)
    {
        Debug.Assert(_icon != null);

        using var saveFileDialog = new SaveFileDialog {Filter = Resources.IcoFiles + @"|*.ico|" + Resources.AllFiles + @"|*.*"};
        if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        {
            using var stream = File.Create(saveFileDialog.FileName);
            try
            {
                _icon.Save(stream);
            }
            #region Error handling
            catch (Exception ex)
            {
                Log.Warn("Feed Wizard: Failed to save ICO", ex);
                Msg.Inform(this, ex.GetMessageWithInner(), MsgSeverity.Warn);
            }
            #endregion
        }
    }

    [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "System.Drawing exceptions are not clearly documented")]
    private void buttonSavePng_Click(object sender, EventArgs e)
    {
        Debug.Assert(_icon != null);

        using var saveFileDialog = new SaveFileDialog {Filter = Resources.PngFiles + @"|*.png|" + Resources.AllFiles + @"|*.*"};
        if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        {
            try
            {
                _icon.ToBitmap().Save(saveFileDialog.FileName, ImageFormat.Png);
            }
            #region Error handling
            catch (Exception ex)
            {
                Log.Warn("Feed Wizard: Failed to save PNG", ex);
                Msg.Inform(this, ex.GetMessageWithInner(), MsgSeverity.Warn);
            }
            #endregion
        }
    }

    private void pageIcon_Commit(object sender, WizardPageConfirmEventArgs e)
    {
        _feedBuilder.Icons.Clear();
        try
        {
            if (textBoxHrefIco.Uri != null) _feedBuilder.Icons.Add(new Model.Icon {Href = textBoxHrefIco.Uri, MimeType = Model.Icon.MimeTypeIco});
            if (textBoxHrefPng.Uri != null) _feedBuilder.Icons.Add(new Model.Icon {Href = textBoxHrefPng.Uri, MimeType = Model.Icon.MimeTypePng});
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

        if (_feedBuilder.Icons.Count != 2)
        {
            if (!Msg.YesNo(this, Resources.AskSkipIcon, MsgSeverity.Info))
                e.Cancel = true;
        }
    }
}
