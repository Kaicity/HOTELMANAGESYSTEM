using DataLayer;
using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace THUEPHONG
{
    public class myFunction
    {
        public static string _ser;
        public static string _us;
        public static string _pw;
        public static string _db;
        static SqlConnection con = new SqlConnection();

        public static void taoKetNoi()
        {
            con.ConnectionString = "Server=.; Database=HOTEL; User Id=sa;Password=nmtnttt2505";
            try
            {
                con.Open();
            }
            catch(SqlException ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu");
            }
        }

        public void dongKetnoi()
        {
            con.Close();
        }

        public static DataTable layDuLieu(string query)
        {
            taoKetNoi();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter();
                dap.SelectCommand = new SqlCommand(query, con);
                dap.Fill(dt);
                return dt;
            }
            catch(SqlException ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu");
            }
            finally { con.Dispose(); }
            
        }

        public static void XoaDuLieu(string query)
        {
            taoKetNoi();

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu");
            }
            finally
            {
                con.Dispose();
            }
        }
        public static int demDuLieu(string query)
        {
            taoKetNoi();

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
            catch
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu");
            }
            finally
            {
                con.Dispose();
            }
        }

        public static DataTable getAllDanhSachDatPhong(int idKH) 
        {
            taoKetNoi();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter();
                dap.SelectCommand = new SqlCommand("SELECT dp.DISABLED, dp.ID, dp.NGAYDAT, dp.NGAYTRA, dp.SOTIEN, dp.SONGUOIO, dp.STATUS, dp.THEODOAN, kh.HOTEN, dp.GHICHU" +
                    "FROM tb_datphong dp, tb_khachhang kh WHERE dp.IDKH = kh.IDKH AND dp.IDKH = " + idKH, con);
                dap.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu");
            }
            finally { con.Dispose(); }
        }

        //Lay thong tin dat phong don duy nhat idphong
        public static DataTable getAllThongTinDatPhongDon(int idDp)
        {
            taoKetNoi();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter();
                dap.SelectCommand = new SqlCommand("SELECT dp.ID, p.TENPHONG, lp.DONGIA, dp.IDKH, kh.HOTEN, dp.NGAYDAT, dp.NGAYTRA, dp.STATUS, dp.SONGUOIO, dp.GHICHU, dp.THEODOAN, dpct.IDPHONG, sp.TENSP, dpsp.SOLUONG, dpsp.DONGIA, dpsp.THANHTIEN\r\nFROM tb_datphong dp, tb_datphong_chitiet dpct, tb_datphong_sanpham dpsp, tb_phong p, tb_loaiphong lp, tb_sanpham sp, tb_khachhang kh\r\nWHERE dp.ID = dpct.IDDP AND dp.ID = dpsp.IDDP AND p.IDPHONG = dpct.IDPHONG AND p.IDLOAIPHONG = lp.IDLOAIPHONG AND sp.IDSP = dpsp.IDSP AND kh.IDKH = dp.IDKH AND dp.ID ='" + idDp + "'", con);
                dap.Fill(dt);

                return dt;
            }
            catch(SqlException ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu");
            }
            finally { con.Dispose(); }
        }

        public static DataTable loadThongTinDatPhongDonDangDat(int idPhong)
        {
            taoKetNoi();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter();
                dap.SelectCommand = new SqlCommand("SELECT lp.IDLOAIPHONG, lp.TENLOAIPHONG, lp.DONGIA, p.IDPHONG, p.TENPHONG FROM tb_loaiphong lp, tb_phong p WHERE lp.IDLOAIPHONG = p.IDLOAIPHONG AND p.IDPHONG ='" + idPhong + "'");
                dap.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu");
            }
        }

        public static DateTime getFirstDayInMonth(int year, int month)
        {
            return new DateTime(year, month, 1);
        }

        public static DataTable callStoreProcPhieuDatPhongChiTiet(int id)
        {
            taoKetNoi();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("PHIEU_DATPHONG_CHITIET", con);

                //Dinh dang command la store proc
                cmd.CommandType = CommandType.StoredProcedure;
                //Truyen tham so Store Proc iddp
                cmd.Parameters.Add(new SqlParameter("@IDDP", id));

                dap.SelectCommand = cmd;
                dap.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu");
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
