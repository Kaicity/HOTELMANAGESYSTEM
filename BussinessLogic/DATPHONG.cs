using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class DATPHONG
    {
        Entities db;

        public DATPHONG()
        {
            db = Entities.CreateEntities();
        }

        public tb_datphong getItem(int idDp)
        {
            return db.tb_datphong.FirstOrDefault(x => x.ID == idDp);
        }

        public List<tb_datphong> getAll()
        {
            return db.tb_datphong.ToList();
        }

        public List<OBJ_DATPHONG> getAllDaTaDP(DateTime tuNgay, DateTime denNgay, string maCty, string maDvi)
        {
            var list_tb_datphong =  db.tb_datphong.Where(x => (x.NGAYDAT >= tuNgay && x.NGAYDAT < denNgay) && x.MACTY == maCty && x.MADVI == maDvi).ToList();
            List<OBJ_DATPHONG> listDP = new List<OBJ_DATPHONG>();
            OBJ_DATPHONG objDP;
            
            foreach(var item in list_tb_datphong)
            {
                objDP = new OBJ_DATPHONG();
                objDP.ID = item.ID;
                objDP.IDKH = item.IDKH;
                //su dung bang khac de lay ra ten khach hang dua vao ID khach hang
                var kh = db.tb_khachhang.FirstOrDefault(x => x.IDKH == item.IDKH);
                objDP.HOTEN = kh.HOTEN;
                objDP.NGAYDAT = item.NGAYDAT;
                objDP.NGAYTRA = item.NGAYTRA;
                objDP.SOTIEN = item.SOTIEN;
                objDP.SONGUOIO = item.SONGUOIO;
                objDP.IDUSER = item.IDUSER;
                objDP.MACTY = item.MACTY;
                objDP.MADVI= item.MADVI;
                objDP.STATUS = item.STATUS;
                objDP.THEODOAN = item.THEODOAN;
                objDP.DISABLED = item.DISABLED;
                objDP.GHICHU = item.GHICHU;

                listDP.Add(objDP);
            }
            return listDP;
        }

        //Khong tra ve void, tra ve table de lay duoc ID dat phong 
        public tb_datphong add(tb_datphong datphong)
        {
            try
            {
                db.tb_datphong.Add(datphong);
                db.SaveChanges();
                return datphong;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }

        public tb_datphong update(tb_datphong datphong)
        {
            //Update table theo ma cong ty
            tb_datphong _datphong = db.tb_datphong.FirstOrDefault(x => x.ID == datphong.ID);
            _datphong.IDKH = datphong.IDKH;
            _datphong.MACTY = datphong.MACTY;
            _datphong.MADVI = datphong.MADVI;
            _datphong.NGAYDAT = datphong.NGAYDAT;
            _datphong.NGAYTRA = datphong.NGAYTRA;
            _datphong.SOTIEN = datphong.SOTIEN;
            _datphong.SONGUOIO = datphong.SONGUOIO;
            _datphong.IDUSER = datphong.IDUSER;
            _datphong.THEODOAN = datphong.THEODOAN;
            _datphong.GHICHU = datphong.GHICHU;
            _datphong.UPDATE_DATE = datphong.UPDATE_DATE;
         
            try
            {
                db.SaveChanges();
                return datphong;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu");
            }
        }
        public void delete(int IDdatphong)
        {
            //Delete table theo ma cong ty
            tb_datphong _datphong = db.tb_datphong.Remove(getItem(IDdatphong));

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
