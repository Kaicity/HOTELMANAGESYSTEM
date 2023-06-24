using DataLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class SANPHAM
    {
        Entities db;

        public SANPHAM()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_sanpham> getAll()
        {
            return db.tb_sanpham.ToList();
        }

        public tb_sanpham getItem(int IDsp)
        {
            return db.tb_sanpham.FirstOrDefault(x => x.IDSP == IDsp);
        }

        public void add(tb_sanpham sanpham)
        {
            try
            {
                db.tb_sanpham.Add(sanpham);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_sanpham sanpham)
        {
            tb_sanpham _sanpham = db.tb_sanpham.FirstOrDefault(x => x.IDSP == sanpham.IDSP);
            _sanpham.TENSP = sanpham.TENSP;
            _sanpham.DONGIA = sanpham.DONGIA;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void delete(int IDsanpham)
        {
            tb_sanpham _sanpham = db.tb_sanpham.Remove(getItem(IDsanpham));

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }
    }
}
