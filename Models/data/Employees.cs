using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models.data
{     [Table("Employees")]
    public class Employees
    {
        public int id { set; get; }
        public string name { set; get; }
        public string Email { set; get; }
         public string Phone { set; get; }
        public DateTime Bd { set; get; }
        [ForeignKey("contry")]
         public int country_id { set; get; }
        public string contry { set; get; }

        public Country countryobj { set; get; }

    }
}
