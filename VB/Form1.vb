Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace EditValueRefresh
	Public Partial Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub InitData()
			For i As Integer = 0 To 4
				dataSet11.Tables(0).Rows.Add(New Object() { i, String.Format("FirstName {0}", i), i, imageList1.Images(i), DateTime.Today.AddDays(i), True })
				dataSet11.Tables(1).Rows.Add(New Object() { i, String.Format("FirstName {0}", i), i })
			Next i
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitData()
		End Sub

		Private Sub popupContainerEdit1_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles popupContainerEdit1.QueryResultValue
			e.Value = dataSet11.Tables(0).Rows(0)("FirstName")
		End Sub

		Private Sub cmdRefreshEV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdRefreshEV.Click
			Dim row As DataRow = dataSet11.Tables(0).Rows(0)
			row("FirstName") &= ", Add"
			popupContainerEdit1.RefreshEditValue()
		End Sub
	End Class
End Namespace