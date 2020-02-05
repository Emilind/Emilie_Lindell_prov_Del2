using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emilie_Lindell_prov_Del2
{
    class CleanCar : Car
    {
        Car bil = new Car;
        public CleanCar()
        {
            passengers = generator.Next(1, 3);//Slumpat hur många passagerare det är i bilen
            contrabandAmount = 0;//Säger att det inte finns något contraband i bilen
             
        }
       
    }
}
