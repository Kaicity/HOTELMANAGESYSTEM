using BussinessLogic;
using DataLayer;
using DevExpress.Utils.Gesture;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Filtering.Templates;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONG
{
    public partial class frmDatPhong : DevExpress.XtraEditors.XtraForm
    {
        bool _them;
        DATPHONG _datphong;
        DATPHONGCT _datphongct;
        DATPHONGSP _datphongsp;
        KHACHHANG _khachhang;
        SANPHAM _sanpham;
        SYS_PARAM _sys_param;
        PHONG _phong;

        //Ma Cong Ty va MaDonVi Default khong can phai nhap du lieu
        string _maCty;
        string _maDvi;

        //Xu ly keo tha value
        int _idPhong;
        string _tenphong;

        //ID Value get
        int _idDatPhong = 0;
        int _idDatPhongCT;

        //Value number money
        double totalPhongAndSanPham;
        int _songayo;

        //Value Update Index moi ngay
        int _update_by = 1;


        //Khai bao mot List<> su dung cho Gridview San Pham vi khi Click chon khong cung cau truc 
        List<OBJ_DPSP> listDPSP;

        //Reload formMain khi thay doi Du Lieu 
        FrmMainFull objMain = (FrmMainFull)Application.OpenForms["frmMainFull"];


        public frmDatPhong()
        {
            InitializeComponent();
            DataTable dt = myFunction.layDuLieu("SELECT p.IDPHONG, p.TENPHONG, lp.DONGIA, t.IDTANG, t.TENTANG, lp.TENLOAIPHONG FROM tb_phong p, tb_tang t, tb_loaiphong lp WHERE p.IDTANG = t.IDTANG AND p.IDLOAIPHONG = lp.IDLOAIPHONG AND p.TRANGTHAI = 0 AND NOT lp.TENLOAIPHONG = 'None'");

            gvPhong.DataSource = dt;
            gvPhongDat.DataSource = dt.Clone();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            _datphong = new DATPHONG();
            _khachhang = new KHACHHANG();
            _sanpham = new SANPHAM();
            listDPSP = new List<OBJ_DPSP>();
            _sys_param = new SYS_PARAM();
            _datphongct = new DATPHONGCT();
            _phong = new PHONG();
            _datphongsp = new DATPHONGSP();

            var _pr = _sys_param.GetParam();
            _maCty = _pr.MACTY;
            _maDvi = _pr.MADVI;

            tabPage.SelectedTab = pageDanhSach;
            dateDiTuNgay.Value = myFunction.getFirstDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dateDiDenNgay.Value = DateTime.Now;

            dateNgayDat.Value = DateTime.Now;
            dateNgayTra.Value = DateTime.Now.AddDays(1);

            showHideControls(true);
            showTextBox(false);

            //load data
            loadSanPham();
            loadDataCb_KhachHang();
            cbTrangThai.DataSource = TRANGTHAI.getList();
            cbTrangThai.ValueMember = "_value";
            cbTrangThai.DisplayMember = "_display";

            //Load Data Dat phong
            loadDataDatPhong();

        }

        void loadDataDatPhong()
        {
            gcDanhSach.DataSource = _datphong.getAllDaTaDP(dateDiTuNgay.Value, dateDiDenNgay.Value, _maCty, _maDvi);
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadSanPham()
        {
            gvSanPhamDV.DataSource = _sanpham.getAll();
            gvSanPhamDV.Columns["tb_datphong_sanpham"].Visible = false;
        }

        public void loadDataCb_KhachHang()
        {
            _khachhang = new KHACHHANG();
            cbKhachHang.DataSource = _khachhang.getAll();
            cbKhachHang.ValueMember = "IDKH";
            cbKhachHang.DisplayMember = "HOTEN";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControls(false);
            showTextBox(true);
            tabPage.SelectedTab = pageChiTiet;
            lockGridDataDP_DPSP(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           if(_idDatPhong == 0)
           {
                MessageBox.Show("Vui lòng chọn thông tin dữ liệu trước khi sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn sửa thông tin này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    showHideControls(false);
                    _them = false;
                    showTextBox(true);
                    tabPage.SelectedTab = pageChiTiet;

                    //UnClock gridview
                    lockGridDataDP_DPSP(true);

                    //Reload cac gia tri khi sua
                    calcu();
                }
                else
                    return;
           }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             if (_idDatPhong == 0)
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
                    foreach(var item in listDpct)
                    {
                        _phong.updateStatus((int)item.IDPHONG, false);
                    }

                    _datphongsp.deleteAll(_idDatPhong);
                    
                    _datphongct.deleteAll(_idDatPhong);

                    _datphong.delete(_idDatPhong);

                    loadDataDatPhong();
                }  
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Xac nhan Luu cac du lieu vua them
            saveData();
            //Reload form main
            objMain.reloadChangeForm();
            _them = false;
            //loadData();
            showHideControls(true);
            showTextBox(false);
            resetField();
            loadDataDatPhong();

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
                dp.THEODOAN = checkTheoDoan.Checked;
                dp.IDKH = Convert.ToInt32(cbKhachHang.SelectedValue.ToString());
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


                for (int i = 0; i < gvPhongDat.RowCount; i++)
                {
                    dpct = new tb_datphong_chitiet();
                    dpct.IDDP = _dpObj.ID;
                    dpct.IDPHONG = int.Parse(gvPhongDat.Rows[i].Cells["dpIDPHONG"].Value.ToString());

                    //Xu ly ngay 
                    if (dateNgayDat.Value.Day < dateNgayTra.Value.Day && dateNgayDat.Value.Month == dateNgayTra.Value.Month)
                    {
                        dpct.SONGAYO = dateNgayTra.Value.Day - dateNgayDat.Value.Day;
                    }
                    else if (dateNgayDat.Value.Day > dateNgayTra.Value.Day || dateNgayDat.Value.Month != dateNgayTra.Value.Month)
                    {
                        if (dateNgayDat.Value.Month == dateNgayTra.Value.Month)
                        {
                            MessageBox.Show("Ngày trả không thể trước ngày đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else if (dateNgayDat.Value.Month > dateNgayTra.Value.Month)
                        {
                            MessageBox.Show("Tháng đặt phòng không thể trước ngày đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            //Ngay dat
                            int nowDays = dateNgayDat.Value.Day;

                            int year = dateNgayDat.Value.Year;
                            int month = dateNgayDat.Value.Month;

                            int maxDay = DateTime.DaysInMonth(year, month);

                            /* MessageBox.Show((nowDays).ToString());
                             MessageBox.Show(maxDay.ToString());*/

                            //NgayTra
                            int daysOfMonth = dateNgayTra.Value.Day;

                            /*MessageBox.Show((maxDay - nowDays).ToString());
                            MessageBox.Show(daysOfMonth.ToString(), "Ngay thang moi");*/

                            dpct.SONGAYO = (maxDay - nowDays + 1) + daysOfMonth;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Lỗi Ngày Tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dpct.DONGIA = double.Parse(gvPhongDat.Rows[i].Cells["dpDONGIA"].Value.ToString());
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
                dp.IDKH = Convert.ToInt32(cbKhachHang.SelectedValue.ToString());
                dp.SOTIEN = totalPhongAndSanPham;
                dp.GHICHU = tfGhiChu.Text;
                dp.IDUSER = 1;
                dp.UPDATE_DATE = DateTime.Now;
                dp.UPDATE_BY = _update_by;
                //Sau khi update du lieu tra ve ID dat phong
                var _dpObj = _datphong.update(dp);

                //Truoc khi update xoa data cua DPCT va DPSP <*>
                //Xoa tu duoi len tren vi co rang buoc du lieu 
                myFunction.XoaDuLieu("DELETE FROM tb_datphong_sanpham WHERE IDDP = '"+ _idDatPhong + "'");   
               
                myFunction.XoaDuLieu("DELETE FROM tb_datphong_chitiet WHERE IDDP = '"+ _idDatPhong + "'");

                _idDatPhong = _dpObj.ID;

                //Reset data CT-SP them lai ban dau 

                //-----------------------------------

                for (int i = 0; i < gvPhongDat.RowCount; i++)
                {
                    dpct = new tb_datphong_chitiet();
                    dpct.IDDP = _dpObj.ID;
                    dpct.IDPHONG = int.Parse(gvPhongDat.Rows[i].Cells["dpIDPHONG"].Value.ToString());
                    dpct.SONGAYO = dateNgayTra.Value.Day - dateNgayDat.Value.Day;
                    dpct.DONGIA = double.Parse(gvPhongDat.Rows[i].Cells["dpDONGIA"].Value.ToString());
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

                //Cap nhat trang thay don dat da thanh toan => phong trong
                var _phongDat = _datphongct.getAllByDatPhong(_idDatPhong);

                if (_dpObj.STATUS == true)
                {
                    foreach (var item in _phongDat)
                    {
                        _phong.updateStatus((int)item.IDPHONG, false);
                    }
                }
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            showHideControls(true);
            resetField();
            showTextBox(false);
            tabPage.SelectedTab = pageDanhSach;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {

        }
        void showHideControls(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnIn.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible = !t;

        }
        //Ham Show textBox khi thuc hien chuc nang nao ?
        void showTextBox(bool t)
        {
            cbKhachHang.Enabled = t;
            dateNgayDat.Enabled = t;
            dateNgayTra.Enabled = t;
            cbTrangThai.Enabled = t;
            tfGhiChu.Enabled = t;
            numSLNguoi.Enabled = t;
            checkTheoDoan.Enabled = t;
        }
        public void resetField()
        {
            dateNgayDat.Value = DateTime.Now;
            dateNgayTra.Value = DateTime.Now.AddDays(1);
            cbTrangThai.SelectedValue = false;
            tfGhiChu.Text = "";
            numSLNguoi.Value = 1;
            checkTheoDoan.Checked = false;
        }

        private void btnAddNewKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frKh = new frmKhachHang();
            frKh.ShowDialog();

            /*if (frKh.closeAndLoadPage())
            {
                loadDataCb_KhachHang();
            }*/
        }


        private void gvPhong_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idPhongDel;
            bool delFound = false;

            _idPhong = int.Parse(gvPhong.Rows[e.RowIndex].Cells["IDPHONG"].Value.ToString());
            _tenphong = gvPhong.Rows[e.RowIndex].Cells["TENPHONG"].Value.ToString();

            if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
            {
                idPhongDel = int.Parse(gvPhong.Rows[e.RowIndex].Cells["IDPHONG"].Value.ToString());

                // Lấy dòng dữ liệu được chọn
                DataGridViewRow selectedRow = gvPhong.Rows[e.RowIndex];

                // Tạo một dòng mới cho nguồn dữ liệu DataGridView B
                DataRow newRow = ((DataTable)gvPhongDat.DataSource).NewRow();

                // Sao chép dữ liệu từ dòng được chọn sang dòng mới
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    newRow[cell.ColumnIndex] = cell.Value;
                }

               // Thêm dòng mới vào nguồn dữ liệu DataGridView B
               ((DataTable)gvPhongDat.DataSource).Rows.Add(newRow);

                gvPhong.Rows.RemoveAt(e.RowIndex);

                //Neu chon lai phong da xoa 
                for (int i = 0; i < gvSuDungSPDV.RowCount;)
                {
                    int value = int.Parse(gvSuDungSPDV.Rows[i].Cells["spIDPHONG"].Value.ToString());
                    if (idPhongDel == value)
                    {
                        delFound = true;
                        gvSuDungSPDV.Rows[i].DefaultCellStyle.BackColor = Color.White;

                        //Chon lai phong update value
                        int soluong = 1;
                        double dongia = double.Parse(gvSanPhamDV.Rows[i].Cells["DONGIA"].Value.ToString());

                        gvSuDungSPDV.Rows[i].Cells["spSOLUONG"].Value = soluong;
                        gvSuDungSPDV.Rows[i].Cells["spDONGIA"].Value = dongia;
                        gvSuDungSPDV.Rows[i].Cells["spTHANHTIEN"].Value = soluong * dongia;
                    }
                    i++;
                }
                calcu();
            }

            if (delFound)
                Console.WriteLine("Success");
            else
                Console.WriteLine("Non");
        }

        private void gvPhongDat_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idPhongDel;
            bool delFound = false;

            if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
            {
                idPhongDel = int.Parse(gvPhongDat.Rows[e.RowIndex].Cells["dpIDPHONG"].Value.ToString());
                // Lấy dòng dữ liệu được chọn
                DataGridViewRow selectedRow = gvPhongDat.Rows[e.RowIndex];

                // Tạo một dòng mới cho nguồn dữ liệu DataGridView A
                DataRow newRow = ((DataTable)gvPhong.DataSource).NewRow();

                // Sao chép dữ liệu từ dòng được chọn sang dòng mới
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    newRow[cell.ColumnIndex] = cell.Value;
                }

                   // Thêm dòng mới vào nguồn dữ liệu DataGridView A
                   ((DataTable)gvPhong.DataSource).Rows.Add(newRow);

                gvPhongDat.Rows.RemoveAt(e.RowIndex);

                //duyet du lieu vua xoa bang tren co ton tai bang duoi hay khong
                for (int i = 0; i < gvSuDungSPDV.RowCount;)
                {
                    int value = int.Parse(gvSuDungSPDV.Rows[i].Cells["spIDPHONG"].Value.ToString());
                    if (idPhongDel == value)
                    {
                        delFound = true;
                        gvSuDungSPDV.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        gvSuDungSPDV.Rows[i].Cells["spSOLUONG"].Value = 0;
                    }
                    i++;
                }

                calcu();
            }

            if (delFound)
                Console.WriteLine("Success");
            else
                Console.WriteLine("Non");
        }

        private void gvPhong_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy số thứ tự dòng (dựa trên chỉ số hàng + 1)
            string rowNumber = (e.RowIndex + 1).ToString();

            // Tạo một vị trí để vẽ số thứ tự trong DataGridView
            Rectangle rowBounds = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, gvPhong.RowHeadersWidth - 4, e.RowBounds.Height);

            // Căn giữa số thứ tự trong vị trí vẽ
            using (StringFormat stringFormat = new StringFormat())
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                // Vẽ số thứ tự lên DataGridView
                e.Graphics.DrawString(rowNumber, gvPhong.Font, SystemBrushes.ControlText, rowBounds, stringFormat);
            }
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
            int index = gvPhongDat.Rows.Count;

            if (index == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (gvSanPhamDV.Rows[e.RowIndex].Cells["IDSP"].Value.ToString() != null)
                {
                    OBJ_DPSP sp = new OBJ_DPSP();
                    sp.IDSP = int.Parse(gvSanPhamDV.Rows[e.RowIndex].Cells["IDSP"].Value.ToString());
                    sp.TENSP = gvSanPhamDV.Rows[e.RowIndex].Cells["TENSP"].Value.ToString();
                    sp.IDPHONG = _idPhong;
                    sp.TENPHONG = _tenphong;
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
        }

        void loadDPSP()
        {
            //Reload lai
            List<OBJ_DPSP> addContinue = new List<OBJ_DPSP>();
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

        //Update so luong san pham data grid main
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

        //Only input number 
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
            int sumSLPhong = 0;

            double sumGiaTienSPDV = 0.0;
            double sumDonGiaPhong = 0.0;

            int columnIndexSL = gvSuDungSPDV.Columns["spSOLUONG"].Index;
            int columnIndexTT = gvSuDungSPDV.Columns["spTHANHTIEN"].Index;
            int colomnIndexPhongDG = gvPhongDat.Columns["dpDONGIA"].Index;

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
            if (gvPhongDat.Rows.Count > 0)
            {
                //Tinh tong cot dat phong co gia tien
                foreach (DataGridViewRow row in gvPhongDat.Rows)
                {
                    if (row.Cells[colomnIndexPhongDG].Value != null && row.Cells[colomnIndexPhongDG].Value.ToString() != "")
                    {
                        if (double.TryParse(row.Cells[colomnIndexPhongDG].Value.ToString(), out double value))
                        {
                            sumDonGiaPhong += value;
                        }
                    }
                }
            }

            tfSl_DPSP.Text = sumSL.ToString();

            //Chuyen doi tien te VND
            var numberMoneyVN = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
           
            //Chuyen doi tien te VND SPDV
            string formatValueSPDV = String.Format(numberMoneyVN, "{0:c}", sumGiaTienSPDV);
            tfGiaTienDPSP.Text = formatValueSPDV;

            //Chuyen doi tien phong VND Phong
            string formatMoneyValuePhong = String.Format(numberMoneyVN, "{0:c}", sumDonGiaPhong * _songayo);
            tfGiaPhong.Text = formatMoneyValuePhong;

            //Dem so luong phong
            if (gvPhongDat.Rows.Count > 0)
            {
                sumSLPhong += gvPhongDat.Rows.Count;
                tfSlPhong.Text = sumSLPhong.ToString();
            }
            else
            {
                sumSLPhong = 0;
                tfSlPhong.Text = sumSLPhong.ToString();
            }
            //fill so ngay o 
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
            var _kh = _khachhang.getItem(idKH);
            cbKhachHang.SelectedValue = _kh;
            cbKhachHang.Text = _kh.HOTEN;
        }

        private void gvPhongDat_Click(object sender, EventArgs e)
        {
            if (gvPhongDat.Rows.Count > 0)
            {
                for (int i = 0; i < gvPhongDat.Rows.Count; i++)
                {
                    _idPhong = int.Parse(gvPhongDat.Rows[i].Cells["dpIDPHONG"].Value.ToString());
                    _tenphong = gvPhongDat.Rows[i].Cells["dpTENPHONG"].Value.ToString();
                }
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
           if(gvDanhSach.RowCount > 0)
           {
                _idDatPhong = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());

                var dp = _datphong.getItem(_idDatPhong);
                //Cac thong tin khi duoc select
                cbKhachHang.SelectedValue = dp.IDKH;
                dateNgayDat.Value = dp.NGAYDAT.Value;
                dateNgayTra.Value = dp.NGAYTRA.Value;
                cbTrangThai.SelectedValue = dp.STATUS;
                numSLNguoi.Value = dp.SONGUOIO.Value;
                checkTheoDoan.Checked = dp.THEODOAN.Value;
                tfGhiChu.Text = dp.GHICHU;

                loadClickDataDP();
                loadClickDataDPSP();
           }
        }

        private void dateNgayDat_ValueChanged(object sender, EventArgs e)
        {
            /* DateTimePicker dtp = sender as DateTimePicker;
             DateTime dtValue = dtp.Value;

             if(dtValue < DateTime.Today)
             {
                 //Ngay dat khong be hon ngay hien tai
                 MessageBox.Show("Ngày đặt không thể trước ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 dtp.Value = DateTime.Today;
             }

             DateTime setNgayTra = dtValue.AddDays(1);
             dateNgayTra.Value = setNgayTra;*/
        }

        private void dateNgayTra_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            DateTime dtValue = dtp.Value;

            DateTimePicker getNgayDat = dateNgayDat;
            DateTime ngayDatValue = getNgayDat.Value;

            if (dtValue == DateTime.Today)
            {
                //Ngay dat khong be hon ngay hien tai
                MessageBox.Show("Ngày trả không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp.Value = ngayDatValue.AddDays(1);
            }
            if (dtValue < ngayDatValue)
            {
                //Ngay dat khong be hon ngay hien tai
                MessageBox.Show("Ngày trả không thể trước ngày đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp.Value = ngayDatValue.AddDays(1);

            }
            if (dtValue.Month - ngayDatValue.Month >= 2)
            {
                //Ngay dat khong be hon ngay hien tai
                MessageBox.Show("Hệ thống chỉ được đặt/trả phòng trong 30 ngày kể từ tháng bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp.Value = ngayDatValue.AddDays(1);
            }
            _songayo = dateNgayTra.Value.Day - dateNgayDat.Value.Day;
            calcu();
        }

        private void dateDiTuNgay_ValueChanged(object sender, EventArgs e)
        {
            //Neu chon ngay khong hop le
            if (dateDiTuNgay.Value > dateDiDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                loadDataDatPhong();
        }

        private void dateDiTuNgay_Leave(object sender, EventArgs e)
        {
            //Neu chon ngay khong hop le
            if (dateDiTuNgay.Value > dateDiDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                loadDataDatPhong();
        }

        private void dateDiDenNgay_ValueChanged(object sender, EventArgs e)
        {
            //Neu chon ngay khong hop le
            if (dateDiTuNgay.Value > dateDiDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                loadDataDatPhong();
        }

        private void dateDiDenNgay_Leave(object sender, EventArgs e)
        {
            //Neu chon ngay khong hop le
            if (dateDiTuNgay.Value > dateDiDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                loadDataDatPhong();
        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idDatPhong = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                var dp = _datphong.getItem(_idDatPhong);

                tabPage.SelectedTab = pageChiTiet;
                //Cac thong tin khi duoc select

                cbKhachHang.SelectedValue = dp.IDKH;
                dateNgayDat.Value = dp.NGAYDAT.Value;
                dateNgayTra.Value = dp.NGAYTRA.Value;
                cbTrangThai.SelectedValue = dp.STATUS;
                numSLNguoi.Value = dp.SONGUOIO.Value;
                checkTheoDoan.Checked = dp.THEODOAN.Value;
                tfGhiChu.Text = dp.GHICHU;

                //Text
                showTextBox(false);

                //Lay danh sach cac phong da dat theo ID Dat Phong 

                //lock 
                lockGridDataDP_DPSP(false);
              

               /* gvPhongDat.DataSource = _datphongct.getAllDataToTable(_idDatPhong); */
                loadClickDataDP();

                //Lay danh sach cac san pham cua cac phong dat theo ID Dat Phong CT

                /* gvSuDungSPDV.DataSource = _datphongsp.getAllDataTable(_idDatPhong); */
                loadClickDataDPSP();

                //Money
                calcu();
            }
        }

        void loadClickDataDP()
        {
            gvPhongDat.DataSource = myFunction.layDuLieu("SELECT p.IDPHONG, p.TENPHONG, lp.DONGIA, t.IDTANG, t.TENTANG, lp.TENLOAIPHONG FROM tb_phong p, tb_tang t, tb_loaiphong lp, tb_datphong_chitiet dpct WHERE p.IDTANG = t.IDTANG AND p.IDLOAIPHONG = lp.IDLOAIPHONG AND NOT lp.TENLOAIPHONG = 'None' AND dpct.IDPHONG = p.IDPHONG AND dpct.IDDP ='" + _idDatPhong + "'");
        }
        void loadClickDataDPSP()
        {
            gvSuDungSPDV.DataSource = _datphongsp.getAllDataTable(_idDatPhong);
        }
        void lockGridDataDP_DPSP(bool t)
        {
            gvPhong.Enabled = t;
            gvSanPhamDV.Enabled = t;
            gvPhongDat.Enabled = t;
            gvSuDungSPDV.Enabled = t;
        }

        private void gvSuDungSPDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gvSuDungSPDV.Rows.Count > 0)
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
    }
}