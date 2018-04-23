Imports Microsoft.VisualBasic
Imports System
Namespace ToolTipControllerExample
	Partial Public Class ToolTipControl
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.lbDepartment = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.beLocation = New DevExpress.XtraEditors.ButtonEdit()
			Me.bePhone = New DevExpress.XtraEditors.ButtonEdit()
			Me.seBudget = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupControlContainer1.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.beLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seBudget.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.popupControlContainer1.Controls.Add(Me.panelControl1)
			Me.popupControlContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.popupControlContainer1.Location = New System.Drawing.Point(0, 0)
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Size = New System.Drawing.Size(192, 113)
			Me.popupControlContainer1.TabIndex = 0
			Me.popupControlContainer1.Visible = False
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.labelControl5)
			Me.panelControl1.Controls.Add(Me.labelControl4)
			Me.panelControl1.Controls.Add(Me.labelControl3)
			Me.panelControl1.Controls.Add(Me.labelControl2)
			Me.panelControl1.Controls.Add(Me.lbDepartment)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Controls.Add(Me.beLocation)
			Me.panelControl1.Controls.Add(Me.bePhone)
			Me.panelControl1.Controls.Add(Me.seBudget)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(192, 113)
			Me.panelControl1.TabIndex = 0
			' 
			' labelControl5
			' 
			Me.labelControl5.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl5.Appearance.ForeColor = System.Drawing.Color.Blue
			Me.labelControl5.Location = New System.Drawing.Point(173, 5)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(14, 13)
			Me.labelControl5.TabIndex = 4
			Me.labelControl5.Text = "[x]"
'			Me.labelControl5.Click += New System.EventHandler(Me.labelControl5_Click);
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(6, 83)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(30, 13)
			Me.labelControl4.TabIndex = 4
			Me.labelControl4.Text = "Phone"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(5, 57)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(40, 13)
			Me.labelControl3.TabIndex = 4
			Me.labelControl3.Text = "Location"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(5, 31)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(34, 13)
			Me.labelControl2.TabIndex = 4
			Me.labelControl2.Text = "Budget"
			' 
			' lbDepartment
			' 
			Me.lbDepartment.Location = New System.Drawing.Point(74, 6)
			Me.lbDepartment.Name = "lbDepartment"
			Me.lbDepartment.Size = New System.Drawing.Size(8, 13)
			Me.lbDepartment.TabIndex = 4
			Me.lbDepartment.Text = """"""
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(6, 6)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(57, 13)
			Me.labelControl1.TabIndex = 4
			Me.labelControl1.Text = "Department"
			' 
			' beLocation
			' 
			Me.beLocation.Location = New System.Drawing.Point(74, 54)
			Me.beLocation.Name = "beLocation"
			Me.beLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, My.Resources._1361454060_applications_internet, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
'			Me.beLocation.Properties.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.beLocation_Properties_ButtonClick);
			Me.beLocation.Size = New System.Drawing.Size(100, 22)
			Me.beLocation.TabIndex = 2
			' 
			' bePhone
			' 
			Me.bePhone.Location = New System.Drawing.Point(74, 80)
			Me.bePhone.Name = "bePhone"
			Me.bePhone.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, My.Resources._1361453678_phone, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
			Me.bePhone.Size = New System.Drawing.Size(100, 22)
			Me.bePhone.TabIndex = 1
'			Me.bePhone.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.bePhone_ButtonClick);
			' 
			' seBudget
			' 
			Me.seBudget.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seBudget.Location = New System.Drawing.Point(74, 28)
			Me.seBudget.Name = "seBudget"
			Me.seBudget.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seBudget.Size = New System.Drawing.Size(100, 20)
			Me.seBudget.TabIndex = 0
			' 
			' ToolTipControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.popupControlContainer1)
			Me.Name = "ToolTipControl"
			Me.Size = New System.Drawing.Size(192, 113)
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupControlContainer1.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.beLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seBudget.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents labelControl5 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private lbDepartment As DevExpress.XtraEditors.LabelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents beLocation As DevExpress.XtraEditors.ButtonEdit
		Private WithEvents bePhone As DevExpress.XtraEditors.ButtonEdit
		Private seBudget As DevExpress.XtraEditors.SpinEdit
	End Class
End Namespace
