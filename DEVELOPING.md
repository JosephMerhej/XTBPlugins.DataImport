# Developing

This provides a brief guide to getting started with developing for Data Import ++

1. Fork and clone the repo to your machine
2. Open the solution in [**Visual Studio**](https://visualstudio.microsoft.com/vs/) - you will see errors initially because the Packages need to be installed in your machine.
3. In the Solution Explorer, right click on **References**, and select **Manage NuGet Packages**.
4. You should see a warning that Packages need to be installled or updated. Follow those instructions to install the necessary packages.
5. Re-open the Solution and it should now load. You may need to Build the package once for the designer to load successfully.
6. In the Toolbar at the top, click **Project** > **DataImport Properties** and open **Debug**. Under **Start Action**, select **Start External Program**: and specify the path to XrmToolbox, (which should be installed in your Debug folder as part of installing the other packages). Choose **Browse** to navigate to your Repo > bin > Debug > XrmToolBox.exe.
7. Under **Command line arguments**, add the following commands replacing the connection name and plugin name as needed. If you don't want to specify a connection, or automatically open the plugin when you debug simply do not include those lines.
```
/overridepath:.
/connection:"[Connection Name]"
/plugin:"[Plugin Name]"
```
8. In the **Build Events**tab , in **Post-build command line**, add:
```
IF NOT EXIST Plugins mkdir Plugins
move /Y $(TargetFileName) Plugins
```
9. Make sure you have Excel installed on your device. Otherwise you may see an error like this when you try to run the program:
```
An error occured when trying to display this tool: Retrieving the COM class factory for component with CLSID {00024500-0000-0000-C000-000000000046) failed due to the following error: 80040154 Class not registered (Exception from HRESULT: 0x80040154 (REGDB_E_CLASSNOTREG)).
```
Happy developing!

