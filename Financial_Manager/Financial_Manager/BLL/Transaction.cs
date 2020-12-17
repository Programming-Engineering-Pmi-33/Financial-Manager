using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Manager.BLL
{
    class Transaction
    {
        int Id { get; }
        Category Category { set; get; }
        double Amount { set; get; }
        Currency Currency { set; get; }
        User User { set; get; }
        DateTime Date { set; get; }
        bool IsPlanned { set; get; }
        PaymentPeriod Period { set; get; }
        string Remark { set; get; }

        public Transaction(int id, Category category, double amount, Currency currency, User user, DateTime date, bool isPlanned, PaymentPeriod period = null, string remark = null)
        {
            Id = id;
            Category = category;
            Amount = amount;
            Currency = currency;
            User = user;
            Date = date;
            IsPlanned = isPlanned;
            Period = period;
            Remark = remark;
        }

    }
}
