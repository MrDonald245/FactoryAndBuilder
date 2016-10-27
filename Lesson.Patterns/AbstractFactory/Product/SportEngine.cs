using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns.AbstractFactory.Product
{
    internal class SportEngine : Vehicle.Engine
    {
        public SportEngine()
        {
            Type = "Sport";
        }
    }
}