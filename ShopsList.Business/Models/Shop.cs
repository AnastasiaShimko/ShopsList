using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsList.Business.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WorkingHours { get; set; }
        public string Information { get; set; }
    }
}
