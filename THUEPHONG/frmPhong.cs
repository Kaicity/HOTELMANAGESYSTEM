using BussinessLogic;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONG
{
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        PHONG _phong;
        TANG _tang;
        LOAIPHONG _loaiphong;
        bool _them;
        int _IDPhong = 0;
        string imagePath; // File main lay hinh anh

        public frmPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControls(false);
            showTextBox(true);
            resetField();
            checkStatus.Enabled = false;
            checkStatus.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showHideControls(false);
            _them = false;
            showTextBox(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_IDPhong == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _phong.delete(_IDPhong);
                }
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Xac nhan Luu cac du lieu vua them
            if (_them)
            {
                if (string.IsNullOrEmpty(cbTang.Text) || string.IsNullOrWhiteSpace(cbTang.Text) ||
                    string.IsNullOrEmpty(cbLoaiPhong.Text) || string.IsNullOrWhiteSpace(cbLoaiPhong.Text))
                {
                    cbTang.Focus();
                    cbTang.SelectAll();

                    MessageBox.Show("Thông tin Tầng, Loại phòng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tb_phong phong = new tb_phong();
                    phong.TENPHONG = tfTen.Text;
                    phong.TRANGTHAI = checkStatus.Checked;
                    phong.IDTANG = Convert.ToInt16(cbTang.SelectedValue);
                    phong.IDLOAIPHONG = Convert.ToInt16(cbLoaiPhong.SelectedValue);

                    if (imagePath != null)
                    {
                        //Chuyen doi hinh anh file thanh mang byte[]
                        byte[] imageData = File.ReadAllBytes(imagePath);
                        phong.IMAGE = imageData;
                    }
                 
                    _phong.add(phong);
                }
            }
            //Xac nhan Luu khi sua
            else
            {
                if (_IDPhong == 0)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tb_phong phong = _phong.getItem(_IDPhong);
                    phong.TENPHONG = tfTen.Text;
                    phong.TRANGTHAI = checkStatus.Checked;

                    int tempIDTang;
                    int tempIDLOAIPHONG;

                    if (int.TryParse(cbTang.Text, out tempIDTang) || int.TryParse(cbLoaiPhong.Text, out tempIDLOAIPHONG))
                    {
                        /*phong.IDTANG = Convert.ToInt16(cbTang.Text);
                        phong.IDLOAIPHONG = Convert.ToInt16(cbLoaiPhong.Text);*/
                        //MessageBox.Show("Không thay đổi tầng và loại phòng ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if(!int.TryParse(cbTang.Text, out tempIDTang))
                        {
                            phong.IDTANG = Convert.ToInt16(cbTang.SelectedValue);
                            phong.IDLOAIPHONG = Convert.ToInt16(cbLoaiPhong.Text);
                        }

                        if(!int.TryParse(cbLoaiPhong.Text, out tempIDLOAIPHONG))
                        {
                            phong.IDTANG = Convert.ToInt16(cbTang.Text);
                            phong.IDLOAIPHONG = Convert.ToInt16(cbLoaiPhong.SelectedValue);
                        }
                    }
                    else if (string.IsNullOrEmpty(cbTang.Text) || string.IsNullOrWhiteSpace(cbTang.Text) ||
                        string.IsNullOrEmpty(cbLoaiPhong.Text) || string.IsNullOrWhiteSpace(cbLoaiPhong.Text))
                    {
                        cbTang.Focus();
                        cbTang.SelectAll();

                        MessageBox.Show("Thông tin Tầng, Loại phòng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        phong.IDTANG = Convert.ToInt16(cbTang.SelectedValue);
                        phong.IDLOAIPHONG = Convert.ToInt16(cbLoaiPhong.SelectedValue);
                    }

                    //Co hinh anh thi xu ly byte hinh anh byte
                    if (imagePath != null)
                    {
                        byte[] imageData = File.ReadAllBytes(imagePath);
                        phong.IMAGE = imageData;
                    }

                    _phong.update(phong);
                }

            }

            _them = false;
            loadData();
            showHideControls(true);
            showTextBox(false);
            resetField();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            showHideControls(true);
            resetField();
            showTextBox(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            showLoadPageMain();
        }
        public bool showLoadPageMain()
        {
            this.Close();
            return true;
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            _phong = new PHONG();
            _tang = new TANG();
            _loaiphong = new LOAIPHONG();
            showHideControls(true);
            showTextBox(false);
            loadCbBoxData();
            loadData();
        }
        void loadCbBoxData()
        {
           
            cbTang.DataSource = _tang.getAll();
            cbTang.DisplayMember = "TENTANG";
            cbTang.ValueMember = "IDTANG";

            cbLoaiPhong.DataSource = _loaiphong.getAll();
            cbLoaiPhong.DisplayMember = "TENLOAIPHONG";
            cbLoaiPhong.ValueMember = "IDLOAIPHONG";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _phong.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void showHideControls(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible = !t;

        }
        void showTextBox(bool t)
        {
            tfTen.Enabled = t;
            checkStatus.Enabled = t;
            cbLoaiPhong.Enabled = t;
            cbTang.Enabled = t;
            picBox.Enabled = t;
        }
        public void resetField()
        {
            tfTen.Text = "";
            checkStatus.Checked = false;
            cbLoaiPhong.Text = string.Empty;
            cbTang.Text = string.Empty;
            picBox.Image  = Properties.Resources._68747470733a2f2f662e636c6f75642e6769746875622e636f6d2f6173736574732f323037383234352f3235393331332f35653833313336322d386362612d313165322d383435332d6536626439353663383961342e706e67;
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _IDPhong = Convert.ToInt16(gvDanhSach.GetFocusedRowCellValue("IDPHONG").ToString());
            tfTen.Text = gvDanhSach.GetFocusedRowCellValue("TENPHONG").ToString();
            checkStatus.Checked = Convert.ToBoolean(gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString());
            var itemLoaiPhong = _loaiphong.getItem(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDLOAIPHONG").ToString()));
            var itemtang = _tang.getItem(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTANG").ToString()));
            cbLoaiPhong.Text = itemLoaiPhong.TENLOAIPHONG;
            cbTang.Text = itemtang.TENTANG;

            
            if(gvDanhSach.GetFocusedRowCellValue("IMAGE") != null)
            {
                byte[] dataImage = (byte[])gvDanhSach.GetFocusedRowCellValue("IMAGE");
                //Chuyen doi byte thanh hinh anh 
                ImageConverter imgCvt = new ImageConverter();
                Image img = (Image)imgCvt.ConvertFrom(dataImage);

                picBox.Image = img;
            }
            else
            {
                //Default
                picBox.Image = Properties.Resources._68747470733a2f2f662e636c6f75642e6769746875622e636f6d2f6173736574732f323037383234352f3235393331332f35653833313336322d386362612d313165322d383435332d6536626439353663383961342e706e67;
            }

        }

        private void picBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Thiết lập các tùy chọn cho OpenFileDialog
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn đến tệp hình ảnh đã chọn
                    imagePath = openFileDialog.FileName;

                    // Thực hiện các tác vụ tiếp theo với đường dẫn hình ảnh
                    // Ví dụ: Hiển thị hình ảnh lên PictureBox
                    picBox.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void picBox_MouseLeave(object sender, EventArgs e)
        {
            picBox.Cursor = Cursors.Default;
        }

        private void picBox_MouseEnter(object sender, EventArgs e)
        {
            picBox.Cursor = Cursors.Hand;
        }
    }
}