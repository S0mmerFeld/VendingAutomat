using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingAutomat
{
    internal class ProductSale
    {
        public int Id { get; set; }
        public Goods Goods { get; set; }
        public int? SoldId { get; set; }
        public int SellQuantity { get; set; }

        public override string ToString()
        {
            return $"ProductSaleId {Id}\n" + $"Goods: {Goods.ToString()}\n" + $"SoldId {SoldId}\n" + $"SellQuantity {SellQuantity}\n ";
        }
    }
}
