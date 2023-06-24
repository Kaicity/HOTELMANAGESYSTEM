using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class TANG
    {
        Entities db;

        public TANG()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_tang> getAll()
        {
            return db.tb_tang.ToList();
        }

        public tb_tang getItem(int IDTang)
        {
            return db.tb_tang.FirstOrDefault(x => x.IDTANG == IDTang);
        }

        public void add(tb_tang tang)
        {
            try
            {
                db.tb_tang.Add(tang);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_tang tang)
        {
            tb_tang _tang = db.tb_tang.FirstOrDefault(x => x.IDTANG == tang.IDTANG);
            _tang.TENTANG = tang.TENTANG;
            
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void delete(int IDtang)
        {
            tb_tang _tang = db.tb_tang.Remove(getItem(IDtang));

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
