using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_Car_App_Factory
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int userInput)
        {
            switch (userInput)
            {
                case 2:
                    return new HarleyDavidson(); 
                case 3:
                    return new TukTuk();
                case 4:
                    return new FiatCincoCento();
                default:
                    return new DefaultInput();

            }

        }
    }
}
