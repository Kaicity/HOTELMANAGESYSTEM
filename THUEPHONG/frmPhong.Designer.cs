namespace THUEPHONG
{
    partial class frmPhong
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
            this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IMAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xxx = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tfTen = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(932, 42);
            this.toolStrip1.TabIndex = 4;
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
            this.gcDanhSach.Size = new System.Drawing.Size(932, 302);
            this.gcDanhSach.TabIndex = 5;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPHONG,
            this.TENPHONG,
            this.TRANGTHAI,
            this.IDTANG,
            this.IDLOAIPHONG,
            this.IMAGE});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // IDPHONG
            // 
            this.IDPHONG.Caption = "ID";
            this.IDPHONG.FieldName = "IDPHONG";
            this.IDPHONG.MaxWidth = 40;
            this.IDPHONG.Name = "IDPHONG";
            this.IDPHONG.Visible = true;
            this.IDPHONG.VisibleIndex = 0;
            this.IDPHONG.Width = 40;
            // 
            // TENPHONG
            // 
            this.TENPHONG.Caption = "Tên Phòng";
            this.TENPHONG.FieldName = "TENPHONG";
            this.TENPHONG.MaxWidth = 250;
            this.TENPHONG.MinWidth = 225;
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Visible = true;
            this.TENPHONG.VisibleIndex = 1;
            this.TENPHONG.Width = 250;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.Caption = "Trạng thái";
            this.TRANGTHAI.FieldName = "TRANGTHAI";
            this.TRANGTHAI.MaxWidth = 60;
            this.TRANGTHAI.MinWidth = 30;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = true;
            this.TRANGTHAI.VisibleIndex = 2;
            this.TRANGTHAI.Width = 60;
            // 
            // IDTANG
            // 
            this.IDTANG.Caption = "ID Tầng";
            this.IDTANG.FieldName = "IDTANG";
            this.IDTANG.MaxWidth = 80;
            this.IDTANG.MinWidth = 60;
            this.IDTANG.Name = "IDTANG";
            this.IDTANG.Visible = true;
            this.IDTANG.VisibleIndex = 3;
            this.IDTANG.Width = 80;
            // 
            // IDLOAIPHONG
            // 
            this.IDLOAIPHONG.Caption = "ID Loại phòng";
            this.IDLOAIPHONG.FieldName = "IDLOAIPHONG";
            this.IDLOAIPHONG.MaxWidth = 80;
            this.IDLOAIPHONG.MinWidth = 60;
            this.IDLOAIPHONG.Name = "IDLOAIPHONG";
            this.IDLOAIPHONG.Visible = true;
            this.IDLOAIPHONG.VisibleIndex = 4;
            this.IDLOAIPHONG.Width = 80;
            // 
            // IMAGE
            // 
            this.IMAGE.Caption = "Hình ảnh";
            this.IMAGE.FieldName = "IMAGE";
            this.IMAGE.MaxWidth = 400;
            this.IMAGE.MinWidth = 350;
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.Visible = true;
            this.IMAGE.VisibleIndex = 5;
            this.IMAGE.Width = 350;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.picBox);
            this.groupControl1.Controls.Add(this.checkStatus);
            this.groupControl1.Controls.Add(this.cbLoaiPhong);
            this.groupControl1.Controls.Add(this.cbTang);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.xxx);
            this.groupControl1.Controls.Add(this.status);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.tfTen);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 344);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(932, 266);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Thông tin";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Image = global::THUEPHONG.Properties.Resources._68747470733a2f2f662e636c6f75642e6769746875622e636f6d2f6173736574732f323037383234352f3235393331332f35653833313336322d386362612d313165322d383435332d6536626439353663383961342e706e67;
            this.picBox.Location = new System.Drawing.Point(27, 39);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(280, 200);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 25;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            this.picBox.MouseEnter += new System.EventHandler(this.picBox_MouseEnter);
            this.picBox.MouseLeave += new System.EventHandler(this.picBox_MouseLeave);
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Location = new System.Drawing.Point(445, 88);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(59, 17);
            this.checkStatus.TabIndex = 24;
            this.checkStatus.Text = "Đã đặt";
            this.checkStatus.UseVisualStyleBackColor = true;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(445, 168);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(234, 21);
            this.cbLoaiPhong.TabIndex = 22;
            // 
            // cbTang
            // 
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Location = new System.Drawing.Point(445, 124);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(234, 21);
            this.cbTang.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Loại phòng";
            // 
            // xxx
            // 
            this.xxx.AutoSize = true;
            this.xxx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xxx.Location = new System.Drawing.Point(359, 130);
            this.xxx.Name = "xxx";
            this.xxx.Size = new System.Drawing.Size(33, 15);
            this.xxx.TabIndex = 19;
            this.xxx.Text = "Tầng";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(359, 90);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(59, 15);
            this.status.TabIndex = 17;
            this.status.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Chọn hình ảnh phòng";
            // 
            // tfTen
            // 
            this.tfTen.Location = new System.Drawing.Point(445, 46);
            this.tfTen.Name = "tfTen";
            this.tfTen.Size = new System.Drawing.Size(438, 20);
            this.tfTen.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng";
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 610);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng khách sạn";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tfTen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TRANGTHAI;
        private DevExpress.XtraGrid.Columns.GridColumn IDTANG;
        private DevExpress.XtraGrid.Columns.GridColumn IDLOAIPHONG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ComboBox cbTang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label xxx;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.CheckBox checkStatus;
        private DevExpress.XtraGrid.Columns.GridColumn IMAGE;
        private System.Windows.Forms.PictureBox picBox;
    }
}