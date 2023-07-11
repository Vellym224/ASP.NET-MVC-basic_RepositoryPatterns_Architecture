using Microsoft.AspNetCore.Mvc;
using RecodsSystem.BusinessLogicLayer.AddressDetailRepository;

namespace RecordsSystem.Controllers.AddressDetailController
{
    public class AddressDetailController : Controller
    {
        public readonly IAddressDetailService _addressDetailService;
        public AddressDetailController(IAddressDetailService addressDetailService)
        {
            _addressDetailService = addressDetailService;
        }

        public async Task<IActionResult> Index()
        {
            var addressDetails = await _addressDetailService.GetAddressDetailsAsync();
            return View(addressDetails);
        }
    }
}
