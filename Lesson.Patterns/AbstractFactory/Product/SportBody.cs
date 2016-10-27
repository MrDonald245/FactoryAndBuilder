using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns.AbstractFactory.Product
{
    internal class SportBody : Vehicle.Body
    {
        public SportBody()
        {
            Type = "Sport";
        }
    }
}