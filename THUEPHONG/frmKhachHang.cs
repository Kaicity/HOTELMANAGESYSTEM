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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KHACHHANG _khachhang;
        bool _them;
        int _IDKH = 0;
        frmDatPhong objectDP = (frmDatPhong) Application.OpenForms["frmDatPhong"];
        frmDatPhongDon objectDPD = (frmDatPhongDon)Application.OpenForms["frmDatPhongDon"];
        public string _valueDatPhongDonKH;

        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void tfCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
        }

        private void tfDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
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
                if (_IDKH == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _khachhang.delete(_IDKH);
                }
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Xac nhan Luu cac du lieu vua them
            if (_them)
            {
                tb_khachhang kh = new tb_khachhang();
                kh.HOTEN = tfTen.Text;
                kh.CCCD = tfCCCD.Text;
                kh.DIENTHOAI = tfDienthoai.Text;
                kh.EMAIL = tfEmail.Text;
                kh.DIACHI = tfDiachi.Text;

                _khachhang.add(kh);
            }
            //Xac nhan Luu khi sua
            else
            {
                if(_IDKH == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tb_khachhang kh = _khachhang.getItem(_IDKH);
                    kh.HOTEN = tfTen.Text;
                    kh.CCCD = tfCCCD.Text;
                    kh.DIENTHOAI = tfDienthoai.Text;
                    kh.EMAIL = tfEmail.Text;
                    kh.DIACHI = tfDiachi.Text;

                    //Them data vao du lieu cong ty
                    _khachhang.update(kh);
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
            closeAndLoadPage();
        }
        public bool closeAndLoadPage()
        {
            this.Close();
            return true;
        }
        //Ham thuc hien show cac chuc nang nao can thiet khi su dung
        void showHideControls(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible = !t;

        }
        //Ham Show textBox khi thuc hien chuc nang nao ?
        void showTextBox(bool t)
        {
            tfTen.Enabled = t;
            tfDienthoai.Enabled = t;
            tfDiachi.Enabled = t;
            tfCCCD.Enabled = t;
            tfEmail.Enabled = t;
        }
        public void resetField()
        {
            _IDKH = 0;
            tfTen.Text = "";
            tfDienthoai.Text = "";
            tfCCCD.Text = "";
            tfEmail.Text = "";
            tfDiachi.Text = "";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _khachhang.getAll();
            //Option cho datagridview data khi load khong the chinh sua 
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            _khachhang = new KHACHHANG();
            showHideControls(true);
            showTextBox(false);
            loadData();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            showTextBox(false);
            _IDKH = Convert.ToInt16(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString());
            tfTen.Text = gvDanhSach.GetFocusedRowCellValue("HOTEN").ToString();
            tfDienthoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
            tfCCCD.Text = gvDanhSach.GetFocusedRowCellValue("CCCD").ToString();
            tfEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
            tfDiachi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
        }

        private void gcDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if(gvDanhSach.GetFocusedRowCellValue("IDKH") != null)
            {
               if(_valueDatPhongDonKH == "datphongdon")
               {
                    if(objectDPD != null)
                    {
                        objectDPD.loadDataCb_KhachHang();
                        objectDPD.setKhachHang(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString()));
                        this.Close();
                    }
               }
               else
               {

                    if(objectDP != null)
                    {
                        objectDP.loadDataCb_KhachHang();
                        objectDP.setKhachHang(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString()));
                        this.Close();
                        //MessageBox.Show(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString());  //DEBUG
                    }
                }
            }
        }
    }
}