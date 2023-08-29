using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class TRANGTHAI
    {
        public bool _value { get; set; }
        public string _display { get; set; }

        public TRANGTHAI(bool _val, string _dis)
        {
            this._value = _val;
            this._display = _dis;
        }
        public TRANGTHAI() { }

        public static List<TRANGTHAI> getList()
        {
            List<TRANGTHAI> list = new List<TRANGTHAI>();

            TRANGTHAI[] item = new TRANGTHAI[2]
            {
                new TRANGTHAI(false, "Chưa hoàn tất"),
                new TRANGTHAI(true, "Đã hoàn tất")
            };
            list.AddRange(item);
            return list;
        }

        public static List<TRANGTHAI> getListPhong()
        {
            List<TRANGTHAI> list = new List<TRANGTHAI>();

            TRANGTHAI[] item = new TRANGTHAI[2]
            {
                new TRANGTHAI(false, "Không còn trống"),
                new TRANGTHAI(true, "Còn trống")
            };
            list.AddRange(item);
            return list;
        }

       /* public static List<TRANGTHAI> GetValueChange(string valueT)
        {
            List<TRANGTHAI> list = new List<TRANGTHAI>();
            if (valueT == "true")
            {
                TRANGTHAI[] item = new TRANGTHAI[2]
                {
                     new TRANGTHAI(true, "Đã hoàn tất"),
                     new TRANGTHAI(true, "Đã hoàn tất")
                };
                list.AddRange(item);
            }
            if (valueT == "false")
            {
                TRANGTHAI[] item = new TRANGTHAI[2]
                {
                     new TRANGTHAI(false, "Chưa hoàn tất"),
                     new TRANGTHAI(true, "Đã hoàn tất")
                };
                list.AddRange(item);
            }
            return list;
        }*/
    }
}
