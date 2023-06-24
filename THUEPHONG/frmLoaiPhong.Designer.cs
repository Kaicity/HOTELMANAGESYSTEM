namespace THUEPHONG
{
    partial class frmLoaiPhong
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
            this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SONGUOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkDis = new System.Windows.Forms.CheckBox();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numSoGiuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numDongia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tfTen = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGiuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDongia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTen.Properties)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(743, 42);
            this.toolStrip1.TabIndex = 2;
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
            this.gcDanhSach.Size = new System.Drawing.Size(743, 290);
            this.gcDanhSach.TabIndex = 3;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.IDLOAIPHONG,
            this.TENLOAIPHONG,
            this.DONGIA,
            this.SONGUOI,
            this.SOGIUONG});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // DISABLED
            // 
            this.DISABLED.Caption = "DEL";
            this.DISABLED.FieldName = "DISABLED";
            this.DISABLED.MaxWidth = 40;
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.Visible = true;
            this.DISABLED.VisibleIndex = 0;
            this.DISABLED.Width = 40;
            // 
            // IDLOAIPHONG
            // 
            this.IDLOAIPHONG.Caption = "ID";
            this.IDLOAIPHONG.FieldName = "IDLOAIPHONG";
            this.IDLOAIPHONG.Name = "IDLOAIPHONG";
            this.IDLOAIPHONG.Visible = true;
            this.IDLOAIPHONG.VisibleIndex = 1;
            // 
            // TENLOAIPHONG
            // 
            this.TENLOAIPHONG.Caption = "Tên loại phòng";
            this.TENLOAIPHONG.FieldName = "TENLOAIPHONG";
            this.TENLOAIPHONG.MaxWidth = 250;
            this.TENLOAIPHONG.MinWidth = 200;
            this.TENLOAIPHONG.Name = "TENLOAIPHONG";
            this.TENLOAIPHONG.Visible = true;
            this.TENLOAIPHONG.VisibleIndex = 2;
            this.TENLOAIPHONG.Width = 250;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "Đơn giá";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MaxWidth = 150;
            this.DONGIA.MinWidth = 100;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 3;
            this.DONGIA.Width = 100;
            // 
            // SONGUOI
            // 
            this.SONGUOI.Caption = "Số người";
            this.SONGUOI.FieldName = "SONGUOI";
            this.SONGUOI.MaxWidth = 100;
            this.SONGUOI.MinWidth = 50;
            this.SONGUOI.Name = "SONGUOI";
            this.SONGUOI.Visible = true;
            this.SONGUOI.VisibleIndex = 4;
            this.SONGUOI.Width = 100;
            // 
            // SOGIUONG
            // 
            this.SOGIUONG.Caption = "Số giường";
            this.SOGIUONG.FieldName = "SOGIUONG";
            this.SOGIUONG.MaxWidth = 100;
            this.SOGIUONG.MinWidth = 50;
            this.SOGIUONG.Name = "SOGIUONG";
            this.SOGIUONG.Visible = true;
            this.SOGIUONG.VisibleIndex = 5;
            this.SOGIUONG.Width = 100;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.checkDis);
            this.groupControl1.Controls.Add(this.numSoNguoi);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.numSoGiuong);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.numDongia);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.tfTen);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 332);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(743, 140);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin";
            // 
            // checkDis
            // 
            this.checkDis.AutoSize = true;
            this.checkDis.Location = new System.Drawing.Point(633, 45);
            this.checkDis.Name = "checkDis";
            this.checkDis.Size = new System.Drawing.Size(66, 17);
            this.checkDis.TabIndex = 21;
            this.checkDis.Text = "Disabled";
            this.checkDis.UseVisualStyleBackColor = true;
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Location = new System.Drawing.Point(121, 87);
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(116, 21);
            this.numSoNguoi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số người";
            // 
            // numSoGiuong
            // 
            this.numSoGiuong.Location = new System.Drawing.Point(451, 87);
            this.numSoGiuong.Name = "numSoGiuong";
            this.numSoGiuong.Size = new System.Drawing.Size(145, 21);
            this.numSoGiuong.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số giường";
            // 
            // numDongia
            // 
            this.numDongia.Location = new System.Drawing.Point(451, 44);
            this.numDongia.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numDongia.Name = "numDongia";
            this.numDongia.Size = new System.Drawing.Size(145, 21);
            this.numDongia.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Đơn giá";
            // 
            // tfTen
            // 
            this.tfTen.Location = new System.Drawing.Point(121, 45);
            this.tfTen.Name = "tfTen";
            this.tfTen.Size = new System.Drawing.Size(217, 20);
            this.tfTen.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại phòng";
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 472);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục loại phòng";
            this.Load += new System.EventHandler(this.frmLoaiPhong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGiuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDongia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTen.Properties)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn SONGUOI;
        private DevExpress.XtraGrid.Columns.GridColumn SOGIUONG;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSoGiuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDongia;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit tfTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkDis;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
        private DevExpress.XtraGrid.Columns.GridColumn IDLOAIPHONG;
    }
}