using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class KHACHHANG
    {
        Entities db;

        public KHACHHANG()
        {
            db = Entities.CreateEntities();
        }

        public tb_khachhang getItem(int idKH)
        {
            return db.tb_khachhang.FirstOrDefault(x => x.IDKH == idKH);
        }

        public List<tb_khachhang> getAll()
        {
            return db.tb_khachhang.ToList();
        }
        public void add(tb_khachhang khachhang)
        {
            try
            {
                db.tb_khachhang.Add(khachhang);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_khachhang khachhang)
        {
            //Update table theo ma cong ty
            tb_khachhang _khachhang = db.tb_khachhang.FirstOrDefault(x => x.IDKH == khachhang.IDKH);
            _khachhang.HOTEN = khachhang.HOTEN;
            _khachhang.CCCD = khachhang.CCCD;
            _khachhang.EMAIL = khachhang.EMAIL;
            _khachhang.DIENTHOAI = khachhang.DIENTHOAI;
            _khachhang.DIACHI = khachhang.DIACHI;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }
        public void delete(int IDkhachhang)
        {
            //Delete table theo ma cong ty
            tb_khachhang _khachhang = db.tb_khachhang.Remove(getItem(IDkhachhang));
           
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
