using Microsoft.AspNetCore.Mvc;
using RecodsSystem.BusinessLogicLayer.EmployeeDetailRepository;

namespace RecordsSystem.Controllers.EmployeeDetailController
{
    public class EmployeeDetailController : Controller
    {
        public readonly IEmployeeDetailService _employeeDetailService;

        public EmployeeDetailController(IEmployeeDetailService employeeDetailService)
        {
            _employeeDetailService = employeeDetailService;
        }

        public async Task<IActionResult> Index()
        {
            var employeeDetails = await _employeeDetailService.GetEmployeeDetailsAsync();
            return View(employeeDetails);
        }
    }
}
