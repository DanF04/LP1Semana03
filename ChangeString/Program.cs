using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Type a phrase:");
            string ask = Console.ReadLine();
            Console.WriteLine("Type a character:");
            char ch = char.Parse(Console.ReadLine());

            
            foreach (char c in ask)
            {
                char x = c == ch ? 'x' : c;
                Console.Write(x);
            }


            
        }
    }
}
