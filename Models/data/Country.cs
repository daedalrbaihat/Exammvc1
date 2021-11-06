using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models.data
{
    public class Country
    { public int id { set; get; }

        public string Name { set; get; }
         
     public List<Employees> employees { set; get; }
        
    }
}
