using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_WPF_DataBinding
{
    public class Employee
    {
        private long id;
        private string fullname;
        private Division division;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        public Division DivisionName
        {
            get { return division; }
            set { division = value; }
        }
    }
}
