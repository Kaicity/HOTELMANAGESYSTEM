using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class OBJ_DATPHONG
    {
        //public int IDPHONG { get; set; }

        //public string TENPHONG { get; set; }

        //public double DONGIA { get; set; }

        //public string STATUS { get; set; }

        //public int IDTANG { get; set; }

        //public int LOAIPHONG { get; set; }

        //public bool DISABLED { get; set; }

        //public string TENTANG { get; set; }

        //public string TENLOAIPHONG { get; set; }

        //public int IDDATPHONG { get; set; }

        public int ID { get; set; }

        public int IDKH { get; set; }

        public string HOTEN { get; set; }

        public DateTime? NGAYDAT { get; set; }

        public DateTime? NGAYTRA { get; set; }

        public double? SOTIEN { get; set; }

        public int? SONGUOIO { get; set; }

        public int IDUSER { get; set; }

        public string MACTY { get; set;}

        public string MADVI { get; set; }

        public bool? STATUS { get; set; }

        public bool? THEODOAN { get; set; }

        public bool? DISABLED { get; set; }

        public string GHICHU { get; set; }

    }
}
