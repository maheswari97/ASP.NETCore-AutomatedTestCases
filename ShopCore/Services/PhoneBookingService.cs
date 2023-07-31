using ShopCore.Services.IServices;
using ShopDataAccess.Repository;
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
        private readonly IPhoneListRepository _phoneListRepository;

        public PhoneBookingService(IPhoneBookingRepository phoneBookingRepository, 
                                   IPhoneListRepository phoneListRepository)
        {
            _phoneBookingRepository = phoneBookingRepository;
            _phoneListRepository = phoneListRepository;
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

            PhoneList? stockAvaiable=_phoneListRepository.GetAll().Where(x=>x.Id==request.PhoneId && x.NumberOfStocks!=0).FirstOrDefault();
         
            if(stockAvaiable!=null)
            {
                stockAvaiable.NumberOfStocks = stockAvaiable.NumberOfStocks - 1;
                _phoneListRepository.update(stockAvaiable);

                request.PhoneModel=stockAvaiable.PhoneModel;
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
