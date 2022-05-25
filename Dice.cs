using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра началась...нажимайте пробел для броска");
            Random r = new Random();
            while (true)
            {
                Console.WriteLine("Ваши выпавшие кубики ");
                int kub = r.Next(1, 7);
                int kob = r.Next(1, 7);

                Console.WriteLine($"{kub} {kob}");
                Console.ReadKey();
            }
        
        }
    }
}
