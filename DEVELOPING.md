# Developing

This provides a brief guide to getting started with developing for Data Import ++

1. Fork and clone the repo to your machine
2. Open the solution in Visual Studio - you will see errors initially because the Packages need to be installed in your machine.
3. In the Solution Explorer, right click on References, and select Manage NuGet Packages.
4. You should see a warning that Packages need to be installled or updated. Follow those instructions to install the necessary packages.
5. Re-open the Solution and it should now load.
6. In the Toolbar at the top, click Project > DataImport Properties and open Debug. You need to specify the path to XrmToolbox, (which should be installed in your Debug folder as part of installing the other packages). Choose Browse to navigate to your Repo > bin > Debug > XrmToolBox.exe.
7. If you want to specify a connection to open in XrmToolbox when you are debugging the tool, you can specify it in the same section under Start option Command line arguments. Change the default in /connection:"default" to the name of your connection.

Happy developing!

