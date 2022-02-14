# DataGridView Reorder Column Example

DataGridView Column have many ways you can address them, two are their name or their index number in the DataGridView Collection. 

The user creates the Column name, but the Index is created by the system when columns are created, and I cannot see a way to ever edit this number. 

If you want to reorder, the visual order of you rcolumns in the GUI you change the DisplayIndex. This does not Change the Index number of the column. It just changes how the DGV looks in the UI. 

When you save the left hand reordered DGV by copy to clipboard you get the view in the GUI but if you save by parsing through the grid you get the original Index view. 

To get round this if you want to reorder and then save that by parsing through the DGV then you must Copy the original DGV to a new DGV column by column in the order you now want. There are many ways to do this I just show on simple way what you would probably want to do is put the column in a temporary list, remove all columns and add them again.

I cannot find a way of changing the Index property of a column after it has been created, so this copy method although cumbersome is what I have used.
