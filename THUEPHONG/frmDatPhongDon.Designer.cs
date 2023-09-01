namespace THUEPHONG
{
    partial class frmDatPhongDon
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
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoqua = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tfSoNgayO = new System.Windows.Forms.TextBox();
            this.calcEdit1 = new DevExpress.XtraEditors.CalcEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tfGiaPhong = new System.Windows.Forms.TextBox();
            this.tfSlPhong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tfGiaTienDPSP = new System.Windows.Forms.TextBox();
            this.tfSl_DPSP = new System.Windows.Forms.TextBox();
            this.tfTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.gvSuDungSPDV = new System.Windows.Forms.DataGridView();
            this.spIDSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spTENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spIDPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spTENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spSOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spDONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spTHANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spIDDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchCbKhachang = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfHienThiTenPhong = new System.Windows.Forms.Label();
            this.numSLNguoi = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tfGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNewKH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvSanPhamDV = new System.Windows.Forms.DataGridView();
            this.IDSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuDungSPDV)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCbKhachang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLNguoi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamDV)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLuu,
            this.btnBoqua,
            this.btnIn,
            this.btnThoat,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1128, 42);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btnBoqua.Size = new System.Drawing.Size(58, 39);
            this.btnBoqua.Text = "Làm mới";
            this.btnBoqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::THUEPHONG.Properties.Resources.printer;
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(24, 39);
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1128, 616);
            this.splitContainer1.SplitterDistance = 740;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.tfSoNgayO);
            this.groupBox5.Controls.Add(this.calcEdit1);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.tfGiaPhong);
            this.groupBox5.Controls.Add(this.tfSlPhong);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tfGiaTienDPSP);
            this.groupBox5.Controls.Add(this.tfSl_DPSP);
            this.groupBox5.Controls.Add(this.tfTotal);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(3, 462);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(731, 151);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TỔNG THANH TOÁN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(568, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 23);
            this.label15.TabIndex = 12;
            this.label15.Text = "Số đêm";
            // 
            // tfSoNgayO
            // 
            this.tfSoNgayO.BackColor = System.Drawing.SystemColors.Info;
            this.tfSoNgayO.Enabled = false;
            this.tfSoNgayO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfSoNgayO.Location = new System.Drawing.Point(655, 59);
            this.tfSoNgayO.Name = "tfSoNgayO";
            this.tfSoNgayO.Size = new System.Drawing.Size(62, 27);
            this.tfSoNgayO.TabIndex = 11;
            // 
            // calcEdit1
            // 
            this.calcEdit1.Location = new System.Drawing.Point(589, 21);
            this.calcEdit1.Name = "calcEdit1";
            this.calcEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.calcEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.calcEdit1.Properties.Appearance.Options.UseFont = true;
            this.calcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit1.Size = new System.Drawing.Size(128, 26);
            this.calcEdit1.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(257, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "Thành tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Số lượng Phòng";
            // 
            // tfGiaPhong
            // 
            this.tfGiaPhong.BackColor = System.Drawing.SystemColors.Info;
            this.tfGiaPhong.Enabled = false;
            this.tfGiaPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfGiaPhong.Location = new System.Drawing.Point(375, 59);
            this.tfGiaPhong.Name = "tfGiaPhong";
            this.tfGiaPhong.Size = new System.Drawing.Size(177, 27);
            this.tfGiaPhong.TabIndex = 7;
            // 
            // tfSlPhong
            // 
            this.tfSlPhong.BackColor = System.Drawing.SystemColors.Info;
            this.tfSlPhong.Enabled = false;
            this.tfSlPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfSlPhong.Location = new System.Drawing.Point(175, 60);
            this.tfSlPhong.Name = "tfSlPhong";
            this.tfSlPhong.Size = new System.Drawing.Size(76, 27);
            this.tfSlPhong.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(257, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Thành tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số lượng SPDV";
            // 
            // tfGiaTienDPSP
            // 
            this.tfGiaTienDPSP.BackColor = System.Drawing.SystemColors.Info;
            this.tfGiaTienDPSP.Enabled = false;
            this.tfGiaTienDPSP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfGiaTienDPSP.Location = new System.Drawing.Point(375, 20);
            this.tfGiaTienDPSP.Name = "tfGiaTienDPSP";
            this.tfGiaTienDPSP.Size = new System.Drawing.Size(177, 27);
            this.tfGiaTienDPSP.TabIndex = 3;
            // 
            // tfSl_DPSP
            // 
            this.tfSl_DPSP.BackColor = System.Drawing.SystemColors.Info;
            this.tfSl_DPSP.Enabled = false;
            this.tfSl_DPSP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfSl_DPSP.Location = new System.Drawing.Point(175, 21);
            this.tfSl_DPSP.Name = "tfSl_DPSP";
            this.tfSl_DPSP.Size = new System.Drawing.Size(76, 27);
            this.tfSl_DPSP.TabIndex = 2;
            // 
            // tfTotal
            // 
            this.tfTotal.BackColor = System.Drawing.SystemColors.Info;
            this.tfTotal.Enabled = false;
            this.tfTotal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfTotal.ForeColor = System.Drawing.Color.Red;
            this.tfTotal.Location = new System.Drawing.Point(175, 97);
            this.tfTotal.Name = "tfTotal";
            this.tfTotal.Size = new System.Drawing.Size(377, 36);
            this.tfTotal.TabIndex = 2;
            this.tfTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "TỔNG TIỀN";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox3.Controls.Add(this.picLoading);
            this.groupBox3.Controls.Add(this.gvSuDungSPDV);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(8, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 246);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách Sản phẩm - Dịch vụ";
            // 
            // picLoading
            // 
            this.picLoading.Image = global::THUEPHONG.Properties.Resources.icons8_spinning_circle;
            this.picLoading.Location = new System.Drawing.Point(542, 68);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(43, 41);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoading.TabIndex = 6;
            this.picLoading.TabStop = false;
            // 
            // gvSuDungSPDV
            // 
            this.gvSuDungSPDV.AllowUserToAddRows = false;
            this.gvSuDungSPDV.AllowUserToResizeColumns = false;
            this.gvSuDungSPDV.AllowUserToResizeRows = false;
            this.gvSuDungSPDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSuDungSPDV.BackgroundColor = System.Drawing.Color.White;
            this.gvSuDungSPDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSuDungSPDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSuDungSPDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spIDSP,
            this.spTENPHONG,
            this.spIDPHONG,
            this.spTENSP,
            this.spSOLUONG,
            this.spDONGIA,
            this.spTHANHTIEN,
            this.spIDDP});
            this.gvSuDungSPDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSuDungSPDV.Location = new System.Drawing.Point(3, 22);
            this.gvSuDungSPDV.Name = "gvSuDungSPDV";
            this.gvSuDungSPDV.RowHeadersVisible = false;
            this.gvSuDungSPDV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSuDungSPDV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gvSuDungSPDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSuDungSPDV.Size = new System.Drawing.Size(723, 221);
            this.gvSuDungSPDV.TabIndex = 1;
            this.gvSuDungSPDV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSuDungSPDV_CellDoubleClick);
            this.gvSuDungSPDV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvSuDungSPDV_CellFormatting);
            this.gvSuDungSPDV.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gvSuDungSPDV_CellValidating);
            this.gvSuDungSPDV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSuDungSPDV_CellValueChanged);
            // 
            // spIDSP
            // 
            this.spIDSP.DataPropertyName = "IDSP";
            this.spIDSP.HeaderText = "";
            this.spIDSP.Name = "spIDSP";
            this.spIDSP.Visible = false;
            // 
            // spTENPHONG
            // 
            this.spTENPHONG.DataPropertyName = "TENPHONG";
            this.spTENPHONG.FillWeight = 139.8845F;
            this.spTENPHONG.HeaderText = "PHÒNG";
            this.spTENPHONG.MinimumWidth = 90;
            this.spTENPHONG.Name = "spTENPHONG";
            this.spTENPHONG.ReadOnly = true;
            // 
            // spIDPHONG
            // 
            this.spIDPHONG.DataPropertyName = "IDPHONG";
            this.spIDPHONG.HeaderText = "";
            this.spIDPHONG.MinimumWidth = 25;
            this.spIDPHONG.Name = "spIDPHONG";
            this.spIDPHONG.Visible = false;
            // 
            // spTENSP
            // 
            this.spTENSP.DataPropertyName = "TENSP";
            this.spTENSP.FillWeight = 249.1243F;
            this.spTENSP.HeaderText = "TÊN SP - DV";
            this.spTENSP.MinimumWidth = 80;
            this.spTENSP.Name = "spTENSP";
            this.spTENSP.ReadOnly = true;
            // 
            // spSOLUONG
            // 
            this.spSOLUONG.DataPropertyName = "SOLUONG";
            this.spSOLUONG.FillWeight = 43.14721F;
            this.spSOLUONG.HeaderText = "SỐ LƯỢNG";
            this.spSOLUONG.MinimumWidth = 70;
            this.spSOLUONG.Name = "spSOLUONG";
            // 
            // spDONGIA
            // 
            this.spDONGIA.DataPropertyName = "DONGIA";
            this.spDONGIA.FillWeight = 33.92199F;
            this.spDONGIA.HeaderText = "ĐƠN GIÁ";
            this.spDONGIA.MinimumWidth = 90;
            this.spDONGIA.Name = "spDONGIA";
            this.spDONGIA.ReadOnly = true;
            // 
            // spTHANHTIEN
            // 
            this.spTHANHTIEN.DataPropertyName = "THANHTIEN";
            this.spTHANHTIEN.FillWeight = 33.92199F;
            this.spTHANHTIEN.HeaderText = "THÀNH TIỀN";
            this.spTHANHTIEN.MinimumWidth = 100;
            this.spTHANHTIEN.Name = "spTHANHTIEN";
            this.spTHANHTIEN.ReadOnly = true;
            // 
            // spIDDP
            // 
            this.spIDDP.DataPropertyName = "IDDP";
            this.spIDDP.HeaderText = "";
            this.spIDDP.Name = "spIDDP";
            this.spIDDP.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchCbKhachang);
            this.groupBox4.Controls.Add(this.tfHienThiTenPhong);
            this.groupBox4.Controls.Add(this.numSLNguoi);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tfGhiChu);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbTrangThai);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dateNgayTra);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dateNgayDat);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnAddNewKH);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(729, 201);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phòng đặt";
            // 
            // searchCbKhachang
            // 
            this.searchCbKhachang.Location = new System.Drawing.Point(113, 63);
            this.searchCbKhachang.Name = "searchCbKhachang";
            this.searchCbKhachang.Properties.Appearance.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchCbKhachang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCbKhachang.Properties.Appearance.Options.UseBackColor = true;
            this.searchCbKhachang.Properties.Appearance.Options.UseFont = true;
            this.searchCbKhachang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCbKhachang.Properties.NullText = "";
            this.searchCbKhachang.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchCbKhachang.Size = new System.Drawing.Size(531, 26);
            this.searchCbKhachang.TabIndex = 32;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDKH,
            this.HOTEN});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IDKH
            // 
            this.IDKH.Caption = "ID";
            this.IDKH.FieldName = "IDKH";
            this.IDKH.MaxWidth = 50;
            this.IDKH.MinWidth = 30;
            this.IDKH.Name = "IDKH";
            this.IDKH.Visible = true;
            this.IDKH.VisibleIndex = 0;
            this.IDKH.Width = 50;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HỌ TÊN KHÁCH HÀNG";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 150;
            this.HOTEN.MinWidth = 100;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 100;
            // 
            // tfHienThiTenPhong
            // 
            this.tfHienThiTenPhong.AutoSize = true;
            this.tfHienThiTenPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfHienThiTenPhong.ForeColor = System.Drawing.Color.Red;
            this.tfHienThiTenPhong.Location = new System.Drawing.Point(174, 21);
            this.tfHienThiTenPhong.Name = "tfHienThiTenPhong";
            this.tfHienThiTenPhong.Size = new System.Drawing.Size(46, 25);
            this.tfHienThiTenPhong.TabIndex = 31;
            this.tfHienThiTenPhong.Text = "_ _ _";
            // 
            // numSLNguoi
            // 
            this.numSLNguoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSLNguoi.Location = new System.Drawing.Point(431, 126);
            this.numSLNguoi.Name = "numSLNguoi";
            this.numSLNguoi.Size = new System.Drawing.Size(93, 29);
            this.numSLNguoi.TabIndex = 28;
            this.numSLNguoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(356, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Số lượng";
            // 
            // tfGhiChu
            // 
            this.tfGhiChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfGhiChu.Location = new System.Drawing.Point(113, 161);
            this.tfGhiChu.Name = "tfGhiChu";
            this.tfGhiChu.Size = new System.Drawing.Size(531, 29);
            this.tfGhiChu.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ghi chú";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(113, 126);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(208, 29);
            this.cbTrangThai.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Trạng thái";
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.CustomFormat = "dd-MM-yyyy";
            this.dateNgayTra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayTra.Location = new System.Drawing.Point(431, 92);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(213, 29);
            this.dateNgayTra.TabIndex = 22;
            this.dateNgayTra.Value = new System.DateTime(2023, 6, 27, 0, 0, 0, 0);
            this.dateNgayTra.ValueChanged += new System.EventHandler(this.dateNgayTra_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(359, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày trả";
            // 
            // dateNgayDat
            // 
            this.dateNgayDat.CustomFormat = "dd-MM-yyyy";
            this.dateNgayDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDat.Location = new System.Drawing.Point(113, 92);
            this.dateNgayDat.Name = "dateNgayDat";
            this.dateNgayDat.Size = new System.Drawing.Size(208, 29);
            this.dateNgayDat.TabIndex = 20;
            this.dateNgayDat.Value = new System.DateTime(2023, 6, 27, 0, 0, 0, 0);
            this.dateNgayDat.ValueChanged += new System.EventHandler(this.dateNgayDat_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ngày đặt";
            // 
            // btnAddNewKH
            // 
            this.btnAddNewKH.Image = global::THUEPHONG.Properties.Resources.add;
            this.btnAddNewKH.Location = new System.Drawing.Point(665, 66);
            this.btnAddNewKH.Name = "btnAddNewKH";
            this.btnAddNewKH.Size = new System.Drawing.Size(24, 21);
            this.btnAddNewKH.TabIndex = 18;
            this.btnAddNewKH.UseVisualStyleBackColor = true;
            this.btnAddNewKH.Click += new System.EventHandler(this.btnAddNewKH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvSanPhamDV);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 610);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm dịch vụ";
            // 
            // gvSanPhamDV
            // 
            this.gvSanPhamDV.AllowUserToAddRows = false;
            this.gvSanPhamDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSanPhamDV.BackgroundColor = System.Drawing.Color.White;
            this.gvSanPhamDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSanPhamDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSanPhamDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSP,
            this.TENSP,
            this.DONGIA});
            this.gvSanPhamDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSanPhamDV.Location = new System.Drawing.Point(3, 23);
            this.gvSanPhamDV.Name = "gvSanPhamDV";
            this.gvSanPhamDV.ReadOnly = true;
            this.gvSanPhamDV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSanPhamDV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gvSanPhamDV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSanPhamDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSanPhamDV.Size = new System.Drawing.Size(372, 584);
            this.gvSanPhamDV.TabIndex = 1;
            this.gvSanPhamDV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvSanPhamDV_CellMouseDoubleClick);
            this.gvSanPhamDV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gvSanPhamDV_RowPostPaint);
            // 
            // IDSP
            // 
            this.IDSP.DataPropertyName = "IDSP";
            this.IDSP.FillWeight = 81.47208F;
            this.IDSP.HeaderText = "";
            this.IDSP.Name = "IDSP";
            this.IDSP.ReadOnly = true;
            this.IDSP.Visible = false;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.FillWeight = 81.47208F;
            this.TENSP.HeaderText = "TÊN SP- DV";
            this.TENSP.MinimumWidth = 90;
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.FillWeight = 137.0558F;
            this.DONGIA.HeaderText = "ĐƠN GIÁ";
            this.DONGIA.MinimumWidth = 70;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // frmDatPhongDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 658);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDatPhongDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng khách lẻ";
            this.Load += new System.EventHandler(this.frmDatPhongDon_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuDungSPDV)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCbKhachang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLNguoi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoqua;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numSLNguoi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tfGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateNgayTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateNgayDat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddNewKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gvSuDungSPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn spIDSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn spTENPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn spIDPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn spTENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn spSOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn spDONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn spTHANHTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn spIDDP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvSanPhamDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        public System.Windows.Forms.Label tfHienThiTenPhong;
        private System.Windows.Forms.PictureBox picLoading;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCbKhachang;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn IDKH;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tfSoNgayO;
        private DevExpress.XtraEditors.CalcEdit calcEdit1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tfGiaPhong;
        private System.Windows.Forms.TextBox tfSlPhong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tfGiaTienDPSP;
        private System.Windows.Forms.TextBox tfSl_DPSP;
        private System.Windows.Forms.TextBox tfTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
    }
}