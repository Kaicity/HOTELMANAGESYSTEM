using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return db.tb_datphong.FirstOrDefault(x => x.IDKH == idDp);
        }

        public List<tb_datphong> getAll()
        {
            return db.tb_datphong.ToList();
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
            _datphong.DISABLED = datphong.DISABLED;
            _datphong.THEODOAN = datphong.THEODOAN;
            _datphong.GHICHU = datphong.GHICHU;
            _datphong.CREATED_DATE = datphong.CREATED_DATE;


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
