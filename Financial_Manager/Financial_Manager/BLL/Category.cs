using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Manager.BLL
{
    class Category
    {
        int Id { get; }
        string Name { get; set; }
        bool IsSpending { get; set; }
        byte[] Icon { get; set; }

        public Category(int id, string name, bool isSpending, byte[] icon = null)
        {
            Id = id;
            Name = name;
            IsSpending = isSpending;
            Icon = icon;
        }
    }
}
