using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_WPF_DataBinding
{
    public class Division
    {
        private long id;
        private string divisionName;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public string DivisionName
        {
            get { return divisionName; }
            set { divisionName = value; }
        }
    }
}
