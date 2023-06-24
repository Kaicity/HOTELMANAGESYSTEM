using DataLayer;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace THUEPHONG
{
    static class Program
    {
        public static string getStrConnect; // value global
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainFull());
            //hello

            /*if (File.Exists("connectdb.dba"))
            {
                string conStr = "";
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
                Connect cp = (Connect)bf.Deserialize(fs);

                //Descrypt noi dung
                string servername = Encrytor.Descrypt(cp.Servername, "qwertyuiop", true);
                string username = Encrytor.Descrypt(cp.Usersername, "qwertyuiop", true);
                string pass = Encrytor.Descrypt(cp.Password, "qwertyuiop", true);
                string database = Encrytor.Descrypt(cp.Database, "qwertyuiop", true);

                conStr += "Data Source=" + servername +
                          "; Initial Catalog=" + database +
                          "; User ID=" + username +
                          "; Password=" + pass + ";";

                //Lay value Global
                getStrConnect= conStr;

                myFunction._ser = servername;
                myFunction._us = username;
                myFunction._pw = pass;
                myFunction._db= database;

                SqlConnection con = new SqlConnection(conStr);

                try
                {
                    con.Open();
                }
                catch(Exception ex)
                {
                    throw new Exception("Lỗi kết nối cơ sở dữ liệu nguồn");
                }
                finally { con.Close(); }
              
            }*/
        }
    }
}
