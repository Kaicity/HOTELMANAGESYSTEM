using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public  class LOCDONGIA
    {
        public bool _value { get; set; }
        public string _display { get; set; }

        public LOCDONGIA() { }

        public LOCDONGIA(bool val, string dis)
        {
            _value = val;
            _display = dis;
        }

        public static List<LOCDONGIA> getList() 
        {
            List<LOCDONGIA> listDG = new List<LOCDONGIA>();

            LOCDONGIA[] item = new LOCDONGIA[2]
            {
                new LOCDONGIA(true, "Từ thấp đến cao"),
                new LOCDONGIA(false, "Từ cao đến thấp")
            };
            listDG.AddRange(item);

            return listDG;
        }
    }
}
