using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emilie_Lindell_prov_Del2
{
    class ContrabandCar : Car
    {
        public ContrabandCar()
        {
            passengers = generator.Next(1, 4);//Slumpar antalet passagerare i bilen
            contrabandAmount = generator.Next(1, 4);//Slumpar värdet på contrabandet i bilen

        }
    }
}
