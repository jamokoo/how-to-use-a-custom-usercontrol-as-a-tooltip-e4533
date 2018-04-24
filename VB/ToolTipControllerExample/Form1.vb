Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports System.Diagnostics

Namespace ToolTipControllerExample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            'myToolTipController1.ToolTipControl = new ToolTipControl();
            AddHandler myToolTipController1.GetActiveObjectInfo, AddressOf myToolTipController1_GetActiveObjectInfo
        End Sub

        Private Sub myToolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs)
            If TypeOf e.SelectedControl Is DevExpress.XtraTreeList.TreeList Then
                Dim tree As TreeList = CType(e.SelectedControl, TreeList)
                Dim hit As TreeListHitInfo = tree.CalcHitInfo(e.ControlMousePosition)
                If hit.HitInfoType = HitInfoType.Cell AndAlso hit.HitInfoType <> HitInfoType.Empty Then
                    myToolTipController1.ToolTipControlParent = e.SelectedControl
                    myToolTipController1.ToolTipControl.Department = hit.Node.GetDisplayText("DEPARTMENT")
                    myToolTipController1.ToolTipControl.Phone = hit.Node.GetDisplayText("PHONE1")
                    myToolTipController1.ToolTipControl.DepartmentLocation = hit.Node.GetDisplayText("LOCATION")
                    myToolTipController1.ToolTipControl.Budget = Convert.ToDecimal(hit.Node.GetDisplayText("BUDGET"))
                    myToolTipController1.ToolTipControl.Location = New Point(hit.Bounds.X, hit.Bounds.Y + hit.Bounds.Height)
                    e.Info = New DevExpress.Utils.ToolTipControlInfo("", "")
                Else
                    myToolTipController1.ToolTipControl.Hide()
                End If
            End If
        End Sub


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            ' TODO: This line of code loads data into the 'departmentsDataSet.Departments' table. You can move, or remove it, as needed.
            Me.departmentsTableAdapter.Fill(Me.departmentsDataSet_Renamed.Departments)
        End Sub
    End Class
End Namespace