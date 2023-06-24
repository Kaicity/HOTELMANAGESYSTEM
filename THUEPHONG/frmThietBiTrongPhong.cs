using BussinessLogic;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONG
{
    public partial class frmThietBiTrongPhong : DevExpress.XtraEditors.XtraForm
    {
        PHONG _phong;
        THIETBI _thietbi;
        PHONGTHIETBI _phongThietBi;
        bool _them;
        int _IDPhong = 0;
        int _IDTB = 0;

        public frmThietBiTrongPhong()
        {
            InitializeComponent();
        }

        private void frmThietBiTrongPhong_Load(object sender, EventArgs e)
        {
            _phong = new PHONG();
            _thietbi = new THIETBI();
            _phongThietBi = new PHONGTHIETBI();
            showHideControls(true);
            showTextBox(false);
            loadDataComboBox();
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControls(false);
            showTextBox(true);
            resetField();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showHideControls(false);
            _them = false;
            showTextBox(true);

            //Khi sua khong dc phep update 2 khoa cua table nay vi pham rang buoc
            cbPhong.Enabled = false;
            cbThietBi.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_IDTB == 0 && _IDPhong == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _phongThietBi.delete(_IDPhong, _IDTB);
                }
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Xac nhan Luu cac du lieu vua them
            if (_them)
            {
               
                if (string.IsNullOrEmpty(cbPhong.Text) || string.IsNullOrWhiteSpace(cbPhong.Text) ||
                   string.IsNullOrEmpty(cbThietBi.Text) || string.IsNullOrWhiteSpace(cbThietBi.Text))
                {
                    cbPhong.Focus();
                    cbPhong.SelectAll();

                    MessageBox.Show("Thông tin phòng, thiết bị không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (_IDPhong == 0 && _IDTB == 0)
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        tb_phong_thietbi phongThietBi = new tb_phong_thietbi();
                        phongThietBi.IDPHONG = Convert.ToInt16(cbPhong.SelectedValue);
                        phongThietBi.IDTB = Convert.ToInt16(cbThietBi.SelectedValue);
                        phongThietBi.SOLUONG = Convert.ToInt16(numSL.Value);

                        _phongThietBi.add(phongThietBi);
                    }
                }
            }
            //Xac nhan Luu khi sua
            else
            {
                int tempPhong, tempTB;
                tb_phong_thietbi phongThietBi = _phongThietBi.getItem(_IDPhong, _IDTB);

                //Chi ap nhat so luong
                phongThietBi.SOLUONG = Convert.ToInt16(numSL.Value);

                _phongThietBi.update(phongThietBi);
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
            this.Close();
        }
        void loadDataComboBox()
        {
            cbPhong.DataSource = _phong.getAll();
            cbPhong.DisplayMember = "TENPHONG";
            cbPhong.ValueMember = "IDPHONG";

            cbThietBi.DataSource = _thietbi.getAll();
            cbThietBi.DisplayMember = "TENTB";
            cbThietBi.ValueMember = "IDTB";
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _IDPhong = Convert.ToInt16(gvDanhSach.GetFocusedRowCellValue("IDPHONG").ToString());
            _IDTB = Convert.ToInt16(gvDanhSach.GetFocusedRowCellValue("IDTB").ToString());
            //MessageBox.Show(Convert.ToString(_IDsanpham));
            cbPhong.Text = gvDanhSach.GetFocusedRowCellValue("IDPHONG").ToString();
            cbThietBi.Text = gvDanhSach.GetFocusedRowCellValue("IDTB").ToString();
            numSL.Value = Convert.ToDecimal(gvDanhSach.GetFocusedRowCellValue("SOLUONG").ToString());
        }
        void loadData()
        {
            gcDanhSach.DataSource = _phongThietBi.getAll();
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
            cbPhong.Enabled = t;
            cbThietBi.Enabled = t;
            numSL.Enabled= t;
        }
        public void resetField()
        {
            cbPhong.Text = "";
            cbThietBi.Text = "";
            numSL.Value = 0;
        }
    }
}