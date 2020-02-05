using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emilie_Lindell_prov_Del2
{
    class Car
    {
        //CleanCar oskyldigBil = new CleanCar();
        //ContrabandCar SkyldigBil = new ContrabandCar(); 
        
        public int passengers;// för antalet passagerare
        public int contrabandAmount;//Hur mycket contraband som fanns i bilen
        public bool alreadyChecked = true;//För att säkerhetskolla om spelaren redan kollat på den bilen eller inte
        public Random generator = new Random();// för att slumpa hur många passagerare i bilarna och sedan om den innehåller contraband eller inte
        public List<string> Bilar = new List<string>();//Listan som håller antalet bilar som spelaren skriver in

        public override string ToString()
        {
            return base.ToString() +
                Bilar;
        }


        public bool examine(ContrabandCar, CleanCar)// för att undersöka den valda bilen och sedan return:a om bilen innehöll contraband eller inte
        {

            if (true)
            {
                return true;
                Console.WriteLine("Du hitta stöldgods i bilen!");

            }
            else
            {
                return false;
                Console.WriteLine("Inget hittades i denna bil!");

            }



        }




    }

