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
    public partial class frmTang : DevExpress.XtraEditors.XtraForm
    {
        TANG _tang;
        bool _them;
        int _IDTang = 0;

        public frmTang()
        {
            InitializeComponent();
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
                if (_IDTang == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _tang.delete(_IDTang);
                }
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Xac nhan Luu cac du lieu vua them
            if (_them)
            {
                tb_tang tang = new tb_tang();
                tang.TENTANG = tfTen.Text;

                _tang.add(tang);
            }
            //Xac nhan Luu khi sua
            else
            {
                if (_IDTang == 0)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tb_tang tang = _tang.getItem(_IDTang);
                    tang.TENTANG = tfTen.Text;

                    _tang.update(tang);
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

            showLoadPageMain();

        }
        public bool showLoadPageMain()
        {
            this.Close();
            return true;
        }

        private void frmTang_Load(object sender, EventArgs e)
        {
            _tang = new TANG();
            loadData();
            showHideControls(true);
            showTextBox(false);
        }

        void loadData()
        {
            gcDanhSach.DataSource = _tang.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void showHideControls(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible = !t;

        }
        void showTextBox(bool t)
        {
            tfTen.Enabled = t;
        }
        public void resetField()
        {
            tfTen.Text = "";
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _IDTang = Convert.ToInt16(gvDanhSach.GetFocusedRowCellValue("IDTANG").ToString());
            //MessageBox.Show(Convert.ToString(_IDTang));
            tfTen.Text = gvDanhSach.GetFocusedRowCellValue("TENTANG").ToString();
        }
    }
}
