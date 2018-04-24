Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace ToolTipControllerExample
    Partial Public Class DialingForm
        Inherits Form

        Public Sub New(ByVal number As String)
            InitializeComponent()
            DialNumber = number
        End Sub
        Public WriteOnly Property DialNumber() As String
            Set(ByVal value As String)
                textEdit1.Text = value
            End Set
        End Property
    End Class
End Namespace
