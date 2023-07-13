using Microsoft.AspNetCore.Mvc;
using RecodsSystem.BusinessLogicLayer.RecUserDetailRepository;

namespace RecordsSystem.Controllers.RecUserDetailController
{
    public class RecUserDetailController : Controller
    {
        private readonly IRecUserDetailService _recUserDetailService;
        public RecUserDetailController(IRecUserDetailService recUserDetailService)
        {
            _recUserDetailService = recUserDetailService;
        }

        public async Task<IActionResult> Index()
        {
            var recUserDetails = await _recUserDetailService.GetRecUserDetailsAsync();
            return View(recUserDetails);
        }

        // Other CRUD OPERATIONS

    }
}
