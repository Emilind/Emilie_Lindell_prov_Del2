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
            Car Bil = new Car();
            Console.WriteLine("Hur många bilar vill du skapa?");
            string antalBilar = "";
            int bilar;
            bool lyckad = int.TryParse(antalBilar, out bilar);//För att konvertera stringen till en int för att sätta in den i en lista. 
            Bil.Bilar.Add(antalBilar);//För att få in numret i listan som ligger i klassen Car


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

            Console.WriteLine("Vilken bil vill du titta på? [");
            Console.ReadLine();
        }
    }
}
