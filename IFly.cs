using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal interface IFly
    {
        public double FlightSpeed { get; set; }
        public double MaxHeight { get; set; }

        public void Fly(string alias)
        {
            Console.WriteLine($"{alias} swoops by look at them go!");
        }
    }
}
