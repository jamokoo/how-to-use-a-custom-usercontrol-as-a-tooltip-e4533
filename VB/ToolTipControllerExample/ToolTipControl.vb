Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Namespace ToolTipControllerExample
	Partial Public Class ToolTipControl
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			InitializeComponent()
			seBudget.Properties.ReadOnly = True
			bePhone.Properties.ReadOnly = True
			beLocation.Properties.ReadOnly = True
		End Sub

		Public WriteOnly Property Budget() As Decimal
			Set(ByVal value As Decimal)
				seBudget.Value = value
			End Set
		End Property
		Public WriteOnly Property Department() As String
			Set(ByVal value As String)
				lbDepartment.Text = value
			End Set
		End Property
		Public WriteOnly Property Phone() As String
			Set(ByVal value As String)
				bePhone.Text = value
			End Set
		End Property
		Public WriteOnly Property DepartmentLocation() As String
			Set(ByVal value As String)
				beLocation.Text = value
			End Set
		End Property

		Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
			MyBase.OnVisibleChanged(e)
			If Me.Visible Then
				popupControlContainer1.Show()
			End If
		End Sub

		Private Sub labelControl5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles labelControl5.Click
			Me.popupControlContainer1.Hide()
			Me.Hide()
		End Sub

		Private Sub bePhone_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bePhone.ButtonClick
			Dim df As Form = New DialingForm(bePhone.Text)
			df.Show()
		End Sub

		Private Sub beLocation_Properties_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beLocation.Properties.ButtonClick
			Dim locating As New Form2()
			locating.Show()
		End Sub
	End Class
End Namespace
