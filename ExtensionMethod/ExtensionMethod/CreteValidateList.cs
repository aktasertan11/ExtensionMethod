using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class CreteValidateList
    {
        
        public static bool createList(this string pass)
        {
            // Daha sonra validasyon için kulladığımız fonsiyonlarımız
            object func1 = Methods.IsDigit(pass);
            object func2 = Methods.IsUpper(pass);
            //object func3 = Methods.IsSymbol(pass);

            // fonksiyonlarımız ve bizim isteğimiz sonuçlarını Dictionary e yüklüyoruz mesele {func1 , true} yazarsak Numara olsun mu "Evet demiş oluyoruz"
            List<KeyValuePair<object, bool>> mapping = new List<KeyValuePair<object, bool>>()
            {
                new KeyValuePair<object, bool>(func1 , false ),
                new KeyValuePair<object, bool>(func2 , true ),
                //new KeyValuePair<object, bool>(func2 , false )

            };

            var result = MyExtension.IsValidPassword(mapping);


            return result;


        }

        
    }
}
