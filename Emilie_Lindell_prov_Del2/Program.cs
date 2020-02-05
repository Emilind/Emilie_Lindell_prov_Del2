using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emilie_Lindell_prov_Del2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många bilar vill du skapa?");
            string antalBilar = "";

        while( antalBilar.Any(char.IsLetter) == true)
            {
                antalBilar = Console.ReadLine();

                if(antalBilar.Any(char.IsLetter) == true)
                {
                    Console.WriteLine("Bara nummer inga bokstäver!");
                }
                else
                {
               
                }

            }
        }
    }
}
