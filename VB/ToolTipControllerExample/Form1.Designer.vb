Imports Microsoft.VisualBasic
Imports System
Namespace ToolTipControllerExample
	Partial Public Class Form1
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
			Me.components = New System.ComponentModel.Container()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.colDEPARTMENT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colBUDGET = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colLOCATION = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colPHONE1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colPHONE2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.departmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.departmentsDataSet = New ToolTipControllerExample.DepartmentsDataSet()
			Me.myToolTipController1 = New ToolTipControllerExample.MyToolTipController()
			Me.departmentsTableAdapter = New ToolTipControllerExample.DepartmentsDataSetTableAdapters.DepartmentsTableAdapter()
			Me.backstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.backstageViewTabItem2 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.backstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.departmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.departmentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colDEPARTMENT, Me.colBUDGET, Me.colLOCATION, Me.colPHONE1, Me.colPHONE2})
			Me.treeList1.DataSource = Me.departmentsBindingSource
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.ImageIndexFieldName = "IMAGEINDEX"
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.ParentFieldName = "PARENTID"
			Me.treeList1.Size = New System.Drawing.Size(783, 565)
			Me.treeList1.TabIndex = 0
			Me.treeList1.ToolTipController = Me.myToolTipController1
			' 
			' colDEPARTMENT
			' 
			Me.colDEPARTMENT.FieldName = "DEPARTMENT"
			Me.colDEPARTMENT.Name = "colDEPARTMENT"
			Me.colDEPARTMENT.Visible = True
			Me.colDEPARTMENT.VisibleIndex = 0
			Me.colDEPARTMENT.Width = 63
			' 
			' colBUDGET
			' 
			Me.colBUDGET.FieldName = "BUDGET"
			Me.colBUDGET.Name = "colBUDGET"
			Me.colBUDGET.Visible = True
			Me.colBUDGET.VisibleIndex = 1
			Me.colBUDGET.Width = 63
			' 
			' colLOCATION
			' 
			Me.colLOCATION.FieldName = "LOCATION"
			Me.colLOCATION.Name = "colLOCATION"
			Me.colLOCATION.Visible = True
			Me.colLOCATION.VisibleIndex = 2
			Me.colLOCATION.Width = 63
			' 
			' colPHONE1
			' 
			Me.colPHONE1.FieldName = "PHONE1"
			Me.colPHONE1.Name = "colPHONE1"
			Me.colPHONE1.Visible = True
			Me.colPHONE1.VisibleIndex = 3
			Me.colPHONE1.Width = 63
			' 
			' colPHONE2
			' 
			Me.colPHONE2.FieldName = "PHONE2"
			Me.colPHONE2.Name = "colPHONE2"
			Me.colPHONE2.Visible = True
			Me.colPHONE2.VisibleIndex = 4
			Me.colPHONE2.Width = 64
			' 
			' departmentsBindingSource
			' 
			Me.departmentsBindingSource.DataMember = "Departments"
			Me.departmentsBindingSource.DataSource = Me.departmentsDataSet
			' 
			' departmentsDataSet
			' 
			Me.departmentsDataSet.DataSetName = "DepartmentsDataSet"
			Me.departmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' myToolTipController1
			' 
			Me.myToolTipController1.ToolTipControlParent = Me
			' 
			' departmentsTableAdapter
			' 
			Me.departmentsTableAdapter.ClearBeforeFill = True
			' 
			' backstageViewTabItem1
			' 
			Me.backstageViewTabItem1.Caption = "backstageViewTabItem1"
			Me.backstageViewTabItem1.Name = "backstageViewTabItem1"
			Me.backstageViewTabItem1.Selected = False
			' 
			' backstageViewTabItem2
			' 
			Me.backstageViewTabItem2.Caption = "backstageViewTabItem2"
			Me.backstageViewTabItem2.Name = "backstageViewTabItem2"
			Me.backstageViewTabItem2.Selected = False
			' 
			' backstageViewItemSeparator1
			' 
			Me.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(783, 565)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.departmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.departmentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private departmentsDataSet As DepartmentsDataSet
		Private departmentsBindingSource As System.Windows.Forms.BindingSource
		Private departmentsTableAdapter As DepartmentsDataSetTableAdapters.DepartmentsTableAdapter
		Private colDEPARTMENT As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colBUDGET As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colLOCATION As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colPHONE1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colPHONE2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private backstageViewTabItem1 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private backstageViewTabItem2 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private backstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
		Private myToolTipController1 As MyToolTipController
	End Class
End Namespace

