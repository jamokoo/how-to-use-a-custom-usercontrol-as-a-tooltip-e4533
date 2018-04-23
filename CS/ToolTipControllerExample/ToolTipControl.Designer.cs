namespace ToolTipControllerExample {
    partial class ToolTipControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbDepartment = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.beLocation = new DevExpress.XtraEditors.ButtonEdit();
            this.bePhone = new DevExpress.XtraEditors.ButtonEdit();
            this.seBudget = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bePhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seBudget.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.panelControl1);
            this.popupControlContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupControlContainer1.Location = new System.Drawing.Point(0, 0);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(192, 113);
            this.popupControlContainer1.TabIndex = 0;
            this.popupControlContainer1.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lbDepartment);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.beLocation);
            this.panelControl1.Controls.Add(this.bePhone);
            this.panelControl1.Controls.Add(this.seBudget);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(192, 113);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl5.Location = new System.Drawing.Point(173, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(14, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "[x]";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 83);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Phone";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Location";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Budget";
            // 
            // lbDepartment
            // 
            this.lbDepartment.Location = new System.Drawing.Point(74, 6);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(8, 13);
            this.lbDepartment.TabIndex = 4;
            this.lbDepartment.Text = "\"\"";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Department";
            // 
            // beLocation
            // 
            this.beLocation.Location = new System.Drawing.Point(74, 54);
            this.beLocation.Name = "beLocation";
            this.beLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::ToolTipControllerExample.Properties.Resources._1361454060_applications_internet, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.beLocation.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beLocation_Properties_ButtonClick);
            this.beLocation.Size = new System.Drawing.Size(100, 22);
            this.beLocation.TabIndex = 2;
            // 
            // bePhone
            // 
            this.bePhone.Location = new System.Drawing.Point(74, 80);
            this.bePhone.Name = "bePhone";
            this.bePhone.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::ToolTipControllerExample.Properties.Resources._1361453678_phone, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.bePhone.Size = new System.Drawing.Size(100, 22);
            this.bePhone.TabIndex = 1;
            this.bePhone.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bePhone_ButtonClick);
            // 
            // seBudget
            // 
            this.seBudget.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seBudget.Location = new System.Drawing.Point(74, 28);
            this.seBudget.Name = "seBudget";
            this.seBudget.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seBudget.Size = new System.Drawing.Size(100, 20);
            this.seBudget.TabIndex = 0;
            // 
            // ToolTipControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.popupControlContainer1);
            this.Name = "ToolTipControl";
            this.Size = new System.Drawing.Size(192, 113);
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bePhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seBudget.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit beLocation;
        private DevExpress.XtraEditors.ButtonEdit bePhone;
        private DevExpress.XtraEditors.SpinEdit seBudget;
    }
}
