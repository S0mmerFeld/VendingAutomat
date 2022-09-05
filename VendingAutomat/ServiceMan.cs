using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingAutomat
{
    internal class ServiceMan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ServiceCard SMCard { get; set; }



        public override string ToString()
        {
            return $"ServiceManId {Id}\n" + $"Name {Name}\n" + $"Surname {Surname}\n" + $"SMCard {SMCard.ToString()}\n";
        }
    }
}
