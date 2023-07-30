using ShopDataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Services.IServices
{
    public interface IphoneListService
    {
        IEnumerable<PhoneList> GetAll();
    }
}
