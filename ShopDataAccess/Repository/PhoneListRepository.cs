using ShopDataAccess.Repository.IRepository;
using ShopDataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataAccess.Repository
{
    public class PhoneListRepository : IPhoneListRepository
    {
        private readonly ApplicationDbContext _context;

        public PhoneListRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PhoneList> GetAll()
        {
            return _context.PhoneLists.ToList();
        }
    }
}
