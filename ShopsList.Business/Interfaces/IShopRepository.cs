using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsList.Business.Models;

namespace ShopsList.Business.Interfaces
{
    public interface IShopRepository
    {
        public List<Shop> GetShops();
        public string GetShopInformationById(int id);
    }
}
