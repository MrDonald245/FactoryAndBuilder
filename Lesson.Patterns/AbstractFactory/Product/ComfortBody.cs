using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns.AbstractFactory.Product
{
    internal class ComfortBody : Vehicle.Body
    {
        public ComfortBody()
        {
            Type = "Comfort";
        }
    }
}