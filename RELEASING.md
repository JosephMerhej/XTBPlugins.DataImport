# Releasing

To release an update to the app:

1. Ensure [Nuget is downloaded to your device](https://learn.microsoft.com/en-us/nuget/reference/nuget-exe-cli-reference?tabs=windows#installing-nugetexe)
1. If any new dependencies have been added, add them to the Library folder.
1. Build a release version of the app. Make sure it functions as expected.
1. Get the properties from the newly created .dll file in bin/Release by right clicking on it and selecting Properties > Details. Use the File version number here to update the [DataImport.nuspec](/DataImport.nuspec) file with the latest version. Add a release description as well.
1. Open a terminal in the working directory of the repo
1. Run `"[Path to Nuget exe]\nuget.exe" pack DataImport.nuspec`
1. If successful, a new .nupkg file will be saved to the project directory. Upload this to [Nuget Package Directory](https://www.nuget.org/packages/manage/upload).
1. If necessary, force an update to the [XRMToolbox Plugin Tool Library](https://www.xrmtoolbox.com/profile/my-plugins/)