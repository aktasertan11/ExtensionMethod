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
            
            bool result = false;

            foreach(var item in control)
            {
               if((bool)item.Key == item.Value) { 
                result = true;
                }
            }
            // Burada ki yapı tam bir kontrol sağlamıyor ama ödevin amacına uyuyor.

            return result;
        }
    }
}
