Imports Microsoft.VisualBasic
Imports System
Namespace EditValueRefresh
	Public Partial Class Form2
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
			Me.sharedImageCollection1 = New DevExpress.Utils.SharedImageCollection(Me.components)
			CType(Me.sharedImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sharedImageCollection1.ImageSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' sharedImageCollection1
			' 
			' 
			' 
			' 
			Me.sharedImageCollection1.ImageSource.ImageStream = (CType(resources.GetObject("sharedImageCollection1.ImageSource.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.sharedImageCollection1.ImageSource.Images.SetKeyName(0, "Jellyfish.jpg")
			Me.sharedImageCollection1.ImageSource.Images.SetKeyName(1, "Lighthouse.jpg")
			' 
			' Form2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 262)
			Me.Name = "Form2"
			Me.Text = "Form2"
			CType(Me.sharedImageCollection1.ImageSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sharedImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private sharedImageCollection1 As DevExpress.Utils.SharedImageCollection
	End Class
End Namespace