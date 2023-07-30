using ShopCore.Services.IServices;
using ShopDataAccess.Repository.IRepository;
using ShopDataModel.Model;
using ShopDataModel.Model.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Services
{
    public class PhoneBookingService : IPhoneBookingService
    {
        private readonly IPhoneBookingRepository _phoneBookingRepository;

        public PhoneBookingService(IPhoneBookingRepository phoneBookingRepository)
        {
            _phoneBookingRepository = phoneBookingRepository;
           
        }
        public IEnumerable<PhoneBooking> GetAllBooking()
        {

            return _phoneBookingRepository.GetAll();
        }

        public BookingResult OrderPhone(PhoneBooking request)
        {
            if(request==null)
            throw new ArgumentNullException(nameof(request));

            BookingResult result = new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                DeliveryAddress = request.DeliveryAddress,
                AvailableDateForCollection = request.AvailableDateForCollection,
                TypeofPayment = request.TypeofPayment
            };

            List<Guid> reservedPhone=_phoneBookingRepository.GetAll().Where(x=>x.PhoneId==request.PhoneId).Select(x=>x.PhoneId).ToList();

            bool isAvaliable = !reservedPhone.Contains(request.PhoneId);
            if(isAvaliable)
            {
                _phoneBookingRepository.Book(request);
                result.BookingId= request.BookingId;
                result.Code = BookingCode.Success;
            }
            else
            {
                result.Code = BookingCode.NoPhoneAvailable;
            }

            return result; ;
        }
    }
}
