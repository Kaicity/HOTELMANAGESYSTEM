using BussinessLogic;
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
    public partial class frmXemThongTinPhongDon : Form
    {
        public int _idPhong = 0;
        public string tenPhong = "";
        PHONG _phong;
        LOAIPHONG _loaiphhong;

        public frmXemThongTinPhongDon()
        {
            InitializeComponent();
        }

        private void frmXemThongTinPhongDon_Load(object sender, EventArgs e)
        {
            _phong = new PHONG();
            _loaiphhong= new LOAIPHONG();

            var itemPhong = _phong.getItem(_idPhong);
            if(itemPhong != null )
            {
                lbTenPhong.Text = itemPhong.TENPHONG.ToString();
                var itemLooaiphong = _loaiphhong.getItem(itemPhong.IDLOAIPHONG);
                lbLoaiPhong.Text = itemLooaiphong.TENLOAIPHONG.ToString();
                lbSonguoi.Text = itemLooaiphong.SONGUOI.ToString();
                lbSoGiuong.Text = itemLooaiphong.SOGIUONG.ToString();

                var currentMoney = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                string formatMoney = string.Format(currentMoney, "{0:c}", itemLooaiphong.DONGIA);
                lbDonGia.Text = formatMoney;

                byte[] itemImamge = itemPhong.IMAGE;
                if (itemImamge != null)
                {
                    //Chuyen do byte thanh hinh anh
                    ImageConverter ic = new ImageConverter();
                    Image image = (Image)ic.ConvertFrom(itemImamge);
                    picBox.Image = image;
                }
                else
                    picBox.Image = Properties.Resources._68747470733a2f2f662e636c6f75642e6769746875622e636f6d2f6173736574732f323037383234352f3235393331332f35653833313336322d386362612d313165322d383435332d6536626439353663383961342e706e67;
            }
        }
    }
}
