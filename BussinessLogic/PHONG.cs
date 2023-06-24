using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class PHONG
    {
        Entities db;

        public PHONG()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_phong> getAll()
        {
            return db.tb_phong.ToList();
        }

        public List<tb_phong> getByTang(int idTang)
        {
            return db.tb_phong.Where(x => x.IDTANG == idTang).ToList();
        }

        public tb_phong getItem(int id)
        {
            return db.tb_phong.FirstOrDefault(x => x.IDPHONG == id);
        }

        public void add(tb_phong phong)
        {
            try
            {
                db.tb_phong.Add(phong);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_phong phong)
        {
            tb_phong _phong = db.tb_phong.FirstOrDefault(x => x.IDPHONG == phong.IDPHONG);
            _phong.TENPHONG = phong.TENPHONG;
            _phong.TRANGTHAI = phong.TRANGTHAI;
            _phong.IDTANG = phong.IDTANG;
            _phong.IDLOAIPHONG = phong.IDLOAIPHONG;
            _phong.IMAGE = phong.IMAGE;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void updateStatus(int idPhong, bool value)
        {
           tb_phong _phong = db.tb_phong.FirstOrDefault(x => x.IDPHONG == idPhong);

            _phong.TRANGTHAI = value;

            try
            {
                db.SaveChanges();
            }
            catch
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void delete(int IDphong)
        {
            tb_phong _phong = db.tb_phong.Remove(getItem(IDphong));

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
