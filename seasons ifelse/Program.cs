using System;

namespace seasons_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Ayı daxil edin: ");
                string a = Console.ReadLine();
                string b = "yanvar";
                string c = "fevral";
                string d = "mart";
                string e = "aprel";
                string f = "may";
                string g = "iyun";
                string h = "iyul";
                string j = "avqust";
                string k = "sentyabr";
                string l = "oktyabr";
                string m = "noyabr";
                string n = "dekabr";
                 if (a == b || a == c || a == n)
                {
                    Console.WriteLine($"{a} ayının daxil olduğu sezon: Qış");
                }
                else if (a == d || a == e || a == f)
                {
                    Console.WriteLine($"{a} ayının daxil olduğu sezon: Yaz");
                }
                else if (a == g || a == h || a == j)
                {
                    Console.WriteLine($"{a} ayının daxil olduğu sezon: Yay");
                }                
                else if (a == k || a == l || a == m)
                {
                    Console.WriteLine($"{a} ayının daxil olduğu sezon: Payız");
                }
                else
                {
                    Console.WriteLine($"{a} ay deyil");
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
