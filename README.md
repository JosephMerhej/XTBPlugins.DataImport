# XTBPlugins.DataImport
Data Import ++ is a tool that allows you to accomplish the following actions in Dynamics 365: CREATE, UPDATE, UPSERT or DELETE records based on an Excel data sheet as input

Complete guide : https://d365tips.com/home/xrmtoolbox-dataimport

STEPS:

1. Import the Excel file and choose the target entity.

2. Map the correct fields that correspond to the different columns of the Excel. (Then tick the column or columns "key" for update, upsert, or delete)

3. Click on "PROCESS FIELDS" to detect the type of fields and show additionnal columns. (ex: Boolean type – OptionSet – lookup)
-If a lookup field exists: populate the entity to which the lookup points and re-click "PROCESS FIELDS".
-If an OptionSet field exists: choose whether these are values (int) populated in the Excel column or labels of optionset values.
-If a Boolean field exists: 2 additional columns appear with the values of the options true and false.
It is possible to replace the text for true and false with the existing values in the Excel file (ex: instead of yes/no-> show/hide)

4. Click on "IMPORT CRM" to trigger the process.

5. While the import process is on going, you can click on the Refresh button to see the logs progress.  You can filter as well the Logs to see : Success,Errors,Warnings,All.
