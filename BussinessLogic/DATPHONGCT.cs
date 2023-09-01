using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public tb_datphong_chitiet getItem(int idDp, int idPhong)
        {
            return db.tb_datphong_chitiet.FirstOrDefault(x => x.IDDP == idDp && x.IDPHONG == idPhong);
        }

        public List<tb_datphong_chitiet> getAll()
        {
            return db.tb_datphong_chitiet.ToList();
        }

        //Lay danh sach cac phong da duoc su dung dau vao IDPHONG va lay danh sach moi nhat duoc sap xep theo NGAY moi nhat
        public tb_datphong_chitiet getItemByPhong(int idPhong)
        {
            return db.tb_datphong_chitiet.OrderByDescending(x => x.NGAY).FirstOrDefault(y => y.IDPHONG == idPhong);
        }
        
        public List<tb_datphong_chitiet> getAllByDatPhong(int iddp) 
        {
            return db.tb_datphong_chitiet.Where(x => x.IDDP == iddp).ToList();
        }

        //Query kiem thu testing
        /*public List<OBJ_PHONG_THEODOAN> getPhong_TheoDoan()
        {
            var query = db.tb_datphong_chitiet
                .Join(db.tb_datphong, a => a.IDDP, b => b.ID, (a, b) => new { dpct = a, dp = b })
                .Where(x => x.dpct.IDDP == x.dp.ID)
                .Select(x => new
                {
                    x.dpct.IDPHONG,
                    x.dp.THEODOAN
                }).ToList();
            var list = query.ToList();

            List<OBJ_PHONG_THEODOAN> listPTD = new List<OBJ_PHONG_THEODOAN>();
            OBJ_PHONG_THEODOAN objPhongTheoDoan;
            foreach(var item in list)
            {
                objPhongTheoDoan = new OBJ_PHONG_THEODOAN();
                objPhongTheoDoan.IDPHONG = item.IDPHONG;
                objPhongTheoDoan.THEODOAN = item.THEODOAN;

                listPTD.Add(objPhongTheoDoan);
            }

            return listPTD;
        }*/


        public tb_datphong_chitiet add(tb_datphong_chitiet datphongCT)
        {
            try
            {
                db.tb_datphong_chitiet.Add(datphongCT);
                db.SaveChanges();
                return datphongCT;
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
      /*  public void delete()
        {
            //Delete toan bo du lieu
            List<tb_datphong_chitiet> list = db.tb_datphong_chitiet.ToList();

            try
            {
                db.tb_datphong_chitiet.RemoveRange(list);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }*/
        public void deleteAll(int idDatPhong)
        {
            List<tb_datphong_chitiet> lstDPCT = db.tb_datphong_chitiet.Where(x => x.IDDP == idDatPhong).ToList();

            try
            {
                db.tb_datphong_chitiet.RemoveRange(lstDPCT);
                db.SaveChanges();
            }
            catch
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }
    }
}
