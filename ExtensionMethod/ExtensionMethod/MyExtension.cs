using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class MyExtension
    {
        public static bool IsValidPassword(this string str, List<KeyValuePair<object, bool>> control)
        {
            
            bool result = true;
            bool tempResult;

            foreach(var item in control)
            {
               if((bool)item.Key == item.Value) { 
                tempResult = true;
                }
                else
                {
                    tempResult = false;
                }
                result = result && tempResult;
            }
            

            return result;
        }
    }
}
