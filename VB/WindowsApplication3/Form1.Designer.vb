Namespace EditValueRefresh

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditValueRefresh.Form1))
            Me.customerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.dataSet11 = New EditValueRefresh.DataSet1()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.sharedImageCollection1 = New DevExpress.Utils.SharedImageCollection(Me.components)
            Me.popupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.cmdRefreshEV = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.customerInfoBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSet11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.sharedImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.sharedImageCollection1.ImageSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupContainerEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControl1.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' customerInfoBindingSource
            ' 
            Me.customerInfoBindingSource.DataMember = "CustomerInfo"
            Me.customerInfoBindingSource.DataSource = Me.dataSet11
            ' 
            ' dataSet11
            ' 
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = CType((resources.GetObject("imageList1.ImageStream")), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "1.jpg")
            Me.imageList1.Images.SetKeyName(1, "2.jpg")
            Me.imageList1.Images.SetKeyName(2, "3.jpg")
            Me.imageList1.Images.SetKeyName(3, "4.jpg")
            Me.imageList1.Images.SetKeyName(4, "5.jpg")
            Me.imageList1.Images.SetKeyName(5, "6.jpg")
            Me.imageList1.Images.SetKeyName(6, "7.jpg")
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
            ' 
            ' sharedImageCollection1
            ' 
            ' 
            ' 
            ' 
            Me.sharedImageCollection1.ImageSource.ImageStream = CType((resources.GetObject("sharedImageCollection1.ImageSource.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.sharedImageCollection1.ImageSource.Images.SetKeyName(0, "Jellyfish.jpg")
            Me.sharedImageCollection1.ImageSource.Images.SetKeyName(1, "Lighthouse.jpg")
            ' 
            ' popupContainerEdit1
            ' 
            Me.popupContainerEdit1.Location = New System.Drawing.Point(51, 29)
            Me.popupContainerEdit1.Name = "popupContainerEdit1"
            Me.popupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.popupContainerEdit1.Properties.PopupControl = Me.popupContainerControl1
            Me.popupContainerEdit1.Size = New System.Drawing.Size(244, 20)
            Me.popupContainerEdit1.TabIndex = 0
            AddHandler Me.popupContainerEdit1.QueryResultValue, New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(AddressOf Me.popupContainerEdit1_QueryResultValue)
            ' 
            ' popupContainerControl1
            ' 
            Me.popupContainerControl1.Controls.Add(Me.gridControl1)
            Me.popupContainerControl1.Location = New System.Drawing.Point(51, 77)
            Me.popupContainerControl1.Name = "popupContainerControl1"
            Me.popupContainerControl1.Size = New System.Drawing.Size(377, 190)
            Me.popupContainerControl1.TabIndex = 1
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.customerInfoBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(377, 190)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerID, Me.colFirstName, Me.colLastName, Me.colImage, Me.colDate, Me.colCheck})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' colCustomerID
            ' 
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.Visible = True
            Me.colCustomerID.VisibleIndex = 0
            ' 
            ' colFirstName
            ' 
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.Visible = True
            Me.colFirstName.VisibleIndex = 1
            ' 
            ' colLastName
            ' 
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.Visible = True
            Me.colLastName.VisibleIndex = 2
            ' 
            ' colImage
            ' 
            Me.colImage.FieldName = "Image"
            Me.colImage.Name = "colImage"
            Me.colImage.Visible = True
            Me.colImage.VisibleIndex = 3
            ' 
            ' colDate
            ' 
            Me.colDate.FieldName = "Date"
            Me.colDate.Name = "colDate"
            Me.colDate.Visible = True
            Me.colDate.VisibleIndex = 4
            ' 
            ' colCheck
            ' 
            Me.colCheck.FieldName = "Check"
            Me.colCheck.Name = "colCheck"
            Me.colCheck.Visible = True
            Me.colCheck.VisibleIndex = 5
            ' 
            ' cmdRefreshEV
            ' 
            Me.cmdRefreshEV.Location = New System.Drawing.Point(363, 24)
            Me.cmdRefreshEV.Name = "cmdRefreshEV"
            Me.cmdRefreshEV.Size = New System.Drawing.Size(111, 25)
            Me.cmdRefreshEV.TabIndex = 2
            Me.cmdRefreshEV.Text = "Refresh Edit Value"
            AddHandler Me.cmdRefreshEV.Click, New System.EventHandler(AddressOf Me.cmdRefreshEV_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(498, 323)
            Me.Controls.Add(Me.cmdRefreshEV)
            Me.Controls.Add(Me.popupContainerControl1)
            Me.Controls.Add(Me.popupContainerEdit1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Form1"
            Me.Text = "Edit Value Updating Example"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.customerInfoBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSet11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.sharedImageCollection1.ImageSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.sharedImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupContainerEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControl1.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private customerInfoBindingSource As System.Windows.Forms.BindingSource

        Private dataSet11 As EditValueRefresh.DataSet1

        Private imageList1 As System.Windows.Forms.ImageList

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private sharedImageCollection1 As DevExpress.Utils.SharedImageCollection

        Private popupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit

        Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn

        Private colLastName As DevExpress.XtraGrid.Columns.GridColumn

        Private colImage As DevExpress.XtraGrid.Columns.GridColumn

        Private colDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colCheck As DevExpress.XtraGrid.Columns.GridColumn

        Private cmdRefreshEV As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
