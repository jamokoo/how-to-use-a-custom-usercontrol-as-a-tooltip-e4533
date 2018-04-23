namespace ToolTipControllerExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colDEPARTMENT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBUDGET = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLOCATION = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPHONE1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPHONE2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsDataSet = new ToolTipControllerExample.DepartmentsDataSet();
            this.myToolTipController1 = new ToolTipControllerExample.MyToolTipController();
            this.departmentsTableAdapter = new ToolTipControllerExample.DepartmentsDataSetTableAdapters.DepartmentsTableAdapter();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDEPARTMENT,
            this.colBUDGET,
            this.colLOCATION,
            this.colPHONE1,
            this.colPHONE2});
            this.treeList1.DataSource = this.departmentsBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.ImageIndexFieldName = "IMAGEINDEX";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.ParentFieldName = "PARENTID";
            this.treeList1.Size = new System.Drawing.Size(783, 565);
            this.treeList1.TabIndex = 0;
            this.treeList1.ToolTipController = this.myToolTipController1;
            // 
            // colDEPARTMENT
            // 
            this.colDEPARTMENT.FieldName = "DEPARTMENT";
            this.colDEPARTMENT.Name = "colDEPARTMENT";
            this.colDEPARTMENT.Visible = true;
            this.colDEPARTMENT.VisibleIndex = 0;
            this.colDEPARTMENT.Width = 63;
            // 
            // colBUDGET
            // 
            this.colBUDGET.FieldName = "BUDGET";
            this.colBUDGET.Name = "colBUDGET";
            this.colBUDGET.Visible = true;
            this.colBUDGET.VisibleIndex = 1;
            this.colBUDGET.Width = 63;
            // 
            // colLOCATION
            // 
            this.colLOCATION.FieldName = "LOCATION";
            this.colLOCATION.Name = "colLOCATION";
            this.colLOCATION.Visible = true;
            this.colLOCATION.VisibleIndex = 2;
            this.colLOCATION.Width = 63;
            // 
            // colPHONE1
            // 
            this.colPHONE1.FieldName = "PHONE1";
            this.colPHONE1.Name = "colPHONE1";
            this.colPHONE1.Visible = true;
            this.colPHONE1.VisibleIndex = 3;
            this.colPHONE1.Width = 63;
            // 
            // colPHONE2
            // 
            this.colPHONE2.FieldName = "PHONE2";
            this.colPHONE2.Name = "colPHONE2";
            this.colPHONE2.Visible = true;
            this.colPHONE2.VisibleIndex = 4;
            this.colPHONE2.Width = 64;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.departmentsDataSet;
            // 
            // departmentsDataSet
            // 
            this.departmentsDataSet.DataSetName = "DepartmentsDataSet";
            this.departmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myToolTipController1
            // 
            this.myToolTipController1.ToolTipControlParent = this;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "backstageViewTabItem1";
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = false;
            // 
            // backstageViewTabItem2
            // 
            this.backstageViewTabItem2.Caption = "backstageViewTabItem2";
            this.backstageViewTabItem2.Name = "backstageViewTabItem2";
            this.backstageViewTabItem2.Selected = false;
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 565);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DepartmentsDataSet departmentsDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private DepartmentsDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDEPARTMENT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBUDGET;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLOCATION;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPHONE1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPHONE2;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private MyToolTipController myToolTipController1;
    }
}

