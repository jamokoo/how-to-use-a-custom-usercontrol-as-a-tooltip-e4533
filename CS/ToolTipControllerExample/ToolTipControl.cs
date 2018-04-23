using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace ToolTipControllerExample {
    public partial class ToolTipControl : DevExpress.XtraEditors.XtraUserControl {
        public ToolTipControl() {
            InitializeComponent();
            seBudget.Properties.ReadOnly = true;
            bePhone.Properties.ReadOnly = true;
            beLocation.Properties.ReadOnly = true;
        }

        public decimal Budget { set { seBudget.Value = value; } }
        public string Department { set { lbDepartment.Text = value; } }
        public string Phone { set { bePhone.Text = value; } }
        public string DepartmentLocation { set { beLocation.Text = value; } }

        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);
            if(this.Visible) {
                popupControlContainer1.Show();
            }
        }

        private void labelControl5_Click(object sender, EventArgs e) {
            this.popupControlContainer1.Hide();
            this.Hide();
        }

        private void bePhone_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            Form df = new DialingForm(bePhone.Text);
            df.Show();
        }

        private void beLocation_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            Form2 locating = new Form2();
            locating.Show();
        }
    }
}
