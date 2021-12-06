//Possible steps:
//DONE - Create an Interface named IVehicle that has a stubbed out public void Drive method
//DONE - Create 2 new public classes that will conform to IVehicle
//DONE - Example) Car, Motorcycle,  BigRig
//DONE - These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)
//DONE - Now we will make our static VehicleFactory class
//DONE - It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
//Call this functionality in the Main method
using FactoryPattern;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var getVehicle = VehicleFactory.GetVehicle();

            getVehicle.Drive();
        }
    }
}