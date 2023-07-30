using ShopDataAccess.Repository.IRepository;
using ShopDataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataAccess.Repository
{
    public class PhoneBookingRepository : IPhoneBookingRepository
    {
        private readonly ApplicationDbContext _context;

        public PhoneBookingRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public void Book(PhoneBooking booking)
        {
            _context.PhoneBookings.Add(booking);
            _context.SaveChanges();
        }

        public IEnumerable<PhoneBooking> GetAll()
        {
            return _context.PhoneBookings.ToList();
        }
    }
}
