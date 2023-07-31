using Moq;
using NUnit.Framework;
using ShopCore.Services;
using ShopDataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore
{
    [TestFixture]
    public class PhoneListServiceTests
    {
        private Mock<IPhoneListRepository> _phoneListRepoMock;
        private PhoneListService _phoneListService;

        [SetUp]
        public void setup()
        {
            _phoneListRepoMock = new Mock<IPhoneListRepository>();
            _phoneListService=new PhoneListService(_phoneListRepoMock.Object);
        }

        [Test]
        public void GetAllPhone_Ivoke_CheckIfGetAllPhoneListIsInvoked()
        {
            _phoneListService.GetAll();
            _phoneListRepoMock.Verify(x=>x.GetAll(),Times.Once());
        }
    }
}
