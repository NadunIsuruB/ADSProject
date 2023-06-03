using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSCodes
{
    public static class StringValidate
    {
        //string validation
        public static Boolean IsUppercase(string s)
        {
            return s.All(char.IsUpper);
        }

        public static Boolean IsPasswordComplex(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }
    }
}
