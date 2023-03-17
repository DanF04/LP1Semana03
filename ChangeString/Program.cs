using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something: ");
            string phrase = Console.ReadLine();
            Console.WriteLine("Write a letter: ");
            string character = Console.ReadLine();
            string[] z = new string[] { character };
            
            foreach ( var c in z)
            {
                phrase = phrase.Replace(c, string.Empty);
            }
            Console.WriteLine("Result: " + phrase);


        }
    }
}
