using BussinessLogic;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THUEPHONG
{
    public partial class frmNhanVien : Form
    {
        private ListViewItem hoveredItem = null;

        TANG t;
        PHONG phg;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            t = new TANG();
            phg = new PHONG();

            loadData();
            //loadTest();
        }
        void loadData()
        {
            var isTang = t.getAll();

            foreach (var t in isTang)
            {
                //Danh sach cac tang 
                var itemGroup = new ListViewGroup(t.TENTANG, HorizontalAlignment.Left);
          
                //Trong 1 tang se chua danh sach cac phong add vao group
                var isPhong = phg.getByTang(t.IDTANG);
                foreach (var p in isPhong)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = p.TENPHONG.ToString();
                    item.Name = p.IDPHONG.ToString();
                    item.Group = itemGroup;

                    listView.LargeImageList = imageList3;

                    if (p.TRANGTHAI == false)
                    {
                        item.ImageIndex = 0;
                    }
                    else
                    {
                        item.ImageIndex = 1;
                    }

                    if (p.IDTANG == 1)
                    {
                        item.ImageIndex = 3;
                    }
                    if (p.IDTANG == 2)
                    {
                       
                        item.ImageIndex = 2;
                    }


                    listView.Items.Add(item);
                }
                listView.Groups.Add(itemGroup);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView.GetItemAt(e.X, e.Y);

            if (item != hoveredItem)
            {
                hoveredItem = item;
                listView.Invalidate();
            }
        }

        private void listView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

            if (e.Item == hoveredItem)
            {
                e.Graphics.DrawRectangle(Pens.Red, e.Bounds);
            }
        }
    }
}
