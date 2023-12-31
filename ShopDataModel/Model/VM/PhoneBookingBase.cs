﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataModel.Model.VM
{
    public class PhoneBookingBase
    {
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string? Email { get; set; }

        
        [StringLength(1000)]
        public string? DeliveryAddress { get; set; }

        [Required]
        public PaymentMethod TypeofPayment { get; set; }
       
        public DateTime AvailableDateForCollection { get; set; }
    }
}
