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
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int ile = int.Parse(Console.ReadLine());
                string tekst = Console.ReadLine();
                string[] tekstTab = tekst.Split(' ');
                int wynik = 0;


                for (int j = 0; j < tekstTab.Length; j++)
                {
                    wynik = wynik + int.Parse(tekstTab[j]);


                }
                Console.WriteLine(wynik);
            }

        }
    }
}



