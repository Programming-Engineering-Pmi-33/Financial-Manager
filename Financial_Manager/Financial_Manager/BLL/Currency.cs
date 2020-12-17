using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Manager.BLL
{
    class Currency
    {
        int Code { get; }
        string LetterCode { set; get; }
        string Name { set; get; }
        char Sign { set; get; }

        public Currency(int code, string letterCode, string name, char sign)
        {
            Code = code;
            LetterCode = letterCode;
            Name = name;
            Sign = sign;
        }
    }
}
