using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtensionMethod
{
    public abstract class Methods
    {
       public static bool IsDigit(string str)
        {
            bool result = str.Any(char.IsDigit);
            return result;
        }
        public static bool IsUpper(string str)
        {
            bool result = str.Any(char.IsUpper);
            return result;
        }
        public static bool IsSymbol(string str)
        {
            bool result = str.Any(char.IsSymbol);
            return result;
        }


    }
}
