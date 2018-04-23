# How To: Apply Changes Made In Underlying Data Source to PopupContainerEdit


<p>In this example the PopupContainerEdit uses the PopupContainerControl that holds the GridControl with 5 columns. The second column's value in the selected row is a displayed text for the PopupContainerEdit.</p><p>Clicking the 'Refresh Edit Value' button adds the 'Add' text to the selected grid cell in the underlying data source. Then the PopupBaseEdit.RefreshEditValue method is called. It instantly updates the editor's value by copying a value from the editor's popup window to BaseEdit.EditValue.</p>

<br/>


