using ShopDataModel.Model;
using ShopDataModel.Model.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Services.IServices
{
    public interface IPhoneBookingService
    {
        BookingResult OrderPhone(PhoneBooking request);
        IEnumerable<PhoneBooking> GetAllBooking();

    }
}
