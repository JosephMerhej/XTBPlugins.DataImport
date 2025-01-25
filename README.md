# Data Import ++
Data Import ++ is a tool that allows you to create, update, upsert and delete records in Dynamics 365 / Dataverse, using an Excel spreadsheet as an input.

Original guide : [https://dynamics365tips.wixsite.com/home/post/xrmtoolbox-dataimport](https://dynamics365tips.wixsite.com/home/post/xrmtoolbox-dataimport)

V2 Release notes: [https://andyhowes.co/introducing-dataimport-v2/](https://andyhowes.co/introducing-dataimport-v2/)

## Features:
- Map and import complex Excel files into a Dynamics 365 / Dataverse environment, including lookup fields to non-ID columns, optionsets and binary choices.
- Save and load data maps to XML, to enable you to quickly conduct regular imports.
- Import only specific rows, to enable batching and testing of the import process.

## Steps:
1. Open the Excel file, choose the target entity, and type of import (create, update, upsert or delete).
2. Map the Excel columns names to the target fields. Then tick the column or columns that should be used as a key for update, upsert, or delete.
3. If mapping to a lookup field, choose the entity and field to reference in the lookup.
4. If using an optionset, choose whether these are stored as values or labels.
5. If using a boolean field, choose the values that represent the True and False fields.
7. Choose the number of rows you want to import. By default, this will be all rows, but you can reduce the number to run a test import first.
8. Click on **Import** to begin the import process. You can see results as they appear in the log table.
9. You can save your mappings to the XRM Toolbox Settings folder for re-use later, by clicking **Save**. You can later Load these settings by clicking **Load**.

## Authors:
Data Import ++ was created by Joseph Merhej and further developed by [Andrew Howes](https://andyhowes.co)

## Issues, Contributing and Ideas:
Use Github issues to raise bugs, problems and ideas. Contributions are welcome - check out [Developing.MD](developing.md) to get started.
