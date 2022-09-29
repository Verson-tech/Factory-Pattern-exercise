using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_Car_App_Factory
{
    public class FiatCincoCento : IVehicle
    {
        public FiatCincoCento()
        {

        }
        public void Drive()
        {
            Console.WriteLine($"You chose 4-wheeled Fiat-500.");
        }
    }
}
