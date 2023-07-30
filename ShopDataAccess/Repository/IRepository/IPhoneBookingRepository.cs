using ShopDataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataAccess.Repository.IRepository
{
    public interface IPhoneBookingRepository
    {
        void Book(PhoneBooking booking);
        IEnumerable<PhoneBooking> GetAll();
    }
}
