using ShopCore.Services.IServices;
using ShopDataAccess.Repository.IRepository;
using ShopDataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Services
{
    public class PhoneListService:IphoneListService
    {
        private readonly IPhoneListRepository _phoneListRepository;

        public PhoneListService(IPhoneListRepository phoneListRepository)
        {
           
            _phoneListRepository = phoneListRepository;
        }

        public IEnumerable<PhoneList> GetAll()
        {
            return _phoneListRepository.GetAll();
        }
    }
}
