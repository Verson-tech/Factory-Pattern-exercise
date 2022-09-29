using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_Car_App_Factory
{
    public class HarleyDavidson : IVehicle
    {
        public HarleyDavidson()
        {

        }
        public void Drive()
        {
            Console.WriteLine($"You chose 2-wheeled Harley-Davidson.");
        }
    }
}
