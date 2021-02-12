using ShopsList.Business.Interfaces;
using ShopsList.Business.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopsList.Data.Repository
{
    public class ShopRepository : IShopRepository
    {
        private readonly ShopContext _context;

        public ShopRepository(ShopContext context)
        {
            _context = context;
        }

        public string GetShopInformationById(int id)
        {
            var shop = _context.Shops.FirstOrDefault(shop => shop.Id == id);
            var result = shop.Information;

            return result; 
        }

        public List<Shop> GetShops()
        {
            return _context.Shops.ToList();
        }
    }
}
