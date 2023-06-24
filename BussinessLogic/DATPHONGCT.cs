using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class DATPHONGCT
    {
        Entities db;

        public DATPHONGCT()
        {
            db = Entities.CreateEntities();
        }

        public tb_datphong_chitiet getItem(int idDpCT)
        {
            return db.tb_datphong_chitiet.FirstOrDefault(x => x.IDDPCT == idDpCT);
        }

        public List<tb_datphong_chitiet> getAll()
        {
            return db.tb_datphong_chitiet.ToList();
        }
        public void add(tb_datphong_chitiet datphongCT)
        {
            try
            {
                db.tb_datphong_chitiet.Add(datphongCT);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_datphong_chitiet datphongCT)
        {
            //Update table theo ma cong ty
            tb_datphong_chitiet _datphongCT_ct = db.tb_datphong_chitiet.FirstOrDefault(x => x.IDDPCT == datphongCT.IDDPCT);
            _datphongCT_ct.IDDP = datphongCT.IDDP;
            _datphongCT_ct.IDPHONG = datphongCT.IDPHONG;
            _datphongCT_ct.IDDPCT = datphongCT.IDDPCT;
            _datphongCT_ct.NGAY = datphongCT.NGAY;
            _datphongCT_ct.DONGIA = datphongCT.DONGIA;
            _datphongCT_ct.SONGAYO = datphongCT.SONGAYO;
            _datphongCT_ct.THANHTIEN = datphongCT.THANHTIEN;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }
        public void delete(int IDdatphong)
        {
            //Delete table theo ma cong ty
            tb_datphong_chitiet _datphong = db.tb_datphong_chitiet.Remove(getItem(IDdatphong));

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
