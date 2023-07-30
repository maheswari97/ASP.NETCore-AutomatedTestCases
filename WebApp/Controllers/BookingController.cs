using Microsoft.AspNetCore.Mvc;
using ShopCore.Services.IServices;
using ShopDataModel.Model.VM;
using ShopDataModel.Model;

namespace WebApp.Controllers
{
    public class BookingController : Controller
    {
        private readonly IPhoneBookingService _phoneBookingService;
        private readonly IphoneListService _phoneListService;

        public BookingController(IPhoneBookingService phoneBookingService,
            IphoneListService phoneListService)
        {
            _phoneBookingService = phoneBookingService;
            _phoneListService = phoneListService;
        }
        public IActionResult Index()
        {
            return View(_phoneBookingService.GetAllBooking());
        }
        public IActionResult Book()
        {
            return View();
        }

        public IActionResult GetPhoneList()
        {

            return Ok(_phoneListService.GetAll());
        }

        [HttpPost]
        public IActionResult Book([Bind("FirstName,FirstName,Email,AvailableDateForCollection,TypeofPayment,PhoneId,BookingId")] PhoneBooking booking)
        {
            IActionResult actionResult = View("Book");

            if (ModelState.IsValid)
            {
                var result = _phoneBookingService.OrderPhone(booking);
                if (result.Code == BookingCode.Success)
                {
                    actionResult = RedirectToAction("BookingConfirmation", result);
                }
                else if (result.Code == BookingCode.NoPhoneAvailable)
                {
                    ViewData["Error"] = "No Stock available for selected Phone";
                }
            }

            return actionResult;
        }

        public IActionResult BookingConfirmation(BookingResult result)
        {
            return View(result);
        }
    }
}
