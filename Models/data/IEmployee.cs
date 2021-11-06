using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models.data
{
    public interface IEmployee
    {
        public void AddEmp(Employees emp);
        public List<Employees> empli();
        public void Delet(int id);
    }
}
