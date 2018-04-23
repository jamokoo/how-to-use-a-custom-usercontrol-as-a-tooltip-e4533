using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolTipControllerExample {
    public partial class DialingForm : Form {
        public DialingForm(string number) {
            InitializeComponent();
            DialNumber = number;
        }
        public string DialNumber { set { textEdit1.Text = value; } }
    }
}
