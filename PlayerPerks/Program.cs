using System;

namespace PlayerPerks
{
    class Program
    {
        [Flags]
        enum Perks
        {
            WaterBreathing = 1 << 0,
            AutoHeal = 1 << 1,
            Stealth = 1 << 2,
            DoubleJump = 1 << 3
        }
    
        public static int Count(string input, string substr)
        {
            return System.Text.RegularExpressions.Regex.Matches(input, substr).Count;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Write a combination of the letters (w a s d): ");
            string wasd = Console.ReadLine();
            Perks playerperks = Perks.WaterBreathing | Perks.AutoHeal | Perks.Stealth | Perks.DoubleJump;
            int[] cnt = new int[4];
            int i = 0;
            foreach (Perks perk in Enum.GetValues(typeof(Perks))) {
                cnt[i] = Count(wasd, "wasd".Substring(i,1));
                if ((cnt[i] % 2 == 0 && cnt[i] > 1) || (cnt[i] == 0))
                {
                    playerperks &= ~perk;
                }
                i++;
            }

            if (cnt[0] + cnt[1] + cnt[2] + cnt[3] < wasd.Length)
            {
                Console.WriteLine("Unknown perk!");
                return;
            }
            else if (cnt[0] + cnt[1] + cnt[2] + cnt[3] == 0)
            {
                Console.WriteLine("No perks at all!");
            }
            else
            {
                Console.WriteLine(playerperks);
            }
            if((playerperks & Perks.Stealth) == Perks.Stealth && (playerperks & Perks.DoubleJump) == Perks.DoubleJump)
            //"other way to do" ---->   if ((cnt[2] > 0 && cnt[2] % 2 != 0) && (cnt[3] > 0 && cnt[3] % 2 != 0))
            {
                Console.WriteLine("Silent jumper!");
            }
            if((playerperks & Perks.AutoHeal)!= Perks.AutoHeal)
            //"other way to do" ---->   if ((cnt[1] % 2 == 0 && cnt[1] > 1) || (cnt[1] == 0))
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
