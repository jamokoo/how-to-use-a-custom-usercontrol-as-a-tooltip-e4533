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

namespace ToolTipControllerExample {
    public class MyToolTipController : ToolTipController {
        ToolTipControl _toolTipControl;

        public ToolTipControl ToolTipControl {
            get { return _toolTipControl; }
            set {
                _toolTipControl = value;
            }
        }

        public Control ToolTipControlParent {
            get { return _toolTipControl.Parent; }
            set { _toolTipControl.Parent = value; }
        }
        public MyToolTipController()
            : base() {
            _toolTipControl = new ToolTipControl();
            
        }
        protected override void OnInitialTimerTick(object sender, EventArgs e) {
            _toolTipControl.Show();
        }
        protected override void HideToolWindow() {
            _toolTipControl.Hide();
            base.HideToolWindow();
        }
        protected override void ActiveObjectChanged(Control prevControl, object prevObject) {
            base.ActiveObjectChanged(prevControl, prevObject);
        }
    }
}
