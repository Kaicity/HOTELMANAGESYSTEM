namespace THUEPHONG
{
    partial class frmConnectDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbBoxDB = new System.Windows.Forms.ComboBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tfPass = new System.Windows.Forms.TextBox();
            this.tfUs = new System.Windows.Forms.TextBox();
            this.tfSe = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbBoxDB);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.tfPass);
            this.groupControl1.Controls.Add(this.tfUs);
            this.groupControl1.Controls.Add(this.tfSe);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(414, 250);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kết nối cơ sở dữ liệu";
            // 
            // cbBoxDB
            // 
            this.cbBoxDB.FormattingEnabled = true;
            this.cbBoxDB.Location = new System.Drawing.Point(106, 156);
            this.cbBoxDB.Name = "cbBoxDB";
            this.cbBoxDB.Size = new System.Drawing.Size(259, 21);
            this.cbBoxDB.TabIndex = 11;
            this.cbBoxDB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbBoxDB_MouseClick_1);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(282, 198);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(100, 35);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Thoát";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(162, 198);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(97, 35);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Lưu";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(37, 198);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(98, 35);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Kiểm tra ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tfPass
            // 
            this.tfPass.Location = new System.Drawing.Point(106, 116);
            this.tfPass.Name = "tfPass";
            this.tfPass.Size = new System.Drawing.Size(259, 21);
            this.tfPass.TabIndex = 6;
            // 
            // tfUs
            // 
            this.tfUs.Location = new System.Drawing.Point(106, 75);
            this.tfUs.Name = "tfUs";
            this.tfUs.Size = new System.Drawing.Size(259, 21);
            this.tfUs.TabIndex = 5;
            // 
            // tfSe
            // 
            this.tfSe.Location = new System.Drawing.Point(106, 41);
            this.tfSe.Name = "tfSe";
            this.tfSe.Size = new System.Drawing.Size(259, 21);
            this.tfSe.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Database";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Password";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Username";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Server";
            // 
            // frmConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 274);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmConnectDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConnectDB";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox tfPass;
        private System.Windows.Forms.TextBox tfUs;
        private System.Windows.Forms.TextBox tfSe;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cbBoxDB;
    }
}