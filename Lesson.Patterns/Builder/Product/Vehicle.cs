namespace Lesson.Patterns.Builder.Product
{
    class Vehicle
    {
        public class Engine
        {
            public string Type { get; protected set; }
        }

        public class Transmition
        {
            public string Type { get; protected set; }
        }

        public class Body
        {
            public string Type { get; protected set; }
        }


        public Engine VehicleEngine { get; set; }
        public Transmition VehicleTransmition { get; set; }
        public Body VehicleBody { get; set; }

        public override string ToString()
        {
            return $"{VehicleBody.Type} body, {VehicleEngine.Type} engine, {VehicleTransmition.Type} transmition";
        }
    }
}
