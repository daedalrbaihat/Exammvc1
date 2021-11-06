using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models.data
{
    public class EmployeeService:IEmployee
    {
           ContextEmp context;
        public EmployeeService(ContextEmp _context)
        {
            context = _context;

        }



        public void AddEmp(Employees emp)
        {
            context.emp.Add(emp);
            context.SaveChanges();
        }

        public List<Employees> empli()
        {
            List<Employees> empli = context.emp.ToList();
            return empli;
        }


       public void Delet( int id)
        {
            Employees emp = context.emp.Find(id);
            context.emp.Remove(emp);
            context.SaveChanges();


        }
    }
}
