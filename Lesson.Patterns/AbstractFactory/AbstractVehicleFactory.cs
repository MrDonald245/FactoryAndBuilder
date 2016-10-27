using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns.AbstractFactory
{
    abstract class AbstractVehicleFactory
    {
        public abstract Vehicle.Engine GetEngine();
        public abstract Vehicle.Transmition GetTransmition();
        public abstract Vehicle.Body GetBody();
    }
}
