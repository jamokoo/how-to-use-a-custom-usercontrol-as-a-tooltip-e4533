Imports Microsoft.VisualBasic
Imports System
Namespace ToolTipControllerExample
	Partial Public Class DialingForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
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
			Me.marqueeProgressBarControl1 = New DevExpress.XtraEditors.MarqueeProgressBarControl()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' marqueeProgressBarControl1
			' 
			Me.marqueeProgressBarControl1.Location = New System.Drawing.Point(12, 82)
			Me.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1"
			Me.marqueeProgressBarControl1.Size = New System.Drawing.Size(304, 18)
			Me.marqueeProgressBarControl1.TabIndex = 0
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(12, 12)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 36F)
			Me.textEdit1.Properties.Appearance.Options.UseFont = True
			Me.textEdit1.Size = New System.Drawing.Size(304, 64)
			Me.textEdit1.TabIndex = 1
			' 
			' DialingForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(328, 112)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.marqueeProgressBarControl1)
			Me.Name = "DialingForm"
			Me.Text = "Dialing..."
			CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private marqueeProgressBarControl1 As DevExpress.XtraEditors.MarqueeProgressBarControl
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
	End Class
End Namespace