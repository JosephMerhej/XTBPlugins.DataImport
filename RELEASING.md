# Releasing

To release an update to the app:

1. Ensure [Nuget is downloaded to your device](https://learn.microsoft.com/en-us/nuget/reference/nuget-exe-cli-reference?tabs=windows#installing-nugetexe)
1. Update the [DataImportSharp.nuspec](/DataImportSharp.nuspec) file with the latest version, release description etc.
1. Open a terminal in the working directory of the repo
1. Run `"[Path to Nuget file]\nuget.exe" pack DataImportSharp.nuspec`
1. Upload the resulting .nupkg file that will be saved to the root directory to [Nuget Package Directory](https://www.nuget.org/packages/manage/upload).