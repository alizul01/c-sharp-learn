using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Vechile
    {
        public string color;
    }
    internal class Car : Vechile
    {
        public string model;
        public Car(string color, string model)
        {
            this.color = color;
            this.model = model;
        }
    }
    internal class Motor
    {
        public string model { get; set; }
        public string color { get; set; }

        public Motor(string color, string model)
        {
            this.color = color;
            this.model = model;
        }
    }

    enum Planet
    {
        Mercury,
        Pluto,
        Earth
    }
}
