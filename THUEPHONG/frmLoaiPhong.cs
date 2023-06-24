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
using DataLayer;
using BussinessLogic;

namespace THUEPHONG
{
    public partial class frmLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        LOAIPHONG _loaiphong;
        bool _them;
        int _IDLoaiPhong = 0;

        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            _loaiphong= new LOAIPHONG();
            loadData();
            showHideControls(true);
            showTextBox(false);

        }

        void loadData()
        {
            gcDanhSach.DataSource = _loaiphong.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
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
                if (_IDLoaiPhong == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _loaiphong.delete(_IDLoaiPhong);
                }
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Xac nhan Luu cac du lieu vua them
            if (_them)
            {
                tb_loaiphong loaiphong = new tb_loaiphong();
                loaiphong.TENLOAIPHONG = tfTen.Text;
                loaiphong.DONGIA = Convert.ToDouble(numDongia.Value);
                loaiphong.SONGUOI = Convert.ToInt16(numSoNguoi.Value);
                loaiphong.SOGIUONG = Convert.ToInt16(numSoGiuong.Value);
                loaiphong.DISABLED = checkDis.Checked;

                _loaiphong.add(loaiphong);
            }
            //Xac nhan Luu khi sua
            else
            {
                if (_IDLoaiPhong == 0)
                {

                    MessageBox.Show("Vui lòng chọn dữ liệu trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    tb_loaiphong loaiphong = _loaiphong.getItem(_IDLoaiPhong);

                    loaiphong.TENLOAIPHONG = tfTen.Text;
                    loaiphong.DONGIA = Convert.ToDouble(numDongia.Value);
                    loaiphong.SONGUOI = Convert.ToInt16(numSoNguoi.Value);
                    loaiphong.SOGIUONG = Convert.ToInt16(numSoGiuong.Value);
                    loaiphong.DISABLED = checkDis.Checked;

                    _loaiphong.update(loaiphong);
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
            numDongia.Enabled = t;
            numSoGiuong.Enabled = t;
            numSoNguoi.Enabled = t;
            checkDis.Enabled = t;
        }
        public void resetField()
        {
            tfTen.Text = "";
            numDongia.Value = 0;
            numSoGiuong.Value = 0;
            numSoNguoi.Value = 0;
            checkDis.Checked = false;
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            showTextBox(false);
            _IDLoaiPhong = Convert.ToInt16(gvDanhSach.GetFocusedRowCellValue("IDLOAIPHONG").ToString());
            //MessageBox.Show(Convert.ToString(_IDLoaiPhong));
            tfTen.Text = gvDanhSach.GetFocusedRowCellValue("TENLOAIPHONG").ToString();
            numDongia.Value = Convert.ToDecimal(gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString());
            numSoNguoi.Value = Convert.ToInt16(gvDanhSach.GetFocusedRowCellValue("SONGUOI").ToString());
            numSoGiuong.Value = Convert.ToInt16(gvDanhSach.GetFocusedRowCellValue("SOGIUONG").ToString());
        }
    }
}