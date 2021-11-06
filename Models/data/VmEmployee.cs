using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models.data
{
    public class VmEmployee
    {
        public Employees emp { set; get; }
        public List<Employees> empli { set; get; }

        public List<Country> conli { set; get; }

    }
}
