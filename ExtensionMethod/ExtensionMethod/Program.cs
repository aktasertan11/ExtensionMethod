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
            

            var result = pass.createList();
            Console.WriteLine(result);
        }

        
    }
    
}
