using Microsoft.AspNetCore.Mvc;
using ShopCore.Services.IServices;

namespace WebApp.Controllers
{
    public class PhoneListController : Controller
    {
        private readonly IphoneListService _phoneListService;

        public PhoneListController(IphoneListService phoneListService)
        {
            _phoneListService = phoneListService;
        }
        public IActionResult Index()
        {
            return View(_phoneListService.GetAll());
        }
    }
}
