using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns.AbstractFactory.Product
{
    internal class ComfortTransmition : Vehicle.Transmition
    {
        public ComfortTransmition()
        {
            Type = "Comfort";
        }
    }
}