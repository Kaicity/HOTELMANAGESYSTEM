using BussinessLogic;
using DataLayer;
using DevExpress.Utils.Gesture;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
        KHACHHANG _khachhang;
        SANPHAM _sanpham;
        SYS_PARAM _sys_param;
        PHONG _phong;

        //Ma Cong Ty va MaDonVi Default khong can phai nhap du lieu
        string _maCty;
        string _maDvi;

        int _idPhong;
        string _tenphong;

        //Khai bao mot List<> su dung cho Gridview San Pham vi khi Click chon khong cung cau truc 
        List<OBJ_DPSP> listDPSP;


        public frmDatPhong()
        {
            InitializeComponent();
            DataTable dt = myFunction.layDuLieu("SELECT p.IDPHONG, p.TENPHONG, lp.DONGIA, t.IDTANG, t.TENTANG FROM tb_phong p, tb_tang t, tb_loaiphong lp WHERE p.IDTANG = t.IDTANG AND p.IDLOAIPHONG = lp.IDLOAIPHONG AND p.TRANGTHAI = 0 AND NOT lp.TENLOAIPHONG = 'None'");
           
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
            cbTrangThai.DataSource = TRANGTHAI.getListPhong();
            cbTrangThai.ValueMember = "_value";
            cbTrangThai.DisplayMember = "_display";

        }

        void loadSanPham()
        {
            gvSanPhamDV.DataSource = _sanpham.getAll();
        }
        
        public void loadDataCb_KhachHang()
        {
            _khachhang = new KHACHHANG();
            cbKhachHang.DataSource = _khachhang.getAll();
            cbKhachHang.ValueMember = "IDKH";
            cbKhachHang.DisplayMember= "HOTEN";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControls(false);
            showTextBox(true);
            tabPage.SelectedTab = pageChiTiet;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showHideControls(false);
            _them = false;
            showTextBox(true);
            tabPage.SelectedTab = pageChiTiet;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           /* if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo",
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
            loadData();*/
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           //Xac nhan Luu cac du lieu vua them

            _them = false;
            //loadData();
            showHideControls(true);
            showTextBox(false);
            resetField();
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
                dp.SOTIEN = double.Parse(tfTotal.Text);
                dp.GHICHU = tfGhiChu.Text;
                dp.IDUSER = 1;
                dp.MACTY = _maCty;
                dp.MADVI = _maDvi;
                //Sau khi them du lieu tra ve ID dat phong
                var _dps = _datphong.add(dp);

                for(int i = 0; i < gvPhongDat.RowCount; i++)
                {
                    dpct = new tb_datphong_chitiet();
                    dpct.IDDP = _dps.ID;
                    dpct.IDPHONG = int.Parse(gvPhongDat.Rows[i].Cells["IDPHONG"].Value.ToString());
                    dpct.SONGAYO = dateNgayTra.Value.Day - dateNgayDat.Value.Day;
                    dpct.DONGIA = int.Parse(gvPhongDat.Rows[i].Cells["DONGIA"].Value.ToString());
                    dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
                    _datphongct.add(dpct);
                    _phong.updateStatus(int.Parse(dpct.IDPHONG.ToString()), true);

                    if(gvSuDungSPDV.RowCount > 0)
                    {
                        //San pham trong moi phong duoc dat o chi tiet dat phong
                        for (int j = 0; j < gvSuDungSPDV.RowCount; j++)
                        {

                        }
                    }
                    else
                    {
                        dpsp = new tb_datphong_sanpham();
                        dpsp.IDDP = _dps.ID;
                        dpsp.IDPHONG = dpct.IDPHONG;
                    }

                }
            }
            else
            {

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
            cbKhachHang.Text = "";
            dateNgayDat.Value = DateTime.Now;
            dateNgayDat.Value = DateTime.Now.AddDays(1);
            cbTrangThai.SelectedValue = false;
            tfGhiChu.Text = "";
            numSLNguoi.Value = 1;
            checkTheoDoan.Checked = true;
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
            _idPhong = int.Parse(gvPhong.Rows[e.RowIndex].Cells["IDPHONG"].Value.ToString());
            _tenphong = gvPhong.Rows[e.RowIndex].Cells["TENPHONG"].Value.ToString();

            if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
            {
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
                calcu();
            }
        }

        private void gvPhongDat_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //Khong cho phep loai bo phong khi da dat san pham
            if (e.RowIndex == 0)
            {
                MessageBox.Show("Ít nhất phải có một phòng", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
                {
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
                    calcu();
                }
            }

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

            if(index == 0)
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
                    sp.SOLUONG = 1;
                    sp.DONGIA = float.Parse(gvSanPhamDV.Rows[e.RowIndex].Cells["DONGIA"].Value.ToString());
                    sp.THANHTIEN = sp.SOLUONG * sp.DONGIA;

                    foreach(var item in listDPSP)
                    {
                        if(item.IDSP == sp.IDSP && item.IDPHONG== sp.IDPHONG)
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
            
            if (e.RowIndex >= 0 && e.ColumnIndex == gvSuDungSPDV.Columns["spSOLUONG"].Index)
            {
                //lay dong du lieu hien tai 
                int index = e.RowIndex;

                //Gia tri moi cua cot so luong
                int sl = Convert.ToInt32(gvSuDungSPDV.Rows[index].Cells["spSOLUONG"].Value.ToString());
                int checkNum;

                if (sl > 0)
                {
                    double gia = double.Parse(gvSuDungSPDV.Rows[index].Cells["spDONGIA"].Value.ToString());

                    //Update thanh tien
                    double newValue = sl * gia;
                    gvSuDungSPDV.Rows[index].Cells["spTHANHTIEN"].Value = newValue;

                    calcu();
                }
                else if(sl < 0)
                {
                    MessageBox.Show("Giá trị không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gvSuDungSPDV.Rows[index].Cells["spSOLUONG"].Value = 0;

                    calcu();

                }
                else
                    gvSuDungSPDV.Rows[index].Cells["spTHANHTIEN"].Value = 0;
                    calcu();
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

            double sumGiaTienSPDV = 0;
            double sumDonGiaPhong = 0;

            int columnIndexSL = gvSuDungSPDV.Columns["spSOLUONG"].Index;
            int columnIndexTT = gvSuDungSPDV.Columns["spTHANHTIEN"].Index;
            int colomnIndexPhongDG = gvPhongDat.Columns["dpDONGIA"].Index;

            if (gvSuDungSPDV.Rows.Count >= 0)
            {
               
                //Tinh tong cot so luong san pham
                foreach(DataGridViewRow row in gvSuDungSPDV.Rows)
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
            if(gvPhongDat.Rows.Count >= 0)
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

            //Chuyen doi tien te VND value 
            CultureInfo cul = new CultureInfo("vi-VN");
            string formatValue = sumGiaTienSPDV.ToString("#,###", cul.NumberFormat);
            /* var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string formatValue = String.Format(info, "{0:c}", sumGiaTien);*/
            tfGiaTienDPSP.Text = formatValue;

            //Chuyen doi tien phong VND Value 
            CultureInfo culPhong = new CultureInfo("vi-VN");
            string formatMoneyValuePhong = sumDonGiaPhong.ToString("#, ###", culPhong.NumberFormat);
            tfGiaPhong.Text = formatMoneyValuePhong;

            //Dem so luong phong
            if(gvPhongDat.Rows.Count > 0)
            {
                sumSLPhong += gvPhongDat.Rows.Count;
                tfSlPhong.Text = sumSLPhong.ToString();
            }

            //Tinh tong cong so tien phai tra
            double totalPhongAndSanPham = sumGiaTienSPDV + sumDonGiaPhong;
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string formatMoneyValue = String.Format(info, "{0:c}", totalPhongAndSanPham);
            tfTotal.Text = formatMoneyValue;


        }

        private void gvSuDungSPDV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = gvSuDungSPDV.Columns["spSOLUONG"].Index;  // Thay YourColumnIndex bằng chỉ số cột cần tô màu
            if (e.ColumnIndex == columnIndex)
            {
                int value = Convert.ToInt32(e.Value);
                if(value >= 0)
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
    }
}