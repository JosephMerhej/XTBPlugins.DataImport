# Developing

This provides a brief guide to getting started with developing for Data Import ++

## Getting started

1. Fork and clone the repo to your machine
2. Open the solution in [**Visual Studio**](https://visualstudio.microsoft.com/vs/) - you will see errors initially because the Packages need to be installed in your machine.
3. In the Solution Explorer, right click on **References**, and select **Manage NuGet Packages**.
4. You should see a warning that Packages need to be installed or updated. Follow those instructions to install the necessary packages.
5. Re-open the Solution and it should now load. You may need to Build the package once for the designer to load successfully.
6. Make sure you have Excel installed on your device. Otherwise you may see an error like this when you try to run the program:
```
An error occured when trying to display this tool: Retrieving the COM class factory for component with CLSID {00024500-0000-0000-C000-000000000046) failed due to the following error: 80040154 Class not registered (Exception from HRESULT: 0x80040154 (REGDB_E_CLASSNOTREG)).
```

## Setting up the build process
When you build the program as Debug or Release, the **Pre-Build Event** will move the dll file to the Plugins folder in bin/Debug or bin/Release. It will then start the XrmToolbox application which should be installed in the same folder, with some command line arguements that are specified below. Before you can do this, you will need to specify the location of the XRMToolbox app you want to use.
1. In the Toolbar at the top, click **Project** > **DataImport Properties** and open **Debug**. Under **Start Action**, select **Start External Program**: and specify the path to XrmToolbox, (which should be installed in your Debug folder as part of installing the other packages). Choose **Browse** to navigate to your Repo > bin > Debug > XrmToolBox.exe and repeat for Repo > bin > Release > XrmToolBox.exe for the Release configuration.
2. Change the **Command line arguments** as below. If you don't want to specify a connection to use when testing, do not include the first line.
```
/connection:"[Choose the name of a connection youd like to use by default]"
/plugin:"Data Import ++ BETA"
/overridepath:"."
```

## Changing the XRMToolBox executable
Optionally, you might want to use a different XRMToolbox.exe application than the one in the Debug or Release folder. If you want to do this:
1. Change the Pre-Build Event to move the output file to a different folder: 
```
IF NOT EXIST [Desired Plugin Location]\Plugins mkdir [Desired Plugin Location]\Plugins
move /Y $(TargetFileName) [Desired Plugin Location]\Plugins
```

2. Change the **Start External Program** to the desired XRMToolBox executable as shown in Setting up the Build process
3. Add the line below to **Command line arguments**
```
/overridepath:"[Path to the XRMToolbox Storage container]"
```

Happy developing!

