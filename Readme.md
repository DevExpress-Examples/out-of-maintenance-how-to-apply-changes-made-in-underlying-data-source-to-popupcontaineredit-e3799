<!-- default file list -->
*Files to look at*:

* [DataSet1.cs](./CS/WindowsApplication3/DataSet1.cs)
* **[Form1.cs](./CS/WindowsApplication3/Form1.cs)**
* [Form2.cs](./CS/WindowsApplication3/Form2.cs)
<!-- default file list end -->
# How To: Apply Changes Made In Underlying Data Source to PopupContainerEdit


<p>In this example the PopupContainerEdit uses the PopupContainerControl that holds the GridControl with 5 columns. The second column's value in the selected row is a displayed text for the PopupContainerEdit.</p><p>Clicking the 'Refresh Edit Value' button adds the 'Add' text to the selected grid cell in the underlying data source. Then the PopupBaseEdit.RefreshEditValue method is called. It instantly updates the editor's value by copying a value from the editor's popup window to BaseEdit.EditValue.</p>

<br/>


