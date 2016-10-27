using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns.AbstractFactory.Product
{
    internal class ComfortEngine : Vehicle.Engine
    {
        public ComfortEngine()
        {
            Type = "Comfort";
        }
    }
}