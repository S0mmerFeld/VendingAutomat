using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingAutomat
{
    internal class Goods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

        public override string ToString()
        {
            return $"Goods Id = {Id} \n" + $" Name: {Name} \n" + $"Description: {Description} \n" + $"ShortDesctiption {ShortDescription}";  
        }

    }
}
