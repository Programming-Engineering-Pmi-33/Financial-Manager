using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Manager
{
    public class CategorySummary : System.Collections.ObjectModel.Collection<PiePoint>
    {
        public CategorySummary()
        {
            Add(new PiePoint
            {
                Name = "Food",
                Share = 26
            });
            Add(new PiePoint
            {
                Name = "Clothes",
                Share = 36
            });
            Add(new PiePoint
            {
                Name = "Gifts",
                Share = 24
            });
            Add(new PiePoint
            {
                Name = "Transport",
                Share = 25
            });
            Add(new PiePoint
            {
                Name = "Books",
                Share = 27
            });

        }
    }
}
