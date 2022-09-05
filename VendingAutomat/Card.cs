using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingAutomat
{
    internal class Card
    {
        public int Id { get; set; }

        private float _discount;
        public float Discount
        {
            get { return _discount / 100; }
            set
            {
                if (value < 0 || value > 50)
                    throw new ArgumentOutOfRangeException(nameof(value),
                          "The valid range is between 0 and 50.");

                _discount = value;
            }
        }

        public override string ToString()
        {
            return $"Card Id = {Id} \n" + $"Discount: {Discount} \n";
        }
    }
}
