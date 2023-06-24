using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class PHONGTHIETBI
    {
        Entities db;

        public PHONGTHIETBI()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_phong_thietbi> getAll()
        {
            return db.tb_phong_thietbi.ToList();
        }

        public tb_phong_thietbi getItem(int idPhong, int idTb)
        {
            return db.tb_phong_thietbi.FirstOrDefault(x => x.IDPHONG == idPhong && x.IDTB == idTb);
        }

        public void add(tb_phong_thietbi phong_tb)
        {
            try
            {
                db.tb_phong_thietbi.Add(phong_tb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_phong_thietbi phong_tb)
        {
            tb_phong_thietbi _phong_thietbi = db.tb_phong_thietbi
                .FirstOrDefault(x => x.IDPHONG == phong_tb.IDPHONG && x.IDTB == phong_tb.IDTB);
            _phong_thietbi.SOLUONG = phong_tb.SOLUONG;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void delete(int IDphong, int IDTb)
        {
            tb_phong_thietbi _phong = db.tb_phong_thietbi.Remove(getItem(IDphong, IDTb));

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
