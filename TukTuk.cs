using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_Car_App_Factory
{
    public class TukTuk : IVehicle
    {
        public TukTuk()
        {

        }
        public void Drive()
        {
            Console.WriteLine($"You chose 3-wheeled Tuk-Tuk.");
        }
    }
}
