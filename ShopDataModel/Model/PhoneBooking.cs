
using ShopDataModel.Model.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataModel.Model
{
    public class PhoneBooking:PhoneBookingBase
    {
        [Key]
        public Guid BookingId { get; set; }
        public Guid PhoneId { get; set; }

        public string? PhoneModel { get; set; }
    }
}
