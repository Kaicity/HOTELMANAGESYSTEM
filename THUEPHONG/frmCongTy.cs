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
using DevExpress.Utils.DirectXPaint;

namespace THUEPHONG
{
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        CONGTY _congty;
        bool _them;
        string _macty;
        
        public frmCongTy()
        {
            InitializeComponent();
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            loadData();
            showHideControls(true);
            showTextBox(false);
            tfMaCty.Enabled = false;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _congty.getAll();
            //Option cho datagridview data khi load khong the chinh sua 
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            _them = true;
            showHideControls(false);
            tfMaCty.Enabled = true;
            showTextBox(true);
            resetField();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showHideControls(false);
            _them = false;
            showTextBox(true);
            tfMaCty.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(_macty) || string.IsNullOrWhiteSpace(_macty))
                {
                    MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _congty.delete(_macty);
                }
           }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Xac nhan Luu cac du lieu vua them
            if (_them)
            {
                if (string.IsNullOrEmpty(tfMaCty.Text) || string.IsNullOrWhiteSpace(tfMaCty.Text))
                {
                    tfMaCty.Focus();
                    tfMaCty.SelectAll();
                    MessageBox.Show("Mã định danh Công ty không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tb_congty cty = new tb_congty();
                    cty.MACTY = tfMaCty.Text;
                    cty.TENCTY = tfTen.Text;
                    cty.DIENTHOAI = tfDienthoai.Text;
                    cty.FAX = tfFax.Text;
                    cty.EMAIL = tfEmail.Text;
                    cty.DIACHI = tfDiachi.Text;
                    cty.DISABLED = checkBoxDis.Checked;

                    _congty.add(cty);
                }
            }
            //Xac nhan Luu khi sua
            else
            {
               if(tfMaCty.Text.Equals("") || string.IsNullOrWhiteSpace(tfMaCty.Text))
               {
                    MessageBox.Show("Vui lòng chọn dữ liệu trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
               else
               {
                    tb_congty cty = _congty.getItem(_macty);
                    cty.MACTY = tfMaCty.Text;
                    cty.TENCTY = tfTen.Text;
                    cty.DIENTHOAI = tfDienthoai.Text;
                    cty.FAX = tfFax.Text;
                    cty.EMAIL = tfEmail.Text;
                    cty.DIACHI = tfDiachi.Text;
                    cty.DISABLED = checkBoxDis.Checked;

                    //Them data vao du lieu cong ty
                    _congty.update(cty);
                }
            }
            _them = false;
            loadData();
            showHideControls(true);
            showTextBox(false);
            resetField();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            showHideControls(true);
            resetField();
            showTextBox(false);
            tfMaCty.Enabled = false;
        }
        //Ham thuc hien show cac chuc nang nao can thiet khi su dung
        void showHideControls(bool t)
        {
            btnThem.Visible= t;
            btnSua.Visible= t;
            btnXoa.Visible= t;
            btnIn.Visible = t;
            btnLuu.Visible= !t;
            btnBoqua.Visible= !t;

        }
        //Ham Show textBox khi thuc hien chuc nang nao ?
        void showTextBox(bool t)
        {
            tfTen.Enabled = t;
            tfDienthoai.Enabled = t;
            tfDiachi.Enabled = t;
            tfFax.Enabled = t;
            tfEmail.Enabled = t;
            checkBoxDis.Enabled = t;
        }
        public void resetField()
        {
            _macty = "";
            tfMaCty.Text = "";
            tfTen.Text = "";
            tfDienthoai.Text = "";
            tfFax.Text = "";
            tfEmail.Text = "";
            tfDiachi.Text = "";
            checkBoxDis.Checked = false;
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            showTextBox(false);
            _macty = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
            tfMaCty.Text = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
            tfTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
            tfDienthoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
            tfFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
            tfEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
            tfDiachi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
            checkBoxDis.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
        }

        private void tfDienthoai_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
        }

        private void tfFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReportCongTy rpCongTy = new frmReportCongTy();
            rpCongTy.ShowDialog();


        }

        /* private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
         {
             if(e.Column.Name == "DISABLED" && bool.Parse(e.CellValue.ToString()) == true)
             {
                 Image img = Properties.Resources.icons8_clear_symbol_48;
                 e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                 e.Handled = true;
             }
         }*/
    }
}