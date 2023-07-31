
using Moq;
using NUnit.Framework;
using ShopCore.Services;
using ShopDataAccess.Repository.IRepository;
using ShopDataModel.Model;
using ShopDataModel.Model.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShopCore
{
    [TestFixture]
    public class PhoneBookingServiceTests
    {
        private PhoneBooking _phoneBookingRequest;
        private List<PhoneList> _availablePhone;
        private Mock<IPhoneBookingRepository> _phonebookingRepoMock;
        private Mock<IPhoneListRepository> _phoneListRepoMock;
        private PhoneBookingService _booking;

        [SetUp]
        public void setup()
        {
            _phoneBookingRequest = new PhoneBooking
            {
                FirstName = "Maheswari",
                LastName = "Selvam",
                Email = "mahes.selvam97@gamil.com",
                AvailableDateForCollection = new DateTime(2023, 09, 10),
                PhoneId = new Guid("C3CBD403-F457-4DC0-971B-DE00B8FB41D3"),
                PhoneModel = "Iphone13promax",
                TypeofPayment = PaymentMethod.CashOnDelivery
            };

            _availablePhone = new List< PhoneList>
            {
                new PhoneList
                {
                Id = new Guid("c3cbd403-f457-4dc0-971b-de00b8fb41d3"),
                NumberOfStocks = 1,
                PhoneModel = "Iphone13promax",
                PhonePrice = 1300
                }
               
            };
          

            _phonebookingRepoMock = new Mock<IPhoneBookingRepository>();
            _phoneListRepoMock = new Mock<IPhoneListRepository>();

            _phoneListRepoMock.Setup(x => x.GetAll()).Returns(_availablePhone);

            _booking = new PhoneBookingService(_phonebookingRepoMock.Object,_phoneListRepoMock.Object);
        }

        [Test]
        public void GetAllBooking_CallingtheMethod_ShouldInvokeGetall()
        {
            _booking.GetAllBooking();
            _phonebookingRepoMock.Verify(x=>x.GetAll(),Times.Once);
        }

        [Test]
        public void PhoneBooking_StoreBooking_ReturnTheValue()
        {
            PhoneBooking? storeBooking = null;
            _phonebookingRepoMock.Setup(x => x.Book(It.IsAny<PhoneBooking>()))
                .Callback<PhoneBooking>(Booking =>
                {
                    storeBooking = Booking;
                });
            _booking.OrderPhone(_phoneBookingRequest);

            _phonebookingRepoMock.Verify(x => x.Book(It.IsAny<PhoneBooking>()), Times.Once);
            _phoneListRepoMock.Verify(x => x.update(It.IsAny<PhoneList>()), Times.Once);
            Assert.NotNull(storeBooking);
            Assert.AreEqual(_phoneBookingRequest.BookingId, storeBooking.BookingId);

        }

        [TestCase(true,ExpectedResult =BookingCode.Success)]
        [TestCase(false, ExpectedResult = BookingCode.NoPhoneAvailable)]
        public  BookingCode BookingCode_CheckStocks_Returncode(bool availablePhone)
        {
            if(!availablePhone)
            {
                _availablePhone.Clear();
            }
            return _booking.OrderPhone(_phoneBookingRequest).Code;
        }

        [Test]
        public void BookNotCalled_NoPhoneAvaliable_ShouldNotInvokePhoneBookig()
        {
            _availablePhone.Clear();
            _booking.OrderPhone(_phoneBookingRequest);
            _phonebookingRepoMock.Verify(x => x.Book(It.IsAny<PhoneBooking>()), Times.Never);
        }


    }
}
