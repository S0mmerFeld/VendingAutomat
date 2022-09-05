using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingAutomat
{
    internal class DiscountCard : Card
    {
        public DiscountCard()
        {

        }
        public DiscountCard(int id, float discount, decimal purchase = 0)
        {
            Id = id;
            Discount = discount;
            PurchaseSum = purchase;
        }

        public DiscountCard(Card card, decimal purchase = 0)
            :this(card.Id, card.Discount, purchase)
        {
        }

        public decimal PurchaseSum { get; set; }

        public override string ToString()
        {
            return $"DiscountCardId {this.Id}\n" + $"Discount {this.Discount}\n" + $"PurchaseSum: {PurchaseSum}\n";
        }
    }
}
