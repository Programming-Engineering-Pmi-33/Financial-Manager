using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Manager.BLL
{
    class CurrencyConverter
    {
        Currency From { set; get; }
        Currency To { set; get; }
        double Price { set; get; }

        public CurrencyConverter(Currency from, Currency to, double price)
        {
            From = from;
            To = to;
        }

        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
        }

        public double Convert(double amount)
        {
            return amount * Price;
        }
    }
}
