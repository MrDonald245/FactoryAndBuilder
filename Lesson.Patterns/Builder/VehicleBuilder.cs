using Lesson.Patterns.AbstractFactory;
using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns.Builder
{
    class VehicleBuilder
    {
        public Vehicle Vehicle { get; } = new Vehicle();

        public void BuildEngine(AbstractVehicleFactory factory)
        {
            Vehicle.VehicleEngine = factory.GetEngine();
        }

        public void BuildTransmition(AbstractVehicleFactory factory)
        {
            Vehicle.VehicleTransmition = factory.GetTransmition();
        }

        public void BuildBody(AbstractVehicleFactory factory)
        {
            Vehicle.VehicleBody = factory.GetBody();
        }
    }
}
