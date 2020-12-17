using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Manager.BLL
{
    class PaymentPeriod
    {
        
        int Id { get; }
        string Name { set; get; }
        int NumberOfDays { set; get; }

        public PaymentPeriod(int id, string name, int numberOfDays)
        {
            Id = id;
            Name = name;
            NumberOfDays = numberOfDays;
        }

    }
}
