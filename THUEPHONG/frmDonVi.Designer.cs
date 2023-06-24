namespace THUEPHONG
{
    partial class frmDonVi
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoqua = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MADVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENDVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MACTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbMacty = new System.Windows.Forms.ComboBox();
            this.tfDiachi = new DevExpress.XtraEditors.TextEdit();
            this.tfEmail = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.tfFax = new DevExpress.XtraEditors.TextEdit();
            this.tfDienthoai = new DevExpress.XtraEditors.TextEdit();
            this.tfTen = new DevExpress.XtraEditors.TextEdit();
            this.tfMadvi = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMadvi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnBoqua,
            this.btnThoat,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(911, 42);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::THUEPHONG.Properties.Resources.plus;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(41, 39);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::THUEPHONG.Properties.Resources.edit;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(30, 39);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::THUEPHONG.Properties.Resources.delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(31, 39);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::THUEPHONG.Properties.Resources.diskette;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(31, 39);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = global::THUEPHONG.Properties.Resources.reload;
            this.btnBoqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(48, 39);
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::THUEPHONG.Properties.Resources.arrow;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 39);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 42);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(911, 290);
            this.gcDanhSach.TabIndex = 2;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MADVI,
            this.TENDVI,
            this.DTHOAI,
            this.FAX,
            this.EMAIL,
            this.DIACHI,
            this.MACTY});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // MADVI
            // 
            this.MADVI.Caption = "Mã đơn vị";
            this.MADVI.FieldName = "MADVI";
            this.MADVI.MaxWidth = 100;
            this.MADVI.MinWidth = 50;
            this.MADVI.Name = "MADVI";
            this.MADVI.Visible = true;
            this.MADVI.VisibleIndex = 0;
            this.MADVI.Width = 50;
            // 
            // TENDVI
            // 
            this.TENDVI.Caption = "Tên đơn vị";
            this.TENDVI.FieldName = "TENDVI";
            this.TENDVI.MaxWidth = 70;
            this.TENDVI.MinWidth = 50;
            this.TENDVI.Name = "TENDVI";
            this.TENDVI.Visible = true;
            this.TENDVI.VisibleIndex = 1;
            this.TENDVI.Width = 50;
            // 
            // DTHOAI
            // 
            this.DTHOAI.Caption = "Điện thoại";
            this.DTHOAI.FieldName = "DIENTHOAI";
            this.DTHOAI.MaxWidth = 250;
            this.DTHOAI.MinWidth = 200;
            this.DTHOAI.Name = "DTHOAI";
            this.DTHOAI.Visible = true;
            this.DTHOAI.VisibleIndex = 2;
            this.DTHOAI.Width = 250;
            // 
            // FAX
            // 
            this.FAX.Caption = "Fax";
            this.FAX.FieldName = "FAX";
            this.FAX.MaxWidth = 120;
            this.FAX.MinWidth = 80;
            this.FAX.Name = "FAX";
            this.FAX.Visible = true;
            this.FAX.VisibleIndex = 3;
            this.FAX.Width = 80;
            // 
            // EMAIL
            // 
            this.EMAIL.Caption = "Email";
            this.EMAIL.FieldName = "EMAIL";
            this.EMAIL.MaxWidth = 200;
            this.EMAIL.MinWidth = 150;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 4;
            this.EMAIL.Width = 150;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "Địa chỉ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 5;
            // 
            // MACTY
            // 
            this.MACTY.Caption = "Mã công ty";
            this.MACTY.FieldName = "MACTY";
            this.MACTY.Name = "MACTY";
            this.MACTY.Visible = true;
            this.MACTY.VisibleIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbMacty);
            this.groupControl1.Controls.Add(this.tfDiachi);
            this.groupControl1.Controls.Add(this.tfEmail);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.tfFax);
            this.groupControl1.Controls.Add(this.tfDienthoai);
            this.groupControl1.Controls.Add(this.tfTen);
            this.groupControl1.Controls.Add(this.tfMadvi);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 332);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(911, 191);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin";
            // 
            // cbMacty
            // 
            this.cbMacty.FormattingEnabled = true;
            this.cbMacty.Location = new System.Drawing.Point(176, 48);
            this.cbMacty.Name = "cbMacty";
            this.cbMacty.Size = new System.Drawing.Size(381, 21);
            this.cbMacty.TabIndex = 20;
            // 
            // tfDiachi
            // 
            this.tfDiachi.Location = new System.Drawing.Point(96, 146);
            this.tfDiachi.Name = "tfDiachi";
            this.tfDiachi.Size = new System.Drawing.Size(753, 20);
            this.tfDiachi.TabIndex = 18;
            // 
            // tfEmail
            // 
            this.tfEmail.Location = new System.Drawing.Point(623, 117);
            this.tfEmail.Name = "tfEmail";
            this.tfEmail.Size = new System.Drawing.Size(226, 20);
            this.tfEmail.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Công ty / Chi nhánh";
            // 
            // tfFax
            // 
            this.tfFax.Location = new System.Drawing.Point(401, 116);
            this.tfFax.Name = "tfFax";
            this.tfFax.Properties.MaxLength = 10;
            this.tfFax.Size = new System.Drawing.Size(156, 20);
            this.tfFax.TabIndex = 16;
            this.tfFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tfFax_KeyPress_1);
            // 
            // tfDienthoai
            // 
            this.tfDienthoai.Location = new System.Drawing.Point(96, 116);
            this.tfDienthoai.Name = "tfDienthoai";
            this.tfDienthoai.Properties.MaxLength = 10;
            this.tfDienthoai.Size = new System.Drawing.Size(242, 20);
            this.tfDienthoai.TabIndex = 15;
            this.tfDienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tfDienthoai_KeyPress);
            // 
            // tfTen
            // 
            this.tfTen.Location = new System.Drawing.Point(401, 83);
            this.tfTen.Name = "tfTen";
            this.tfTen.Size = new System.Drawing.Size(448, 20);
            this.tfTen.TabIndex = 14;
            // 
            // tfMadvi
            // 
            this.tfMadvi.Location = new System.Drawing.Point(96, 84);
            this.tfMadvi.Name = "tfMadvi";
            this.tfMadvi.Size = new System.Drawing.Size(242, 20);
            this.tfMadvi.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // frmDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 523);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDonVi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục đơn vị";
            this.Load += new System.EventHandler(this.frmDonVi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMadvi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoqua;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MADVI;
        private DevExpress.XtraGrid.Columns.GridColumn TENDVI;
        private DevExpress.XtraGrid.Columns.GridColumn DTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn FAX;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tfDiachi;
        private DevExpress.XtraEditors.TextEdit tfEmail;
        private DevExpress.XtraEditors.TextEdit tfFax;
        private DevExpress.XtraEditors.TextEdit tfDienthoai;
        private DevExpress.XtraEditors.TextEdit tfMadvi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn MACTY;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit tfTen;
        private System.Windows.Forms.ComboBox cbMacty;
    }
}