namespace THUEPHONG
{
    partial class frmChuyenPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenPhong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChuyenPhong = new System.Windows.Forms.Button();
            this.seachLookDanhSachphong = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbPhongHientai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seachLookDanhSachphong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnChuyenPhong);
            this.groupBox1.Controls.Add(this.seachLookDanhSachphong);
            this.groupBox1.Controls.Add(this.lbPhongHientai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chuyển phòng đến";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::THUEPHONG.Properties.Resources.arrow;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(365, 163);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 41);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChuyenPhong
            // 
            this.btnChuyenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenPhong.ForeColor = System.Drawing.Color.Black;
            this.btnChuyenPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenPhong.Image")));
            this.btnChuyenPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenPhong.Location = new System.Drawing.Point(198, 163);
            this.btnChuyenPhong.Name = "btnChuyenPhong";
            this.btnChuyenPhong.Size = new System.Drawing.Size(155, 41);
            this.btnChuyenPhong.TabIndex = 4;
            this.btnChuyenPhong.Text = "Chuyển phòng";
            this.btnChuyenPhong.UseVisualStyleBackColor = true;
            this.btnChuyenPhong.Click += new System.EventHandler(this.btnChuyenPhong_Click);
            // 
            // seachLookDanhSachphong
            // 
            this.seachLookDanhSachphong.Location = new System.Drawing.Point(198, 118);
            this.seachLookDanhSachphong.Name = "seachLookDanhSachphong";
            this.seachLookDanhSachphong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seachLookDanhSachphong.Properties.NullText = "";
            this.seachLookDanhSachphong.Properties.PopupView = this.searchLookUpEdit1View;
            this.seachLookDanhSachphong.Size = new System.Drawing.Size(322, 20);
            this.seachLookDanhSachphong.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPHONG,
            this.TENPHONG,
            this.TENLOAIPHONG,
            this.DONGIA});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IDPHONG
            // 
            this.IDPHONG.FieldName = "IDPHONG";
            this.IDPHONG.Name = "IDPHONG";
            // 
            // TENPHONG
            // 
            this.TENPHONG.Caption = "TÊN PHÒNG";
            this.TENPHONG.FieldName = "TENPHONG";
            this.TENPHONG.MaxWidth = 120;
            this.TENPHONG.MinWidth = 100;
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Visible = true;
            this.TENPHONG.VisibleIndex = 0;
            this.TENPHONG.Width = 100;
            // 
            // TENLOAIPHONG
            // 
            this.TENLOAIPHONG.Caption = "LOẠI PHÒNG";
            this.TENLOAIPHONG.FieldName = "TENLOAIPHONG";
            this.TENLOAIPHONG.MaxWidth = 160;
            this.TENLOAIPHONG.MinWidth = 140;
            this.TENLOAIPHONG.Name = "TENLOAIPHONG";
            this.TENLOAIPHONG.Visible = true;
            this.TENLOAIPHONG.VisibleIndex = 1;
            this.TENLOAIPHONG.Width = 140;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "ĐƠN GIÁ";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MaxWidth = 80;
            this.DONGIA.MinWidth = 60;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 2;
            this.DONGIA.Width = 60;
            // 
            // lbPhongHientai
            // 
            this.lbPhongHientai.AutoSize = true;
            this.lbPhongHientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhongHientai.ForeColor = System.Drawing.Color.Red;
            this.lbPhongHientai.Location = new System.Drawing.Point(195, 82);
            this.lbPhongHientai.Name = "lbPhongHientai";
            this.lbPhongHientai.Size = new System.Drawing.Size(82, 16);
            this.lbPhongHientai.TabIndex = 2;
            this.lbPhongHientai.Text = "Phòng XXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng chuyển đến: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(92, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng hiện tại: ";
            // 
            // frmChuyenPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 243);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChuyenPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển phòng";
            this.Load += new System.EventHandler(this.frmChuyenPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seachLookDanhSachphong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit seachLookDanhSachphong;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label lbPhongHientai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChuyenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
    }
}