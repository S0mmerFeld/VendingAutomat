using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingAutomat
{
    internal class ProductSale
    {
        public int Id { get; set; }
        public Goods Goods { get; set; }
        public Sold? SoldId { get; set; }
        public int SellQuantity { get; set; }
    }
}
