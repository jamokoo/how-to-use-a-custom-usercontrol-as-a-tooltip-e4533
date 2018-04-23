using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Diagnostics;

namespace ToolTipControllerExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            //myToolTipController1.ToolTipControl = new ToolTipControl();
            myToolTipController1.GetActiveObjectInfo += new ToolTipControllerGetActiveObjectInfoEventHandler(myToolTipController1_GetActiveObjectInfo);
        }

        void myToolTipController1_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e) {
            if(e.SelectedControl is DevExpress.XtraTreeList.TreeList) {
                TreeList tree = (TreeList)e.SelectedControl;
                TreeListHitInfo hit = tree.CalcHitInfo(e.ControlMousePosition);
                if(hit.HitInfoType == HitInfoType.Cell && hit.HitInfoType != HitInfoType.Empty) {
                    myToolTipController1.ToolTipControlParent = e.SelectedControl;
                    myToolTipController1.ToolTipControl.Department = hit.Node.GetDisplayText("DEPARTMENT");
                    myToolTipController1.ToolTipControl.Phone = hit.Node.GetDisplayText("PHONE1");
                    myToolTipController1.ToolTipControl.DepartmentLocation = hit.Node.GetDisplayText("LOCATION");
                    myToolTipController1.ToolTipControl.Budget = Convert.ToDecimal(hit.Node.GetDisplayText("BUDGET"));
                    myToolTipController1.ToolTipControl.Location = new Point(hit.Bounds.X, hit.Bounds.Y + hit.Bounds.Height);
                    e.Info = new DevExpress.Utils.ToolTipControlInfo("", "");
                }
                else {
                    myToolTipController1.ToolTipControl.Hide();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'departmentsDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.departmentsDataSet.Departments);
        }
    }
}