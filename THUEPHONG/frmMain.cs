using BussinessLogic;
using DataLayer;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Emf;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Drawing;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraNavBar;
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
    public partial class FrmMainFull : DevExpress.XtraEditors.XtraForm
    {
        FUNC f;
        TANG t;
        PHONG phg;
        public GalleryItem items = null;

        public FrmMainFull()
        {
            InitializeComponent();
        }

        private void FrmMainFull_Load(object sender, EventArgs e)
        {
            f = new FUNC();
            t = new TANG();
            phg = new PHONG();
            showLeftMenu();
            showRoom();
        }

        public void reloadChangeForm()
        {
            this.Controls.Clear();
            InitializeComponent();
            //----------------Load and Reset Data
            f = new FUNC();
            t = new TANG();
            phg = new PHONG();
            showLeftMenu();
            showRoom();

        }

        void showLeftMenu()
        {
            int i = 0;
            var isParent = f.getParent();
            navBarMain.Appearance.Item.Font = new Font("Segoe UI", 11);

            foreach (var pr in isParent)
            {
                NavBarGroup navGr = new NavBarGroup(pr.DESCRIPTION);
                //Icon dua vao i tang len sau moi lan lap
                navGr.ImageOptions.LargeImageIndex = i;
                i++;
                navGr.Tag = pr.FUNC_CODE;
                navGr.Name = pr.FUNC_CODE;

                navBarMain.Groups.Add(navGr);

                var isChild = f.getChild(pr.FUNC_CODE);
                foreach (var ch in isChild)
                {
                    NavBarItem navItems = new NavBarItem(ch.DESCRIPTION);
                    navItems.ImageOptions.SmallImageIndex = 0;
                    navItems.Appearance.FontSizeDelta = 10;
                    navItems.Tag = ch.FUNC_CODE;
                    navItems.Name = ch.FUNC_CODE;

                    navGr.ItemLinks.Add(navItems);
                }

                navBarMain.Groups[navGr.Name].Expanded = true;
            }

        }

        //Showlist danh sach cac phong trong khach san
        public void showRoom()
        {
            EventHandler MouseEnterd;
            phg = new PHONG();
            var isTang = t.getAll();
            gControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gControl.Gallery.ImageSize = new Size(64, 64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.Appearance.GroupCaption.Font = new Font("Arial", 10, FontStyle.Bold);
            gControl.Gallery.Appearance.ItemCaptionAppearance.Normal.Font = new Font("Arial", 10, FontStyle.Regular);
            gControl.Gallery.ShowGroupCaption = true;

            foreach (var t in isTang)
            {
                //Danh sach cac tang 
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = t.TENTANG;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;

                //Trong 1 tang se chua danh sach cac phong add vao group
                var isPhong = phg.getByTang(t.IDTANG);

                foreach (var p in isPhong)
                {
                    var gc_item = new GalleryItem();
                    gc_item.Caption = p.TENPHONG;
                    gc_item.Value = p.IDPHONG;
                    if (p.TRANGTHAI == false)
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[0];
                    }
                    else
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[1];
                    }

                   //Le tan va Tang phong hop 
                   /* if (p.IDTANG == 1)
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[3];
                    }
                    if (p.IDTANG == 2)
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[2];
                    }*/

                    galleryItem.Items.Add(gc_item);

                }
                gControl.Gallery.Groups.Add(galleryItem);
            }


        }

        //Tat toan bo ung dung kh dang open form 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Ham click thuc hien open form cac chuc nang cua he thong
        private void navBarMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string func_code = e.Link.Item.Tag.ToString();

            //menu 
            switch (func_code)
            {
                case "CONGTY":
                    {
                        frmCongTy frCty = new frmCongTy();
                        frCty.ShowDialog();
                        break;
                    }
                case "DONVI":
                    {
                        frmDonVi frDvi = new frmDonVi();
                        frDvi.ShowDialog();
                        break;
                    }
                case "LOAIPHONG":
                    {
                        frmLoaiPhong frLoaiPhong = new frmLoaiPhong();
                        frLoaiPhong.ShowDialog();
                        break;
                    }
                case "TANG":
                    {
                        frmTang frTang = new frmTang();
                        frTang.ShowDialog();
                        if (frTang.showLoadPageMain())
                        {
                            //load tang
                            //reloadChangeForm();
                            this.gControl.Gallery.Groups.Clear();
                            showRoom();
                        }
                        break;
                    }
                case "PHONG":
                    {
                        frmPhong frPhong = new frmPhong();
                        frPhong.ShowDialog();

                        if (frPhong.showLoadPageMain())
                        {
                            //reloadChangeForm();
                            //load Room
                            this.gControl.Gallery.Groups.Clear();
                            showRoom();
                        }
                        break;
                    }
                case "SANPHAM":
                    {
                        frmSanPham frSp = new frmSanPham();
                        frSp.ShowDialog();
                        break;
                    }
                case "THIETBI":
                    {
                        frmThietBi frThietBi = new frmThietBi();
                        frThietBi.ShowDialog();
                        break;
                    }
                case "KHACHHANG":
                    {
                        frmKhachHang frKH = new frmKhachHang();
                        frKH.ShowDialog();
                        break;
                    }
                case "PHONG_THIETBI":
                    {
                        frmThietBiTrongPhong frTBPhong = new frmThietBiTrongPhong();
                        frTBPhong.ShowDialog();
                        break;
                    }
                case "QUANTRI_USER":
                    {
                        //QUANTRI
                        break;
                    }
                case "DATPHONG":
                    {
                        frmDatPhong frDatPhong = new frmDatPhong();
                        frDatPhong.ShowDialog();
                        break;
                    }
            }
        }

        private void btnSys_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            //Left mouse show cac cuc nang ben nhu dat phong, thanh toan, tra phong
            Point point = gControl.PointToClient(Control.MousePosition);
            //Lay cac info name tu gcontrol using RibbonHitinfo
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);

            //Kiem tra neu ton tai nhung item viewr se cho phep show cac chuc nanng va thuc hien lay thong tin
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
            {
                items = hitInfo.GalleryItem;
            } 
        }

        //Testing dat phong ID 
        private void btnDatphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PHONG png = new PHONG();
            var phong = png.getItem(int.Parse(items.Value.ToString()));
            //Dat Phong Khach le
            if(phong.TRANGTHAI == true)
            {
                MessageBox.Show("Phòng đã được đặt. Vui lòng chọn phòng khác", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            frmDatPhongDon frmdpd = new frmDatPhongDon();
            frmdpd._idPhong = int.Parse(items.Value.ToString());
            frmdpd._them = true;
            frmdpd.ShowDialog();
        }

        private void btnSanPhamThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PHONG png = new PHONG();
            var phong = png.getItem(int.Parse(items.Value.ToString()));
            //Dat Phong Khach le
            if (phong.TRANGTHAI == false)
            {
                MessageBox.Show("Phòng chưa được đặt. Vui lòng đặt phòng trước khi cập nhật sản phẩm & dịch vụ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmDatPhongDon frmdpd = new frmDatPhongDon();
            frmdpd._idPhong = int.Parse(items.Value.ToString());
            frmdpd.showHideControls(false);
            frmdpd._them = false;
            frmdpd.ShowDialog();
        }

        private void btnThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* PHONG png = new PHONG();
            var phong = png.getItem(int.Parse(items.Value.ToString()));
            //Dat Phong Khach le
            if (phong.TRANGTHAI == true)
            {
                MessageBox.Show("Phòng hiện tại không còn trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmDatPhongDon frmdpd = new frmDatPhongDon();
            frmdpd._idPhong = int.Parse(items.Value.ToString());
            frmdpd.showHideControls(false);
            frmdpd._them = true;
            frmdpd.ShowDialog();*/
        }

        private void btnChuyenPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PHONG png = new PHONG();
            var phong = png.getItem(int.Parse(items.Value.ToString()));
            //Dat Phong Khach le
            if (phong.TRANGTHAI == false)
            {
                MessageBox.Show("Phòng chưa được đặt. Vui lòng đặt phòng trước khi sử dụng chức năng chuyển phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmChuyenPhong frmChuyenphong = new frmChuyenPhong();
            frmChuyenphong._idPhong = int.Parse(items.Value.ToString());
            frmChuyenphong.ShowDialog();
        }

        private void btnXemthongTinphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXemThongTinPhongDon frmXemTT = new frmXemThongTinPhongDon();
            frmXemTT._idPhong = int.Parse(items.Value.ToString());
            frmXemTT.ShowDialog();
        }
    }
}
