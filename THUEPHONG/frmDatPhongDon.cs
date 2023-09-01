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
using THUEPHONG.FormReport;

namespace THUEPHONG
{
    public partial class frmDatPhongDon : Form
    {
        public bool _them;
        DATPHONG _datphong;
        DATPHONGCT _datphongct;
        DATPHONGSP _datphongsp;
        KHACHHANG _khachhang;
        SANPHAM _sanpham;
        SYS_PARAM _sys_param;
        PHONG _phong;
        LOAIPHONG _loaiphong;

        //Ma Cong Ty va MaDonVi Default khong can phai nhap du lieu
        public string _maCty;
        public string _maDvi;

        //Xu ly keo tha value
        public int _idPhong;
        string _tenphong;

        //ID Value get
        public int _idDatPhong = 0;
        int _idDatPhongCT; //test

        //Value number money
        double totalPhongAndSanPham;
        int _songayo;
        double _dongGiaPhong;

        //Value Update Index moi ngay
        int _update_by = 1;

        //Khai bao mot List<> su dung cho Gridview San Pham vi khi Click chon khong cung cau truc 
        List<OBJ_DPSP> listDPSP;
        List<OBJ_DPSP> addContinue;

        //Reload formMain khi thay doi Du Lieu 
        FrmMainFull objMain = (FrmMainFull)Application.OpenForms["frmMainFull"];

        //Check phong co theo doan
        public bool _statusTheoDoan = false;

        //Value loading
        bool isLoading = false;


        public frmDatPhongDon()
        {
            InitializeComponent();
        }


        private void frmDatPhongDon_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;

            _datphong = new DATPHONG();
            _khachhang = new KHACHHANG();
            _sanpham = new SANPHAM();
            listDPSP = new List<OBJ_DPSP>();
            _sys_param = new SYS_PARAM();
            _datphongct = new DATPHONGCT();
            _phong = new PHONG();
            _datphongsp = new DATPHONGSP();
            _loaiphong = new LOAIPHONG();

            stopLoadingAnimation();

            var _pr = _sys_param.GetParam();
            _maCty = _pr.MACTY;
            _maDvi = _pr.MADVI;

            dateNgayDat.Value = DateTime.Now;
            dateNgayTra.Value = DateTime.Now.AddDays(1);

            showHideControls(true);
            showTextBox(true);
            dateNgayTra.Enabled = false;

            //load thong tin chon phong
            loadSanPham();
            loadDataCb_KhachHang();
            cbTrangThai.DataSource = TRANGTHAI.getList();
            cbTrangThai.ValueMember = "_value";
            cbTrangThai.DisplayMember = "_display";
       
            var phongCheck = _phong.getItem(_idPhong);
            if (phongCheck.TRANGTHAI == false)
            {
                //Load Thong tin dat phong trong
                loadThongTinDatPhong();
            }
            else
            {
                //Load Thong Tin dat phong dang su dung dich vu
                loadThongTinDatPhongDon();
            }
            calcu();

        }

        void loadThongTinDatPhong()
        {
            int _indexDataRow = 0;
            var dtLoaiPhong = myFunction.layDuLieu("SELECT lp.IDLOAIPHONG, lp.TENLOAIPHONG, lp.DONGIA, p.IDPHONG, p.TENPHONG FROM tb_loaiphong lp, tb_phong p WHERE lp.IDLOAIPHONG = p.IDLOAIPHONG AND p.IDPHONG ='" + _idPhong + "'");
            var dtRow = dtLoaiPhong.Rows[_indexDataRow];

            object valueDonGia = dtRow["DONGIA"];
            object valueTenPhong = dtRow["TENPHONG"];

            _dongGiaPhong = double.Parse(valueDonGia.ToString());

            //Chuyen doi tien te VND
            var numberMoneyVN = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            //Chuyen doi tien te VND SPDV
            string formatValueDonGia = String.Format(numberMoneyVN, "{0:c}", valueDonGia);

            //Dislay thong tin phong co ban
            this.tfHienThiTenPhong.Text = valueTenPhong.ToString() + " - " + "Đơn giá: " + formatValueDonGia;
        }

        void loadSanPham()
        {
            gvSanPhamDV.DataSource = _sanpham.getAll();
            gvSanPhamDV.Columns["tb_datphong_sanpham"].Visible = false;
        }

        public void loadDataCb_KhachHang()
        {
            _khachhang = new KHACHHANG();
            /*  cbKhachHang.DataSource = _khachhang.getAll();
              cbKhachHang.ValueMember = "IDKH";
              cbKhachHang.DisplayMember = "HOTEN";*/

            //Dung control seach tiem kiem ho ten khach hang de dang hon
            searchCbKhachang.Properties.DataSource = _khachhang.getAll();
            searchCbKhachang.Properties.ValueMember = "IDKH";
            searchCbKhachang.Properties.DisplayMember = "HOTEN";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /*if (_idDatPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //Cap nhat nhung phong khi bi xoa khoi danh sach thi tro ve trang thai false
                    var listDpct = _datphongct.getAllByDatPhong(_idDatPhong);
                    foreach (var item in listDpct)
                    {
                        _phong.updateStatus((int)item.IDPHONG, false);
                    }

                    _datphongsp.deleteAll(_idDatPhong);

                    _datphongct.deleteAll(_idDatPhong);

                    _datphong.delete(_idDatPhong);

                    new frmDatPhong();
                    objMain.gControl.Gallery.Groups.Clear();
                    objMain.showRoom();
                }
            }*/
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                if(searchCbKhachang.EditValue == null || searchCbKhachang.EditValue.ToString() == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                isLoading = true;

                startLoadingAnimation();
                //---------------------------
                //Xac nhan Luu cac du lieu vua them
                saveData();
                //Reload form main
                //objMain.reloadChangeForm();
                objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();
                _them = false;
                showHideControls(true);
                showTextBox(false);
                //Luu du lieu khach dat phong don xong thi se thoat chuong trinh
                //-----------------------------
                await Task.Delay(3000); //Loading du lieu trong 3s

                stopLoadingAnimation();
            }

        }

        void saveData()
        {
            if (_them)
            {
                tb_datphong dp = new tb_datphong(); //Luu theo thu tu dat phong truoc
                tb_datphong_chitiet dpct; // Chua new obj doi dat phong co day du du lieu
                tb_datphong_sanpham dpsp;

                dp.NGAYDAT = dateNgayDat.Value;
                dp.NGAYTRA = dateNgayTra.Value;
                dp.SONGUOIO = Convert.ToInt32(numSLNguoi.Value);
                dp.STATUS = bool.Parse(cbTrangThai.SelectedValue.ToString());
                dp.THEODOAN = false;
                dp.IDKH = Convert.ToInt32(searchCbKhachang.EditValue.ToString());
                dp.SOTIEN = totalPhongAndSanPham;
                dp.GHICHU = tfGhiChu.Text;
                dp.IDUSER = 1;
                dp.DISABLED = false;
                dp.MACTY = _maCty;
                dp.MADVI = _maDvi;
                dp.CREATED_DATE = DateTime.Now;
                //Sau khi them du lieu tra ve ID dat phong
                var _dpObj = _datphong.add(dp);
                _idDatPhong = _dpObj.ID;

                
                //Xu ly dat phong co mot phong duy nhat
                dpct = new tb_datphong_chitiet();
                dpct.IDDP = _dpObj.ID;
                dpct.IDPHONG = _idPhong;
                dpct.SONGAYO = _songayo;
                dpct.DONGIA = _dongGiaPhong;
                dpct.THANHTIEN = (double)dpct.SONGAYO * dpct.DONGIA;
                dpct.NGAY = DateTime.Now;
                var _dpctObject = _datphongct.add(dpct);
                _phong.updateStatus(int.Parse(dpct.IDPHONG.ToString()), true);


                if (gvSuDungSPDV.RowCount > 0)
                {
                    //San pham trong moi phong duoc dat o chi tiet dat phong
                    for (int j = 0; j < gvSuDungSPDV.RowCount; j++)
                    {
                        if (dpct.IDPHONG == int.Parse(gvSuDungSPDV.Rows[j].Cells["spIDPHONG"].Value.ToString()))
                        {
                            dpsp = new tb_datphong_sanpham();
                            dpsp.IDDP = _dpObj.ID;
                            dpsp.IDPHONG = int.Parse(gvSuDungSPDV.Rows[j].Cells["spIDPHONG"].Value.ToString());
                            dpsp.IDDPCT = _dpctObject.IDDPCT;
                            dpsp.IDSP = int.Parse(gvSuDungSPDV.Rows[j].Cells["spIDSP"].Value.ToString());
                            dpsp.SOLUONG = int.Parse(gvSuDungSPDV.Rows[j].Cells["spSOLUONG"].Value.ToString());
                            dpsp.DONGIA = double.Parse(gvSuDungSPDV.Rows[j].Cells["spDONGIA"].Value.ToString());
                            dpsp.NGAY = DateTime.Now;
                            dpsp.THANHTIEN = double.Parse(gvSuDungSPDV.Rows[j].Cells["spTHANHTIEN"].Value.ToString());
                            _datphongsp.add(dpsp);
                        }
                    }
                }
            }
            else
            {
                //update
                if (_idDatPhong == 0)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu trước khi sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tb_datphong dp = _datphong.getItem(_idDatPhong); //Luu theo thu tu dat phong truoc
                tb_datphong_chitiet dpct; // Chua new obj doi dat phong co day du du lieu
                tb_datphong_sanpham dpsp;

                dp.NGAYDAT = dateNgayDat.Value;
                dp.NGAYTRA = dateNgayTra.Value;
                dp.SONGUOIO = Convert.ToInt32(numSLNguoi.Value);
                dp.STATUS = bool.Parse(cbTrangThai.SelectedValue.ToString());
                dp.IDKH = Convert.ToInt32(searchCbKhachang.EditValue.ToString());
                dp.SOTIEN = totalPhongAndSanPham;
                dp.GHICHU = tfGhiChu.Text;
                dp.IDUSER = 1;
                dp.UPDATE_DATE = DateTime.Now;
                dp.UPDATE_BY = _update_by;
                //Sau khi update du lieu tra ve ID dat phong
                var _dpObj = _datphong.update(dp);

                //Truoc khi update xoa data cua DPCT va DPSP <*>
                //Xoa tu duoi len tren vi co rang buoc du lieu 
                myFunction.XoaDuLieu("DELETE FROM tb_datphong_sanpham WHERE IDDP = '" + _idDatPhong + "'");

                myFunction.XoaDuLieu("DELETE FROM tb_datphong_chitiet WHERE IDDP = '" + _idDatPhong + "'");

                _idDatPhong = _dpObj.ID;

                //Reset data CT-SP them lai ban dau 

                //-----------------------------------

                dpct = new tb_datphong_chitiet();
                dpct.IDDP = _dpObj.ID;
                dpct.IDPHONG = _idPhong;
                dpct.SONGAYO = _songayo;
                dpct.DONGIA = _dongGiaPhong;
                dpct.THANHTIEN = (double)dpct.SONGAYO * dpct.DONGIA;
                dpct.NGAY = DateTime.Now;
                var _dpctObject = _datphongct.add(dpct);
                _phong.updateStatus(int.Parse(dpct.IDPHONG.ToString()), true);



                //San pham trong moi phong duoc dat o chi tiet dat phong
                for (int j = 0; j < gvSuDungSPDV.RowCount; j++)
                {
                    if (dpct.IDPHONG == int.Parse(gvSuDungSPDV.Rows[j].Cells["spIDPHONG"].Value.ToString()))
                    {
                        dpsp = new tb_datphong_sanpham();
                        dpsp.IDDP = _dpObj.ID;
                        dpsp.IDPHONG = int.Parse(gvSuDungSPDV.Rows[j].Cells["spIDPHONG"].Value.ToString());
                        dpsp.IDDPCT = _dpctObject.IDDPCT;
                        dpsp.IDSP = int.Parse(gvSuDungSPDV.Rows[j].Cells["spIDSP"].Value.ToString());
                        dpsp.SOLUONG = int.Parse(gvSuDungSPDV.Rows[j].Cells["spSOLUONG"].Value.ToString());
                        dpsp.DONGIA = double.Parse(gvSuDungSPDV.Rows[j].Cells["spDONGIA"].Value.ToString());
                        dpsp.NGAY = DateTime.Now;
                        dpsp.THANHTIEN = double.Parse(gvSuDungSPDV.Rows[j].Cells["spTHANHTIEN"].Value.ToString());
                        _datphongsp.add(dpsp);
                    }
                }

                //Cap nhat trang thai phong duy nhat khi khach hang da thanh toan
                if (_dpObj.STATUS == true)
                {
                    _phong.updateStatus(_idPhong, false);
                }
            }
        }

        public void showHideControls(bool t)
        {
           /* btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;*/
            btnIn.Visible = t;
            btnLuu.Visible = t;
            btnBoqua.Visible = t;

        }
        //Ham Show textBox khi thuc hien chuc nang nao ?
        void showTextBox(bool t)
        {
            searchCbKhachang.Enabled = t;
            dateNgayDat.Enabled = t;
            dateNgayTra.Enabled = t;
            cbTrangThai.Enabled = t;
            tfGhiChu.Enabled = t;
            numSLNguoi.Enabled = t;
        }
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            showHideControls(true);
            resetField();
            resetFieldThem();
            loadThongTinDatPhong();
            calcu();
        }

        public void resetField()
        {
            dateNgayDat.Value = DateTime.Now;
            dateNgayTra.Value = DateTime.Now.AddDays(1);
            cbTrangThai.SelectedValue = false;
            tfGhiChu.Text = "";
            numSLNguoi.Value = 1;
        }

        void resetFieldThem()
        {
            //Reset tat ca gia tri khi them moi 
            if(listDPSP.Count != 0 && addContinue.Count != 0)
            {
                listDPSP.Clear();
                addContinue.Clear();
            }
            gvSuDungSPDV.DataSource = _datphongsp.getAllDataTableDatPhongSanPham(0);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //In
            frmReportDatPhongDon frmRP_DPD = new frmReportDatPhongDon();
            frmRP_DPD.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frKh = new frmKhachHang();
            frKh._valueDatPhongDonKH = "datphongdon";
            frKh.ShowDialog();
        }

        private void gvSanPhamDV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string rowNumber = (e.RowIndex + 1).ToString();

            //Create Posit
            Rectangle rowBounds = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, gvSanPhamDV.RowHeadersWidth - 4, e.RowBounds.Height);

            //Edit posit 
            using (StringFormat stringFormat = new StringFormat())
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                //Pain index number
                e.Graphics.DrawString(rowNumber, gvSanPhamDV.Font, SystemBrushes.ControlText, rowBounds, stringFormat);

            }
        }

        private void gvSanPhamDV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gvSanPhamDV.Rows[e.RowIndex].Cells["IDSP"].Value.ToString() != null)
            {
                OBJ_DPSP sp = new OBJ_DPSP();
                sp.IDSP = int.Parse(gvSanPhamDV.Rows[e.RowIndex].Cells["IDSP"].Value.ToString());
                sp.TENSP = gvSanPhamDV.Rows[e.RowIndex].Cells["TENSP"].Value.ToString();
                sp.IDPHONG = _idPhong;
                var objPhong = _phong.getItem(_idPhong);
                sp.TENPHONG = objPhong.TENPHONG;
                sp.SOLUONG = 0;
                sp.DONGIA = float.Parse(gvSanPhamDV.Rows[e.RowIndex].Cells["DONGIA"].Value.ToString());
                sp.THANHTIEN = sp.SOLUONG * sp.DONGIA;

                foreach (var item in listDPSP)
                {
                    if (item.IDSP == sp.IDSP && item.IDPHONG == sp.IDPHONG)
                    {
                        item.SOLUONG += 1;
                        item.THANHTIEN = item.SOLUONG * item.DONGIA;
                        //Load danh sach san pham khi click va neu id ton tai thi update 
                        loadDPSP();
                        calcu();
                        return;
                    }
                }

                listDPSP.Add(sp);
            }
        }
        void loadDPSP()
        {
            //Reload lai
            addContinue = new List<OBJ_DPSP>();
            foreach (var item in listDPSP)
            {
                addContinue.Add(item);
            }
            /* OBJ_DPSP []array = new OBJ_DPSP[listDPSP.Count];
             for(int i = 0; i < listDPSP.Count; i++)
             {
                  array[i] = listDPSP[i];
             }*/
            gvSuDungSPDV.DataSource = addContinue;

        }

        private void gvSuDungSPDV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Bien tam luu gia san pham dich vu
            List<object> temp = new List<object>();

            if (e.RowIndex >= 0 && e.ColumnIndex == gvSuDungSPDV.Columns["spSOLUONG"].Index)
            {
                //lay dong du lieu hien tai 
                int index = e.RowIndex;

                //Gia tri moi cua cot so luong
                int sl = int.Parse(gvSuDungSPDV.Rows[index].Cells["spSOLUONG"].Value.ToString());

                if (sl > 0)
                {
                    double gia = double.Parse(gvSuDungSPDV.Rows[index].Cells["spDONGIA"].Value.ToString());

                    //Update thanh tien
                    double newValue = sl * gia;
                    gvSuDungSPDV.Rows[index].Cells["spTHANHTIEN"].Value = newValue;
                    calcu();

                }
                else if (sl < 0)
                {
                    MessageBox.Show("Giá trị không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gvSuDungSPDV.Rows[index].Cells["spSOLUONG"].Value = 1;

                    calcu();

                }
                else
                {
                    //Lay gia tien truoc khi set gia tien = 0
                    double getGiaTien = double.Parse(gvSuDungSPDV.Rows[index].Cells["spDONGIA"].Value.ToString());
                    temp.Add(int.Parse(gvSuDungSPDV.Rows[index].Cells["spIDSP"].Value.ToString()));
                    temp.Add(getGiaTien);

                    //set value
                    gvSuDungSPDV.Rows[index].Cells["spTHANHTIEN"].Value = 0.0;
                    gvSuDungSPDV.Rows[index].Cells["spDONGIA"].Value = 0.0;
                    calcu();
                }
            }
        }

        private void gvSuDungSPDV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gvSuDungSPDV.Columns["spSOLUONG"].Index)  // Thay YourColumnIndex bằng chỉ số cột cần kiểm tra
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int number))
                {
                    e.Cancel = true;  // Hủy bỏ sự kiện chỉnh sửa nếu giá trị không phải số nguyên
                    MessageBox.Show("Giá trị phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Tinh tong gia tri data
        void calcu()
        {
            int sumSL = 0;
            int sumSLPhong = 1;

            double sumGiaTienSPDV = 0.0;
            double sumDonGiaPhong = _dongGiaPhong;

            int columnIndexSL = gvSuDungSPDV.Columns["spSOLUONG"].Index;
            int columnIndexTT = gvSuDungSPDV.Columns["spTHANHTIEN"].Index;

            if (gvSuDungSPDV.Rows.Count > 0)
            {

                //Tinh tong cot so luong san pham
                foreach (DataGridViewRow row in gvSuDungSPDV.Rows)
                {
                    if (row.Cells[columnIndexSL].Value != null && row.Cells[columnIndexSL].Value.ToString() != "")
                    {
                        if (int.TryParse(row.Cells[columnIndexSL].Value.ToString(), out int value))
                        {
                            sumSL += value;
                        }
                    }
                }
                //Tinh tong cot thanh tien san pham
                foreach (DataGridViewRow row in gvSuDungSPDV.Rows)
                {
                    if (row.Cells[columnIndexTT].Value != null && row.Cells[columnIndexTT].Value.ToString() != "")
                    {
                        if (double.TryParse(row.Cells[columnIndexTT].Value.ToString(), out double value))
                        {
                            sumGiaTienSPDV += value;
                        }
                    }
                }
            }
            //-----------
            //Lay don gia phong duy nhat
          
            tfSl_DPSP.Text = sumSL.ToString();

            //Chuyen doi tien te VND
            var numberMoneyVN = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            //Chuyen doi tien te VND SPDV
            string formatValueSPDV = String.Format(numberMoneyVN, "{0:c}", sumGiaTienSPDV);
            tfGiaTienDPSP.Text = formatValueSPDV;

            //Chuyen doi tien phong VND Phong
            string formatMoneyValuePhong = String.Format(numberMoneyVN, "{0:c}", sumDonGiaPhong * _songayo);
            tfGiaPhong.Text = formatMoneyValuePhong;

          
            tfSlPhong.Text = sumSLPhong.ToString();

            tfSoNgayO.Text = _songayo.ToString();

            //Tinh tong cong so tien phai tra
            totalPhongAndSanPham = sumGiaTienSPDV + (sumDonGiaPhong * _songayo);
            string formatMoneyValue = String.Format(numberMoneyVN, "{0:c}", totalPhongAndSanPham);
            tfTotal.Text = formatMoneyValue;

        }

        private void gvSuDungSPDV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = gvSuDungSPDV.Columns["spSOLUONG"].Index;  // Thay YourColumnIndex bằng chỉ số cột cần tô màu
            if (e.ColumnIndex == columnIndex)
            {
                int value = Convert.ToInt32(e.Value);
                if (value >= 0)
                {
                    e.CellStyle.BackColor = Color.PaleGreen; // Sử dụng màu nền mặc định của DataGridView cho các ô còn lại
                    e.CellStyle.ForeColor = Color.Black;  // Sử dụng màu chữ mặc định của DataGridView cho các ô còn lại
                }
            }
        }
        //Xu ly thong tin khach hang khi chon khach hang trong danh sach
        public void setKhachHang(int idKH)
        {
            KHACHHANG khachHang = new KHACHHANG();
            var kh = khachHang.getItem(idKH);

            searchCbKhachang.EditValue = kh.IDKH;
            searchCbKhachang.Properties.View.GetFocusedRowCellValue("HOTEN");
        }

        private void dateNgayTra_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker getNgayTra = sender as DateTimePicker;
            DateTime ngayTraValue = getNgayTra.Value;

            DateTimePicker getNgayDat = dateNgayDat;
            DateTime ngayDatValue = getNgayDat.Value;

            if (ngayTraValue == DateTime.Today)
            {
                //Ngay dat khong be hon ngay hien tai
                MessageBox.Show("Ngày trả không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                getNgayTra.Value = ngayDatValue.AddDays(1);
            }
            if (ngayTraValue < ngayDatValue)
            {
                //Ngay dat khong be hon ngay hien tai
                MessageBox.Show("Ngày trả không thể trước ngày đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                getNgayTra.Value = ngayDatValue.AddDays(1);

            }

            if(ngayTraValue.Month == ngayDatValue.Month)
            {
                _songayo = ngayTraValue.Day - ngayDatValue.Day;
            }
            else
            {
                TimeSpan soNgayDat = ngayTraValue - ngayDatValue;
                _songayo = soNgayDat.Days;
            }
            calcu();
        }

        private void dateNgayDat_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker getNgayDat = sender as DateTimePicker;
            DateTime ngayDatValue = getNgayDat.Value;

            if(ngayDatValue != null)
            {
                dateNgayTra.Enabled = true;
            }
        }

        private void gvSuDungSPDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvSuDungSPDV.Rows.Count > 0)
            {
                if (int.Parse(gvSuDungSPDV.Rows[e.RowIndex].Cells["spSOLUONG"].Value.ToString()) == 0)
                {
                    int _idDatPhongSP = int.Parse(gvSuDungSPDV.Rows[e.RowIndex].Cells["spIDPHONG"].Value.ToString());
                    int _idsp = int.Parse(gvSuDungSPDV.Rows[e.RowIndex].Cells["spIDSP"].Value.ToString());

                    DialogResult rs = MessageBox.Show("Chọn lại sản phẩm này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        for (int i = 0; i < gvSanPhamDV.Rows.Count; i++)
                        {
                            if (_idsp == int.Parse(gvSanPhamDV.Rows[i].Cells["IDSP"].Value.ToString()))
                            {
                                int soluong = 1;
                                double dongia = double.Parse(gvSanPhamDV.Rows[i].Cells["DONGIA"].Value.ToString());

                                gvSuDungSPDV.Rows[e.RowIndex].Cells["spSOLUONG"].Value = soluong;
                                gvSuDungSPDV.Rows[e.RowIndex].Cells["spDONGIA"].Value = dongia;

                                gvSuDungSPDV.Rows[e.RowIndex].Cells["spTHANHTIEN"].Value = soluong * dongia;
                                calcu();
                            }
                        }
                    }
                    else
                        return;
                }
            }
        }

        void startLoadingAnimation()
        {
            this.picLoading.Visible = true;
        }

        void stopLoadingAnimation()
        {
            this.picLoading.Visible = false;
        }

        public void loadThongTinDatPhongDon()
        {
            bool theoDoan = false; // gia tri xem don dat phong co theo doan
            var dpct = _datphongct.getItemByPhong(_idPhong);
            
            if (!_them && dpct != null) 
            {
                _idDatPhong = dpct.IDDP;
                var dp = _datphong.getItem(_idDatPhong);
                searchCbKhachang.EditValue = dp.IDKH;
                dateNgayDat.Value = dp.NGAYDAT.Value;
                dateNgayTra.Value = dp.NGAYTRA.Value;
                numSLNguoi.Value = dp.SONGUOIO.Value;
                cbTrangThai.SelectedValue = dp.STATUS;
                tfGhiChu.Text = dp.GHICHU.ToString();
                
                //Check theo doan
                theoDoan = dp.THEODOAN.Value;

                _dongGiaPhong = double.Parse(dpct.DONGIA.ToString());
            }
            var itemPhong = _phong.getItem(_idPhong);
            //Hien thi header chi tiet phong dat
            var numberMoneyVN = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string formatValueDonGia = String.Format(numberMoneyVN, "{0:c}", double.Parse(_dongGiaPhong.ToString()));
            this.tfHienThiTenPhong.Text = itemPhong.TENPHONG.ToString() + " - " + "Đơn giá: " + formatValueDonGia;

            loadSPDVDatPhongDon();

            //open form theo doan
            if(theoDoan)
            {
                if(MessageBox.Show("Phòng được đặt theo đoàn. Đến danh mục đặt phòng theo đoàn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                    frmDatPhong frmDp = new frmDatPhong();
                    frmDp.ShowDialog();
                    
                }
                else
                    this.Close();
            }
        }

        void loadSPDVDatPhongDon()
        {
            gvSuDungSPDV.DataSource = _datphongsp.getAllDataTableDatPhongSanPham(_idDatPhong);
            listDPSP = _datphongsp.getAllDataTableDatPhongSanPham(_idDatPhong);
        }
    }
}
