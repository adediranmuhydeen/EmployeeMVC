
using EmplohyeeAppMvc.Data;
using EmplohyeeAppMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmplohyeeAppMvc.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployee)
        {
            var employee = new Employee()
            {
                FirstName = addEmployee.FirstName,
                MiddleName = addEmployee.MiddleName,
                LastName = addEmployee.LastName,
                Title = addEmployee.Title,
                Email = addEmployee.Email,
                PhoneNumber = addEmployee.PhoneNumber
            };
            await _context.employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
