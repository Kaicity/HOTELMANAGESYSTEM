using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLogic
{
    public class FUNC
    {
        Entities db;

        public FUNC()
        {
            db = Entities.CreateEntities();
        }

        //Lay danh sach cac Func chuc nang cua he thong vao menu navBar
        public List<tb_func> getParent()
        {
            //Lay danh sach cha parent danh muc chua con
            return db.tb_func.Where(x => x.ISGROUP == true && x.MENU == true)
                .OrderBy(s => s.SORT).ToList();
        }
        public List<tb_func> getChild(string parent)
        {
            //Lay danh sach cua con child nam trong sanh muc cua cha la parent
            return db.tb_func.Where(x => x.ISGROUP == false && x.MENU == true && x.PARENT == parent)
                .OrderBy(s => s.SORT).ToList();
        }
    }
}
