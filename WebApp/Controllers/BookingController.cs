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
        public IActionResult Book([FromForm] PhoneBooking booking)
        {
            IActionResult actionResult = View("Book");

            if (ModelState.IsValid)
            {
                var result = _phoneBookingService.OrderPhone(booking);

                //return Ok(result);
                if (result.Code == BookingCode.Success)
                {
                    return Ok(result);
                }
                else if (result.Code == BookingCode.NoPhoneAvailable)
                {
                    return BadRequest("No Stock available for selected Phone");
                }
            }

            var errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));
            return BadRequest(errors);
        }

        public IActionResult BookingConfirmation(BookingResult result)
        {
            return View(result);
        }
    }
}
