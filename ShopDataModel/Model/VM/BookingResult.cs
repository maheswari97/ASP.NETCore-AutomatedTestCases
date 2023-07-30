using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataModel.Model.VM
{
    public class BookingResult:PhoneBookingBase
    {

        public Guid BookingId { get; set; }

        public BookingCode Code { get; set; }
    }
}
