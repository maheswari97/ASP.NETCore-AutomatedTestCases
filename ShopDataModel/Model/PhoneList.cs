using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataModel.Model
{
    public class PhoneList
    {
        [Key]
        public Guid Id { get; set; }
        public string? PhoneModel { get; set; }
        public int PhonePrice { get; set; }
    }
}

