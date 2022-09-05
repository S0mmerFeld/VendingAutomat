using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingAutomat
{
    internal class AutomatMachine
    {
        public int Id { get; set; }
        public int InventoryNum { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MaxProductCapacity { get; set; }
        public int CurrentProductNumber { get; set; }
        public List<Sold> Solds { get; set; }

    }
}
