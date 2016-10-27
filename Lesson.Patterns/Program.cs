using System;
using Lesson.Patterns.AbstractFactory;
using Lesson.Patterns.AbstractFactory.ConcreteFactory;
using Lesson.Patterns.Builder;
using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractVehicleFactory sportVehicle = new SportVehicleFactory();
            AbstractVehicleFactory cofortVehicle = new ComfortVehicleFactory();

            VehicleBuilder builder = new VehicleBuilder();
            builder.BuildBody(cofortVehicle);
            builder.BuildEngine(sportVehicle);
            builder.BuildTransmition(sportVehicle);

            Vehicle hybridVehicle = builder.Vehicle;

            Console.WriteLine(hybridVehicle);

            Console.ReadKey();
        }
    }
}
