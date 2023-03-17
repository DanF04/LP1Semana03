using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "This is a string!";
            Console.WriteLine(x);
            string y = "i";
            Console.WriteLine(y);
            string[] z = new string[] { "i" };
            
            foreach ( var c in z)
            {
                x = x.Replace(c, string.Empty);
            }
            Console.WriteLine(x);


        }
    }
}
