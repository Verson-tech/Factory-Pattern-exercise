using Rent_a_Car_App_Factory;



int userInput;
bool input = false;

do
{
    Console.WriteLine("Welcome to Barceloneta-Rent-a-Vehicle Company.\n\nHow many wheels are you looking for today?\n\nEnter a number to see what we can offer:__");
    input = int.TryParse(Console.ReadLine(), out userInput);
} while (input == false);

var vehicle = VehicleFactory.GetVehicle(userInput);
vehicle.Drive();



//do
//{
//    console.writeline("welcome to barceloneta-rent-a-vehicle.\nhow many wheels are you looking for today?\nenter a number to see what we can offer:__");
//    int userinput = int32.parse(console.readline());


//    if (userinput >= 2 && userinput <= 4)
//    {
//        bool input = false;
//        do
//        {
//            input = int.tryparse(console.readline(), out userinput);
//        }
//    }
//    else
//    {
//        console.writeline("***********");
//    }

//} while (true);








//using System;


//    namespace Rent_a_Car_App_Factory
//{ 
//        class Program { 
//        static void Main(string[] args) { 


//--------------------
//Console.WriteLine("Welcome to Barceloneta-Rent-a-Vehicle.\nHow many wheels are you looking for today?\nEnter a number to see what we can offer:__");
//int userInput;
//    var wheelCount = int.Parse(Console.ReadLine(), out userInput);
//----------------------



//        }
//    }

//}