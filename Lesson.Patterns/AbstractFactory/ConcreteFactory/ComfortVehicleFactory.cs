using Lesson.Patterns.AbstractFactory.Product;
using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns.AbstractFactory.ConcreteFactory
{
    class ComfortVehicleFactory : AbstractVehicleFactory
    {
        public override Vehicle.Engine GetEngine()
        {
            return new ComfortEngine();
        }

        public override Vehicle.Transmition GetTransmition()
        {
            return new ComfortTransmition();
        }

        public override Vehicle.Body GetBody()
        {
            return new ComfortBody();
        }
    }
}
