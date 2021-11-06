using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam2.Models.data;
using Microsoft.AspNetCore.Mvc;

namespace Exam2.Controllers
{
    public class EmployeeController : Controller
    {
        ContextEmp context;
        EmployeeService employeeService;
        CountryService countryService;
        public EmployeeController(ContextEmp _context ,EmployeeService _employeeService, CountryService _countryService)
        {
            context = _context;
            employeeService = _employeeService;
            countryService = _countryService;


        }
        public IActionResult Open()
        { VmEmployee vm = new VmEmployee();
            List<Country> cli = countryService.cnli();
            List<Employees> empli = employeeService.empli();
            vm.conli = cli;
            vm.empli = empli;



            return View("NewEmployee",vm);
        }

        public IActionResult ADDEmplo(VmEmployee vm)
        { 
            employeeService.AddEmp(vm.emp);
            List<Country> cli = countryService.cnli();
            List<Employees> empli = employeeService.empli();
            vm.conli = cli;
            vm.empli = empli;
            return View("NewEmployee", vm);
        }

        public IActionResult Delet( int id)
        {
            employeeService.Delet(id);
            VmEmployee vm = new VmEmployee();
            List<Country> cli = countryService.cnli();
            List<Employees> empli = employeeService.empli();
            vm.conli = cli;
            vm.empli = empli;
            return View("NewEmployee", vm);

        }
    }
}
