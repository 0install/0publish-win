// Copyright Bastian Eicher et al.
// Licensed under the GNU Lesser Public License

using AeroWizard;

namespace ZeroInstall.Publish.WinForms;

partial class NewFeedWizard
{
    private Archive? _archive;

    private void pageArchiveExtract_Initialize(object sender, WizardPageInitEventArgs e)
    {
        _archive = (Archive)_feedBuilder.RetrievalMethod!;

        listBoxExtract.BeginUpdate();
        listBoxExtract.Items.Clear();

        var baseDirectory = new DirectoryInfo(_feedBuilder.TemporaryDirectory!);
        baseDirectory.Walk(dir => listBoxExtract.Items.Add(dir.RelativeTo(baseDirectory)));
        listBoxExtract.SelectedItem = baseDirectory.WalkThroughPrefix().RelativeTo(baseDirectory);

        listBoxExtract.EndUpdate();
    }

    private void pageArchiveExtract_Commit(object sender, WizardPageConfirmEventArgs e)
    {
        using (var handler = new DialogTaskHandler(this))
        {
            if (FileUtils.IsBreakoutPath(listBoxExtract.Text))
            {
                e.Cancel = true;
                Msg.Inform(this, Resources.ArchiveBreakoutPath, MsgSeverity.Error);
                return;
            }

            _archive.Extract = listBoxExtract.Text ?? "";
            _feedBuilder.ImplementationDirectory = Path.Combine(_feedBuilder.TemporaryDirectory!, _archive.Extract.ToNativePath()!);

            try
            {
                // Candidate detection is handled differently when capturing an installer
                if (_installerCapture.CaptureSession == null)
                    _feedBuilder.DetectCandidates(handler);

                _feedBuilder.GenerateDigest(handler);
            }
            #region Error handling
            catch (OperationCanceledException)
            {
                e.Cancel = true;
                return;
            }
            catch (Exception ex) when (ex is ArgumentException or IOException or UnauthorizedAccessException)
            {
                e.Cancel = true;
                Log.Warn("Feed Wizard: Failed to extract archive", ex);
                Msg.Inform(this, ex.GetMessageWithInner(), MsgSeverity.Warn);
                return;
            }
            #endregion
        }

        if (_feedBuilder.ManifestDigest.PartialEquals(ManifestDigest.Empty))
        {
            Msg.Inform(this, Resources.EmptyImplementation, MsgSeverity.Warn);
            e.Cancel = true;
        }
        if (_feedBuilder.MainCandidate == null)
        {
            Msg.Inform(this, Resources.NoEntryPointsFound, MsgSeverity.Warn);
            e.Cancel = true;
        }
    }
}
