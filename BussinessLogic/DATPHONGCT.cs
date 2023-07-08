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

        public List<tb_datphong_chitiet> getAll()
        {
            return db.tb_datphong_chitiet.ToList();
        }

        public List<tb_datphong_chitiet> getAllByDatPhong(int iddp) 
        {
            return db.tb_datphong_chitiet.Where(x => x.IDDP == iddp).ToList();
        }
        /*public List<OBJ_DATPHONGCT> getAllDataToTable(int iddp)
        {
            var list_table_DatPhongCT = db.tb_datphong_chitiet.Where(x => x.IDDP == iddp).ToList();
            List<OBJ_DATPHONGCT> listDPCT = new List<OBJ_DATPHONGCT>();
            OBJ_DATPHONGCT dpct;

            foreach (var item in list_table_DatPhongCT)
            {
                dpct = new OBJ_DATPHONGCT();
                dpct.IDPHONG = item.IDPHONG;

                //Khoi tao lai Entity de thao tac, khong khoi tao se bi loi ,close Entities 
                db = Entities.CreateEntities();
                var _phong = db.tb_phong.FirstOrDefault(x => x.IDPHONG == item.IDPHONG);
                dpct.TENPHONG = _phong.TENPHONG;

                TANG tang = new TANG();
                var _tang = tang.getItem(_phong.IDTANG);
                dpct.IDTANG = _tang.IDTANG;
                dpct.TENTANG = _tang.TENTANG;
                dpct.DONGIA = item.DONGIA;

                listDPCT.Add(dpct);
            }
            return listDPCT;
        }
        */

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
