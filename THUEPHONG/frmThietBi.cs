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
    public partial class frmThietBi : DevExpress.XtraEditors.XtraForm
    {
        THIETBI _thietbi;
        bool _them;
        int _IDTB = 0;

        public frmThietBi()
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
                if (_IDTB == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _thietbi.delete(_IDTB);
                }
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Xac nhan Luu cac du lieu vua them
            if (_them)
            {
                tb_thietbi sanpham = new tb_thietbi();
                sanpham.TENTB = tfTen.Text;
                sanpham.DONGIA = Convert.ToDouble(numericUpDown1.Value);

                _thietbi.add(sanpham);
            }
            //Xac nhan Luu khi sua
            else
            {
                if (_IDTB == 0)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tb_thietbi sanpham = _thietbi.getItem(_IDTB);
                    sanpham.TENTB = tfTen.Text;
                    sanpham.DONGIA = Convert.ToDouble(numericUpDown1.Value);


                    _thietbi.update(sanpham);
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
            this.Close();
        }
        void loadData()
        {
            gcDanhSach.DataSource = _thietbi.getAll();
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

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            _thietbi = new THIETBI();
            loadData();
            showHideControls(true);
            showTextBox(false);
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _IDTB = Convert.ToInt16(gvDanhSach.GetFocusedRowCellValue("IDTB").ToString());
            //MessageBox.Show(Convert.ToString(_IDsanpham));
            tfTen.Text = gvDanhSach.GetFocusedRowCellValue("TENTB").ToString();
            numericUpDown1.Value = Convert.ToDecimal(gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString());
        }
    }
}