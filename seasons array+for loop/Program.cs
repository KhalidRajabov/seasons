using System;

namespace seasons_array_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Ay daxil edin: ");
                string[] winter = { "dekabr", "yanvar", "fevral" };
                string[] spring = { "mart", "aprel", "may" };
                string[] summer = { "iyun", "iyul", "avqust" };
                string[] autumn = { "sentyabr", "oktyabr", "noyabr" };
                string a = Console.ReadLine();
                for (int i = 0; i < winter.Length; i++)
                {
                    if (a == winter[i])
                    {
                        Console.WriteLine($"{a} ayının daxil olduğu sezon: Qış");
                    }
                }
                for (int j = 0; j < spring.Length; j++)
                {
                    if (a == spring[j])
                    {
                        Console.WriteLine($"{a} ayının daxil olduğu sezon: Yaz");
                    }
                }
                for (int k = 0; k < summer.Length; k++)
                {
                    if (a == summer[k])
                    {
                        Console.WriteLine($"{a} ayının daxil olduğu sezon: Yay");
                    }
                }
                for (int l = 0; l < autumn.Length; l++)
                {
                    if (a == autumn[l])
                    {
                        Console.WriteLine($"{a} ayının daxil olduğu sezon: Payız");
                    }
                }
            }
     
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
