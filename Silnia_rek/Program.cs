using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia_rek
{
    internal class Program
    {
        private static int Silnia (int c)
        {

            return c == 0 ? 1 : c * Silnia(c-1);
            /*
            if (c == 0)
            {
                return 1;
            }
            else
            {
                return c* Silnia(c - 1);
            }
            */
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Program liczy silnie");
            Console.WriteLine("Podaj liczbę");


            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Wynik silni wynosi: " + Silnia(s));
            Console.ReadKey();  
        }
    }
}
