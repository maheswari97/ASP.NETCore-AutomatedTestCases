using ShopDataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataAccess.Repository.IRepository
{
    public interface IPhoneListRepository
    {
        IEnumerable<PhoneList> GetAll();
        void update(PhoneList phone);

    }
}
