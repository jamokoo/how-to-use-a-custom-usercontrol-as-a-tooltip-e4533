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

Namespace ToolTipControllerExample
    Public Class MyToolTipController
        Inherits ToolTipController

        Private _toolTipControl As ToolTipControl

        Public Property ToolTipControl() As ToolTipControl
            Get
                Return _toolTipControl
            End Get
            Set(ByVal value As ToolTipControl)
                _toolTipControl = value
            End Set
        End Property

        Public Property ToolTipControlParent() As Control
            Get
                Return _toolTipControl.Parent
            End Get
            Set(ByVal value As Control)
                _toolTipControl.Parent = value
            End Set
        End Property
        Public Sub New()
            MyBase.New()
            _toolTipControl = New ToolTipControl()

        End Sub
        Protected Overrides Sub OnInitialTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            _toolTipControl.Show()
        End Sub
        Protected Overrides Sub HideToolWindow()
            _toolTipControl.Hide()
            MyBase.HideToolWindow()
        End Sub
        Protected Overrides Sub ActiveObjectChanged(ByVal prevControl As Control, ByVal prevObject As Object)
            MyBase.ActiveObjectChanged(prevControl, prevObject)
        End Sub
    End Class
End Namespace
