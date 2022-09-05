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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("AutomatMachineId:{0}\n InventoryNum:{1}\n Name:{2}\n Address:{3}\n MaxProductCapacity:{4}\n CurrentProductNumber:{5}\n ",
                                            Id, InventoryNum, Name, Address, MaxProductCapacity, CurrentProductNumber);
            foreach (Sold s in Solds)
            {
                sb.AppendFormat(s.ToString(), s);
            }
            return sb.ToString();
        }

    }
}
