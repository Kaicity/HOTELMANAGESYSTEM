using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace THUEPHONG
{
    public partial class frmConnectDB : Form
    {
        public frmConnectDB()
        {
            InitializeComponent();
        }

        SqlConnection GetCon(string server, string username, string password, string database)
        {
            return new SqlConnection("Data Source="+server+"; Initial Catalog="+database+"; User ID="+username+"; Password="+password+";");
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = GetCon(tfSe.Text, tfUs.Text, tfPass.Text, cbBoxDB.Text);

            try
            {
                Con.Open();
                MessageBox.Show("Connect Success");
            }
            catch(Exception)
            {
                MessageBox.Show("Unsuccess!");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string svEncrypt = Encrytor.Encrypt(tfSe.Text, "qwertyuiop", true);
            string usEncrypt = Encrytor.Encrypt(tfUs.Text, "qwertyuiop", true);
            string passEncrypt = Encrytor.Encrypt(tfPass.Text, "qwertyuiop", true);
            string dbEncrypt = Encrytor.Encrypt(cbBoxDB.Text, "qwertyuiop", true);

           /* MessageBox.Show(svEncrypt);
            MessageBox.Show(usEncrypt);
            MessageBox.Show(passEncrypt);
            MessageBox.Show(dbEncrypt);*/

            SaveFileDialog sf = new SaveFileDialog();

            sf.Title = "Chọn nơi lưu trữ";
            sf.Filter = "Text Files (*.dba)|*.dba| AllFiles(*.*)|*.*";

            if(sf.ShowDialog() == DialogResult.OK)
            {
                Connect cn = new Connect(svEncrypt, usEncrypt, passEncrypt, dbEncrypt);
                cn.saveFiles();
                MessageBox.Show("Lưu trữ file thành công", "Thông báo");

            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cbBoxDB_MouseClick_1(object sender, MouseEventArgs e)
        {
            cbBoxDB.Items.Clear();
            string conn = "server=" + tfSe.Text + "; User ID=" + tfUs.Text + "; Password=" + tfPass.Text + ";";

            try
            {
                SqlConnection sqlConnect = new SqlConnection(conn);
                sqlConnect.Open();
                string query = "SELECT NAME FROM SYS.DATABASES";
                SqlCommand cmd = new SqlCommand(query, sqlConnect);

                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbBoxDB.Items.Add(dr[0].ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Chuỗi kết nối sai vui lòng kiểm tra lại chuỗi kết nối" + ex.Message);
            }
        }
    }
}
