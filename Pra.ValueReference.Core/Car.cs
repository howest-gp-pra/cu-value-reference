using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.ValueReference.Core
{
    public class Car
    {
        public Car(string model, CarType type, decimal currentSpeed)
        {
            Model = model;
            Type = type;
            Speed = currentSpeed;
        }

        public string Model { get; set; }
        public decimal Speed { get; set; }
        public Vector3d Position { get; set; }
        public CarType Type { get; set; }

        public override string ToString()
        {
            return $"{Model} driving at {Speed}";
        }
    }
}
