using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());
            for (int i = 1; i <= D; i++)
            {
                string tekst = Console.ReadLine();
                string[] liczby = tekst.Split(' ');

                int podstawa = int.Parse(liczby[0]);
                podstawa = podstawa % 10;
                int wykladnik = int.Parse(liczby[1]);

                if (wykladnik > 0)
                {
                    if (wykladnik % 4 == 0)
                    {
                        wykladnik = 4;
                    }
                    else
                    {
                        wykladnik = wykladnik % 4;
                    }
                    double wynik;
                    wynik = Math.Pow(podstawa, wykladnik);
                    if (wynik > 10)
                    {
                        Console.WriteLine(wynik % 10);
                    }
                    else
                    {
                        Console.WriteLine(wynik);
                    }

                }
                else
                {
                    Console.WriteLine(1);
                }



            }
        }
    }
}
