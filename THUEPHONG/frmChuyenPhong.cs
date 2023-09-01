using BussinessLogic;
using DataLayer;
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
    public partial class frmChuyenPhong : Form
    {
        public int _idPhong;

        PHONG _phong;
        LOAIPHONG _loaiphong;
        DATPHONGCT _datphongchitiet;
        DATPHONG _datphong;
        DATPHONGSP _datphongsp;
        FrmMainFull _objMain = (FrmMainFull)Application.OpenForms["FrmMainFull"];

        public frmChuyenPhong()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {               
            _phong = new PHONG();
            _loaiphong = new LOAIPHONG();
            _datphongchitiet = new DATPHONGCT();
            _datphong = new DATPHONG();
            _datphongsp = new DATPHONGSP();

            //Load thong tin dat phong hien tai dang duoc su dung
            var itemPhong = _phong.getItem(_idPhong);
            if(itemPhong != null)
            {
                var itemLoaiPhong = _loaiphong.getItem(itemPhong.IDLOAIPHONG);
                var currentMoney = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string formatMoney = string.Format(currentMoney, "{0:c}", itemLoaiPhong.DONGIA);
                lbPhongHientai.Text = itemPhong.TENPHONG + " - Đơn giá: " + formatMoney;
            }
            //Load Thong tin seachLook danh sach cac phong khac
            loadDanhSachCacphong();
        }

        private void loadDanhSachCacphong()
        {
            seachLookDanhSachphong.Properties.DataSource = myFunction.layThongTinPhongtrong();
            seachLookDanhSachphong.Properties.ValueMember = "IDPHONG";
            seachLookDanhSachphong.Properties.DisplayMember = "TENPHONG";
        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            //Kiem tra phong chuyen den duoc chon hay chua
            if (seachLookDanhSachphong.EditValue == null || seachLookDanhSachphong.EditValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn phòng muốn chuyển đến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var itemPhongHienTai = _datphongchitiet.getItemByPhong(_idPhong);
            var itemPhongChuyenDen = _phong.getItem(int.Parse(seachLookDanhSachphong.EditValue.ToString()));
            var itemLoaiPhongChuyenDen = _loaiphong.getItem(itemPhongChuyenDen.IDLOAIPHONG);

            //Tao mot list danh sach chua cac item san pham da duoc su dung truoc do tai phong
            List<tb_datphong_sanpham> listDpsp = _datphongsp.getDataPhongSanPham(itemPhongHienTai.IDDP, itemPhongHienTai.IDDPCT);
            //Duyet tat ca san pham va cap nhat table san pham dich vu tai phong do
            foreach(var item in listDpsp)
            {
                item.IDPHONG = itemPhongChuyenDen.IDPHONG;
                _datphongsp.update(item);
            }
            //Cap nhat tren table datphong chi tiet
            var dpct = _datphongchitiet.getItem(itemPhongHienTai.IDDP, _idPhong);
            dpct.IDPHONG = itemPhongChuyenDen.IDPHONG;
            dpct.DONGIA = itemLoaiPhongChuyenDen.DONGIA;
            dpct.THANHTIEN = dpct.SONGAYO * itemLoaiPhongChuyenDen.DONGIA;

            _datphongchitiet.update(dpct);

            //Cap nhat trang thai phong
            _phong.updateStatus(_idPhong, false);
            _phong.updateStatus(itemPhongChuyenDen.IDPHONG, true);

            //Load danh sach phong tai giao dien home
            _objMain.gControl.Gallery.Groups.Clear();
            _objMain.showRoom();

            if (_phong.getItem(_idPhong).TRANGTHAI == false && _phong.getItem(itemPhongChuyenDen.IDPHONG).TRANGTHAI == true)
            {
                MessageBox.Show("Chuyển phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
