using Lesson.Patterns.AbstractFactory.Product;
using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns.AbstractFactory.ConcreteFactory
{
    class SportVehicleFactory : AbstractVehicleFactory
    {
        public override Vehicle.Engine GetEngine()
        {
            return new SportEngine();
        }

        public override Vehicle.Transmition GetTransmition()
        {
            return new SportTransmition();
        }

        public override Vehicle.Body GetBody()
        {
            return new SportBody();
        }
    }
}
