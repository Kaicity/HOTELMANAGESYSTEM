using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class CONGTY
    {
        Entities db;

        public CONGTY()
        {
            db = Entities.CreateEntities();
        }

        public tb_congty getItem(string idCty)
        {
            return db.tb_congty.FirstOrDefault(x => x.MACTY == idCty);
        }

        public List<tb_congty> getAll()
        {
            return db.tb_congty.ToList();
        }

        public List<string> getIDCty()
        {
            var data = db.tb_congty.Select(c => c.MACTY.ToString()).ToList();

            return data;
        }

        public void add(tb_congty cty)
        {
            try
            {
                db.tb_congty.Add(cty);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_congty congty)
        {
            //Update table theo ma cong ty
            tb_congty _congty = db.tb_congty.FirstOrDefault(x => x.MACTY == congty.MACTY);
            _congty.TENCTY = congty.TENCTY;
            _congty.DIENTHOAI = congty.DIENTHOAI;
            _congty.FAX = congty.FAX;
            _congty.EMAIL = congty.EMAIL;
            _congty.DIACHI = congty.DIACHI;
            _congty.DISABLED = congty.DISABLED;

            try
            {
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }
        public void delete(string IDCty)
        {
            //Delete table theo ma cong ty
            tb_congty _congty = db.tb_congty.Remove(getItem(IDCty));
            _congty.DISABLED = true;

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
