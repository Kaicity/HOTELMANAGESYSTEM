using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class DATPHONGSP
    {
        Entities db;

        public DATPHONGSP()
        {
            db = Entities.CreateEntities();
        }

        public tb_datphong_sanpham getItem(int idDPSP)
        {
            return db.tb_datphong_sanpham.FirstOrDefault(x => x.IDDPSP == idDPSP);
        }

        public List<tb_datphong_sanpham> getAll()
        {
            return db.tb_datphong_sanpham.ToList();
        }

        public List<OBJ_DPSP> getAllDataTableDatPhongSanPham(int iddp) 
        { 
            var listDPSP = db.tb_datphong_sanpham.Where(x => x.IDDP == iddp).ToList();
            List<OBJ_DPSP> list_objSPDV = new List<OBJ_DPSP>();
            OBJ_DPSP dpsp;
            foreach(var item in listDPSP)
            {
               if(item.IDSP != null) 
               {
                    dpsp = new OBJ_DPSP();
                    dpsp.IDDP = item.IDDP;
                    dpsp.IDSP = item.IDSP;

                    //Khoi tao lai Enties de thao tac voi du lieu, Entity Closes !
                    db = Entities.CreateEntities();
                    var sp = db.tb_sanpham.FirstOrDefault(x => x.IDSP == item.IDSP);
                    dpsp.TENSP = sp.TENSP;
                    dpsp.SOLUONG = item.SOLUONG;
                    dpsp.DONGIA = item.DONGIA;
                    dpsp.THANHTIEN = item.THANHTIEN;
                    dpsp.IDPHONG = item.IDPHONG;

                    var phong = db.tb_phong.FirstOrDefault(x => x.IDPHONG == item.IDPHONG);
                    dpsp.TENPHONG = phong.TENPHONG;

                    list_objSPDV.Add(dpsp);
               }
            }
            return list_objSPDV;
        }

        //Lay danh sach tat ca san pham da duoc su dung, de cap nhat chuyen phong bang idsp
        public List<tb_datphong_sanpham> getDataPhongSanPham(int iddp, int iddpct)
        {
            return db.tb_datphong_sanpham.Where(x => x.IDDP == iddp && x.IDDPCT == iddpct).ToList();
        }

        public void add(tb_datphong_sanpham datphongSP)
        {
            try
            {
                db.tb_datphong_sanpham.Add(datphongSP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public void update(tb_datphong_sanpham datphongSP)
        {
            //Update table theo ma cong ty
            tb_datphong_sanpham _datphong_SP = db.tb_datphong_sanpham.FirstOrDefault(x => x.IDDPSP == datphongSP.IDDPSP);
            _datphong_SP.IDDP = datphongSP.IDDP;
            _datphong_SP.IDDPCT = datphongSP.IDDPCT;
            _datphong_SP.IDPHONG = datphongSP.IDPHONG;
            _datphong_SP.IDSP = datphongSP.IDSP;
            _datphong_SP.NGAY = datphongSP.NGAY;
            _datphong_SP.SOLUONG = datphongSP.SOLUONG;
            _datphong_SP.DONGIA = datphongSP.DONGIA;
            _datphong_SP.THANHTIEN = datphongSP.THANHTIEN;
            
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }
        /*public void delete(int idDatPhongSP)
        {
            //Delete table theo ma cong ty
            tb_datphong_sanpham _datphongSP = db.tb_datphong_sanpham.Remove(getItem(idDatPhongSP));

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }*/
        public void deleteAll(int idDatPhong)
        {
            List<tb_datphong_sanpham> lstSP = db.tb_datphong_sanpham.Where(x => x.IDDP == idDatPhong).ToList();

            try
            {
                db.tb_datphong_sanpham.RemoveRange(lstSP);
                db.SaveChanges();
            }
            catch
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }
    }
}
