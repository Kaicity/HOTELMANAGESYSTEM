using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class LOAIPHONG
    {
        public Entities db;

        public LOAIPHONG()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_loaiphong> getAll()
        {
            return db.tb_loaiphong.ToList();
        }

        public tb_loaiphong getItem(int id)
        {
            return db.tb_loaiphong.FirstOrDefault(x => x.IDLOAIPHONG == id);
        }

        public void add(tb_loaiphong loaiphong)
        {
            try
            {
                db.tb_loaiphong.Add(loaiphong);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_loaiphong loaiphong)
        {
            tb_loaiphong _loaiphong = db.tb_loaiphong.FirstOrDefault(x => x.IDLOAIPHONG == loaiphong.IDLOAIPHONG);
            _loaiphong.TENLOAIPHONG = loaiphong.TENLOAIPHONG;
            _loaiphong.DONGIA = loaiphong.DONGIA;
            _loaiphong.SONGUOI = loaiphong.SONGUOI;
            _loaiphong.SOGIUONG = loaiphong.SOGIUONG;
            _loaiphong.DISABLED = loaiphong.DISABLED;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void delete(int id)
        {
            tb_loaiphong _loaiphong = db.tb_loaiphong.Remove(getItem(id));

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
