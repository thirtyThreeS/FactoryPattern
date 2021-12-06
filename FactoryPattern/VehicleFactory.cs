using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern;


    public class VehicleFactory
    {
        public static IVehicle GetVehicle()
        {
            Console.Write("How many tires do you wish your new vehicle to have? (Pick 2 or 4): ");
           
            var tires = Console.ReadLine();

            switch (tires)
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Truck();
                default:
                    return new Truck();
            }
        }
    }

