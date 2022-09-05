using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingAutomat
{
    internal class ServiceCard : Card
    {
        public ServiceCard()
        {

        }
        public ServiceCard(int id, int discount)
        {
            Id = id;
            Discount = discount;
        }

        public ServiceCard(Card card)
        {
            Id = card.Id;
            Discount = card.Discount;
        }


        public override string ToString()
        {
            return $"ServiceCardId {this.Id}\n" + $"Discount {this.Discount}\n";
        }
    }
}
