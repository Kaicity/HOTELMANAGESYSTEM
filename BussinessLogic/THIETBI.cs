using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class THIETBI
    {
        Entities db;

        public THIETBI()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_thietbi> getAll()
        {
            return db.tb_thietbi.ToList();
        }

        public tb_thietbi getItem(int IDtb)
        {
            return db.tb_thietbi.FirstOrDefault(x => x.IDTB == IDtb);
        }

        public void add(tb_thietbi thietbi)
        {
            try
            {
                db.tb_thietbi.Add(thietbi);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_thietbi thietbi)
        {
            tb_thietbi _thietbi = db.tb_thietbi.FirstOrDefault(x => x.IDTB == thietbi.IDTB);
            _thietbi.TENTB = thietbi.TENTB;
            _thietbi.DONGIA = thietbi.DONGIA;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void delete(int IDthietbi)
        {
            tb_thietbi _thietbi = db.tb_thietbi.Remove(getItem(IDthietbi));

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
