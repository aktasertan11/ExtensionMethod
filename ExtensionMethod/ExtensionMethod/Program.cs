using System;
using System.Collections.Generic;
using TFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IDictionary<string, object>>;


namespace ExtensionMethod
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //şifremiz
            string pass = "Test";
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

            var result = pass.IsValidPassword(mapping);
            Console.WriteLine(result);
        }

        
    }
    
}
