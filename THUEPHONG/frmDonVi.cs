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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Layout;

namespace THUEPHONG
{
    public partial class frmDonVi : DevExpress.XtraEditors.XtraForm
    {
        DONVI _donvi;
        CONGTY _congty;
        bool _them;
        string _madonvi;

        public frmDonVi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDonVi_Load(object sender, EventArgs e)
        {
            _donvi = new DONVI();
            _congty = new CONGTY();
            loadData();
            loadList_IDCty();
            showHideControls(true);
            tfMadvi.Enabled = false;
            showTextBox(false);
            
        }
        
        void loadData()
        {
            gcDanhSach.DataSource = _donvi.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadList_IDCty()
        {
           /* List<string> listID = _congty.getIDCty();
            cbMacty.DataSource = listID;
            cbMacty.Text = "";*/

            cbMacty.DataSource = _congty.getAll();
            cbMacty.DisplayMember = "TENCTY";
            cbMacty.ValueMember = "MACTY";
        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControls(false);
            tfMadvi.Enabled = true;
            showTextBox(true);
            resetField();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showHideControls(false);
            _them = false;
            showTextBox(true);
            tfMadvi.Enabled = false;
            cbMacty.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(_madonvi) || string.IsNullOrWhiteSpace(_madonvi))
                {
                    MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _donvi.delete(_madonvi);
                }
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Xac nhan Luu cac du lieu vua them
            if (_them)
            {
                if (string.IsNullOrEmpty(tfMadvi.Text) || string.IsNullOrWhiteSpace(tfMadvi.Text) ||
                    string.IsNullOrEmpty(cbMacty.Text) || string.IsNullOrWhiteSpace(cbMacty .Text))
                {
                    tfMadvi.Focus();
                    tfMadvi.SelectAll();
                    MessageBox.Show("Mã định danh đơn vị, công ty không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tb_donvi donvi = new tb_donvi();
                    donvi.MADVI = tfMadvi.Text;
                    donvi.TENDVI = tfTen.Text;
                    donvi.DIENTHOAI = tfDienthoai.Text;
                    donvi.FAX = tfFax.Text;
                    donvi.EMAIL = tfEmail.Text;
                    donvi.DIACHI = tfDiachi.Text;
                    donvi.MACTY = cbMacty.SelectedValue.ToString();

                    _donvi.add(donvi);
                }
            }
            //Xac nhan Luu khi sua
            else
            {
                if (string.IsNullOrEmpty(tfMadvi.Text) || string.IsNullOrWhiteSpace(tfMadvi.Text))
                {
                   
                    MessageBox.Show("Vui lòng chọn dữ liệu trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tb_donvi donvi = _donvi.getItem(_madonvi);
                    donvi.MADVI = tfMadvi.Text;
                    donvi.TENDVI = tfTen.Text;
                    donvi.DIENTHOAI = tfDienthoai.Text;
                    donvi.FAX = tfFax.Text;
                    donvi.EMAIL = tfEmail.Text;
                    donvi.DIACHI = tfDiachi.Text;
                    donvi.MACTY = cbMacty.SelectedValue.ToString();

                    //Them data vao du lieu cong ty
                    _donvi.update(donvi);
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
            tfMadvi.Enabled = false;
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
            tfDienthoai.Enabled = t;
            tfDiachi.Enabled = t;
            tfFax.Enabled = t;
            tfEmail.Enabled = t;
            cbMacty.Enabled = t;
        }
        public void resetField()
        {
            _madonvi = "";
            tfMadvi.Text = "";
            tfTen.Text = "";
            tfDienthoai.Text = "";
            tfFax.Text = "";
            tfEmail.Text = "";
            tfDiachi.Text = "";
            cbMacty.Text = "";
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            showTextBox(false);
            _madonvi = gvDanhSach.GetFocusedRowCellValue("MADVI").ToString();
            tfMadvi.Text = gvDanhSach.GetFocusedRowCellValue("MADVI").ToString();
            tfTen.Text = gvDanhSach.GetFocusedRowCellValue("TENDVI").ToString();
            tfDienthoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
            tfFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
            tfEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
            tfDiachi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
            cbMacty.Text = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
        }
        private void tfDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
        }

        private void tfFax_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
        }
    }
}