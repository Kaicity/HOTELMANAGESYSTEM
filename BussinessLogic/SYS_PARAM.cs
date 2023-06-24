using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLogic
{
    public class SYS_PARAM
    {
        public Entities db;

        public SYS_PARAM()
        {
            db = Entities.CreateEntities();
        }

        //Ham lay du lieu cong ty va don vi duy nhat 
        public tb_param GetParam()
        {
            return db.tb_param.FirstOrDefault();
        }
    }
}
