using DataLayer;
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
            finally { con.Close(); }
            
        }

        public static DateTime getFirstDayInMonth(int year, int month)
        {
            return new DateTime(year, month, 1);
        }
    }
}
