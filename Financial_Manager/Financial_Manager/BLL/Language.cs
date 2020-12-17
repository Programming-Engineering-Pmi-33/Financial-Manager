using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Manager.BLL
{
    class Language
    {
        int Id { get; }
        string Name { set; get; }

        public Language(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
