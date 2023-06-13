Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace EditValueRefresh

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub InitData()
            For i As Integer = 0 To 5 - 1
                dataSet11.Tables(CInt(0)).Rows.Add(New Object() {i, String.Format("FirstName {0}", i), i, imageList1.Images(i), Date.Today.AddDays(i), True})
                dataSet11.Tables(CInt(1)).Rows.Add(New Object() {i, String.Format("FirstName {0}", i), i})
            Next
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitData()
        End Sub

        Private Sub popupContainerEdit1_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
            e.Value = dataSet11.Tables(CInt(0)).Rows(0)("FirstName")
        End Sub

        Private Sub cmdRefreshEV_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim row As DataRow = dataSet11.Tables(CInt(0)).Rows(0)
            row("FirstName") += ", Add"
            popupContainerEdit1.RefreshEditValue()
        End Sub
    End Class
End Namespace
