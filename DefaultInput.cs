using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rent_a_Car_App_Factory
{
    public class DefaultInput : IVehicle
    {
        public DefaultInput()
        {

        }
        public void Drive()
        {
            Console.WriteLine($"Please, enter a number within the range of 2 and 4.");
        }
    }
}
