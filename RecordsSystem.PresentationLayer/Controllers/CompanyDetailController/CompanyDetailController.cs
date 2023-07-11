using Microsoft.AspNetCore.Mvc;
using RecodsSystem.BusinessLogicLayer.CompanyDetailRepository;

namespace RecordsSystem.Controllers.CompanyDetailController
{
    public class CompanyDetailController : Controller
    {
        public readonly ICompanyDetailService _companyDetailService;
        public CompanyDetailController(ICompanyDetailService companyDetailService)
        {
            _companyDetailService = companyDetailService;
        }

        public async Task<IActionResult> Index()
        {
            var companyDetails = await _companyDetailService.GetCompanyDetailsAsync();
            return View(companyDetails);
        }

        //Other CRUD OPORATIONS
    }
}
