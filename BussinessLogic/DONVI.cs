using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class DONVI
    {
        Entities db;

        public DONVI()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_donvi> getAll()
        {
            return db.tb_donvi.ToList();
        }

        public tb_donvi getItem(string madv)
        {
            return db.tb_donvi.FirstOrDefault(x => x.MADVI == madv);
        }

        public void add(tb_donvi donvi)
        {
            try
            {
                db.tb_donvi.Add(donvi);
                db.SaveChanges();

            }catch(Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_donvi donvi)
        {
            tb_donvi _donvi = db.tb_donvi.FirstOrDefault(x => x.MADVI == donvi.MADVI);
            _donvi.TENDVI = donvi.TENDVI;
            _donvi.TENDVI = donvi.TENDVI;
            _donvi.DIENTHOAI = donvi.DIENTHOAI;
            _donvi.FAX = donvi.FAX;
            _donvi.EMAIL = donvi.EMAIL;
            _donvi.DIACHI = donvi.DIACHI;
            _donvi.MACTY= donvi.MACTY;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void delete(string id)
        {
            tb_donvi _donvi = db.tb_donvi.Remove(getItem(id));

            try
            {
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }
    }
}
