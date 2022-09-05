using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingAutomat
{
    internal class Sold
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public DateTime SellsDateTime { get; set; }
        public List<ProductSale> ProductSales { get; set; }
        public int? AutomatMachineId { get; set; }
    }
}
