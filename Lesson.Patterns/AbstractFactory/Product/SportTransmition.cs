﻿using Lesson.Patterns.Builder.Product;

namespace Lesson.Patterns.AbstractFactory.Product
{
    internal class SportTransmition : Vehicle.Transmition
    {
        public SportTransmition()
        {
            Type = "Sport";
        }
    }
}