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
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        SANPHAM _sanpham;
        bool _them;
        int _IDSP = 0;
        public frmSanPham()
        {
            InitializeComponent();
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_IDSP == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _sanpham.delete(_IDSP);
                }
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Xac nhan Luu cac du lieu vua them
            if (_them)
            {
                tb_sanpham sanpham = new tb_sanpham();
                sanpham.TENSP = tfTen.Text;
                sanpham.DONGIA = Convert.ToDouble(numericUpDown1.Value);

                _sanpham.add(sanpham);
            }
            //Xac nhan Luu khi sua
            else
            {
                if (_IDSP == 0)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tb_sanpham sanpham = _sanpham.getItem(_IDSP);
                    sanpham.TENSP = tfTen.Text;
                    sanpham.DONGIA = Convert.ToDouble(numericUpDown1.Value);


                    _sanpham.update(sanpham);
                }
            }
            _them = false;
            loadData();
            showHideControls(true);
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
        void loadData()
        {
            gcDanhSach.DataSource = _sanpham.getAll();
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
            numericUpDown1.Enabled = t;
        }
        public void resetField()
        {
            tfTen.Text = "";
            numericUpDown1.Value = 0;
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _IDSP = Convert.ToInt16(gvDanhSach.GetFocusedRowCellValue("IDSP").ToString());
            //MessageBox.Show(Convert.ToString(_IDsanpham));
            tfTen.Text = gvDanhSach.GetFocusedRowCellValue("TENSP").ToString();
            numericUpDown1.Value = Convert.ToDecimal(gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString());
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            _sanpham = new SANPHAM();
            loadData();
            showHideControls(true);
            showTextBox(false);
        }
    }
}