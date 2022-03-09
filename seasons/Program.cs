using System;

namespace seasons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Ayı daxil edin: ");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "yanvar":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Qış");
                        break;
                    case "fevral":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Qış");
                        break;
                    case "dekabr":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Qış");
                        break;
                    case "mart":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Yaz");
                        break;
                    case "aprel":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Yaz");
                        break;
                    case "may":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Yaz");
                        break;
                    case "iyun":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Yay");
                        break;
                    case "iyul":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Yay");
                        break;
                    case "avqust":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Yay");
                        break;
                    case "sentyabr":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Payız");
                        break;
                    case "oktyabr":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Payız");
                        break;
                    case "noyabr":
                        Console.WriteLine($"{a} ayının aid olduğu sezon: Payız");
                        break;
                    default:
                        Console.WriteLine($"{a} ay deyil");
                        break;

                }
            }
  
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
