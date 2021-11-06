using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models.data
{    
    public class CountryService:ICountry
    {
        ContextEmp context;
        public CountryService(ContextEmp _context)
        {
            context = _context;

        }
        public List<Country> cnli()
        {
            List<Country> cli = context.countries.ToList();
            return cli;

        }


    }
}
