﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroInstall.Publish.WinForms.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ZeroInstall.Publish.WinForms.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing.
        /// </summary>
        internal static string AddMissing {
            get {
                return ResourceManager.GetString("AddMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All files.
        /// </summary>
        internal static string AllFiles {
            get {
                return ResourceManager.GetString("AllFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This path points outside of the archive..
        /// </summary>
        internal static string ArchiveBreakoutPath {
            get {
                return ResourceManager.GetString("ArchiveBreakoutPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the GnuPG passphrase for {0}:.
        /// </summary>
        internal static string AskForPassphrase {
            get {
                return ResourceManager.GetString("AskForPassphrase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Is this an installer EXE?.
        /// </summary>
        internal static string AskInstallerEXE {
            get {
                return ResourceManager.GetString("AskInstallerEXE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to skip capturing?
        ///Information about the application&apos;s desktop integration (e.g. file associations) will not be added to the feed..
        /// </summary>
        internal static string AskSkipCapture {
            get {
                return ResourceManager.GetString("AskSkipCapture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to continue without adding icons?
        ///Zero Install will only be able to display a generic placeholder icon in the catalog as well as for any desktop integration shortcuts..
        /// </summary>
        internal static string AskSkipIcon {
            get {
                return ResourceManager.GetString("AskSkipIcon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to continue without completing these settings?
        ///Your feed will only work locally and not online..
        /// </summary>
        internal static string AskSkipSecurity {
            get {
                return ResourceManager.GetString("AskSkipSecurity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Description.
        /// </summary>
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keep
        ///The implementation was supposed to stay the same.
        /// </summary>
        internal static string DigestKeep {
            get {
                return ResourceManager.GetString("DigestKeep", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The manifest digest has changed. Do you wish to replace the existing one?.
        /// </summary>
        internal static string DigestMismatch {
            get {
                return ResourceManager.GetString("DigestMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All other retrieval methods for this implementation must match the new digest as well!.
        /// </summary>
        internal static string DigestOtherImplementations {
            get {
                return ResourceManager.GetString("DigestOtherImplementations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace
        ///I changed the implementation on purpose.
        /// </summary>
        internal static string DigestReplace {
            get {
                return ResourceManager.GetString("DigestReplace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Discard
        ///Discard unsaved changes.
        /// </summary>
        internal static string DiscardChanges {
            get {
                return ResourceManager.GetString("DiscardChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading image for preview....
        /// </summary>
        internal static string DownloadingPeviewImage {
            get {
                return ResourceManager.GetString("DownloadingPeviewImage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A manifest digest was calculated for an empty directory. Check that you have set the correct &quot;extract&quot; value for the archive..
        /// </summary>
        internal static string EmptyImplementation {
            get {
                return ResourceManager.GetString("EmptyImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Feed files (*.xml)|*.xml|Template files (*.xml.template)|*.xml.template|All files|*.
        /// </summary>
        internal static string FileDialogFilter {
            get {
                return ResourceManager.GetString("FileDialogFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File size.
        /// </summary>
        internal static string FileSize {
            get {
                return ResourceManager.GetString("FileSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A complete possibly multi-line description.
        /// </summary>
        internal static string HintTextMultiline {
            get {
                return ResourceManager.GetString("HintTextMultiline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Icon files.
        /// </summary>
        internal static string IcoFiles {
            get {
                return ResourceManager.GetString("IcoFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The image format is not supported by Zero Install..
        /// </summary>
        internal static string ImageFormatNotSupported {
            get {
                return ResourceManager.GetString("ImageFormatNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to extract the installer as an archive..
        /// </summary>
        internal static string InstallerExtractFailed {
            get {
                return ResourceManager.GetString("InstallerExtractFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You need to provide an alternative download source for the application, e.g. a ZIP archive. We will still use the desktop integration information captured from the installer!.
        /// </summary>
        internal static string InstallerNeedAltSource {
            get {
                return ResourceManager.GetString("InstallerNeedAltSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid capabilities registry path: {0}.
        /// </summary>
        internal static string InvalidCapabilitiesRegistryPath {
            get {
                return ResourceManager.GetString("InvalidCapabilitiesRegistryPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manifest digest may have changed..
        /// </summary>
        internal static string ManifestDigestChanged {
            get {
                return ResourceManager.GetString("ManifestDigestChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manifest digest not calculated yet..
        /// </summary>
        internal static string ManifestDigestMissing {
            get {
                return ResourceManager.GetString("ManifestDigestMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Names.
        /// </summary>
        internal static string Names {
            get {
                return ResourceManager.GetString("Names", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap NewButton {
            get {
                object obj = ResourceManager.GetObject("NewButton", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New key....
        /// </summary>
        internal static string NewKey {
            get {
                return ResourceManager.GetString("NewKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap NewWizardButton {
            get {
                object obj = ResourceManager.GetObject("NewWizardButton", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No entry points (EXEs, JARs, Python scripts, etc.) were found. Please make sure you selected the correct archive and extract directory..
        /// </summary>
        internal static string NoEntryPointsFound {
            get {
                return ResourceManager.GetString("NoEntryPointsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find any matching feed files..
        /// </summary>
        internal static string NoFeedFilesFound {
            get {
                return ResourceManager.GetString("NoFeedFilesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No, the application itself
        ///consists only of one EXE.
        /// </summary>
        internal static string NoSingleExecutable {
            get {
                return ResourceManager.GetString("NoSingleExecutable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap OpenButton {
            get {
                object obj = ResourceManager.GetObject("OpenButton", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please click:.
        /// </summary>
        internal static string PleaseClick {
            get {
                return ResourceManager.GetString("PleaseClick", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PNG image files.
        /// </summary>
        internal static string PngFiles {
            get {
                return ResourceManager.GetString("PngFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap RedoButton {
            get {
                object obj = ResourceManager.GetObject("RedoButton", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to in bytes (required).
        /// </summary>
        internal static string RequiredBytes {
            get {
                return ResourceManager.GetString("RequiredBytes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP/FTP URL (required).
        /// </summary>
        internal static string RequiredUrl {
            get {
                return ResourceManager.GetString("RequiredUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save anyway?.
        /// </summary>
        internal static string SaveAnyway {
            get {
                return ResourceManager.GetString("SaveAnyway", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap SaveButton {
            get {
                object obj = ResourceManager.GetObject("SaveButton", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save
        ///Save changes.
        /// </summary>
        internal static string SaveChanges {
            get {
                return ResourceManager.GetString("SaveChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to save the changes?.
        /// </summary>
        internal static string SaveQuestion {
            get {
                return ResourceManager.GetString("SaveQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully signed files..
        /// </summary>
        internal static string SignedFeeds {
            get {
                return ResourceManager.GetString("SignedFeeds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signing feeds.
        /// </summary>
        internal static string SigningFeeds {
            get {
                return ResourceManager.GetString("SigningFeeds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File size not determined yet..
        /// </summary>
        internal static string SizeMissing {
            get {
                return ResourceManager.GetString("SizeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source URL.
        /// </summary>
        internal static string SourceUrl {
            get {
                return ResourceManager.GetString("SourceUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Summary.
        /// </summary>
        internal static string Summary {
            get {
                return ResourceManager.GetString("Summary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap UndoButton {
            get {
                object obj = ResourceManager.GetObject("UndoButton", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for installer to complete.
        /// </summary>
        internal static string WaitingForInstaller {
            get {
                return ResourceManager.GetString("WaitingForInstaller", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong MIME type! Should be {0}..
        /// </summary>
        internal static string WrongMimeType {
            get {
                return ResourceManager.GetString("WrongMimeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yes, installer EXE.
        /// </summary>
        internal static string YesInstallerExe {
            get {
                return ResourceManager.GetString("YesInstallerExe", resourceCulture);
            }
        }
    }
}
