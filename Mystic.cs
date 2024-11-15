using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class Mystic : Superhero, IFly, ITelepathy
    {
        public Mystic(string alias, string secretIdentity, int age, Alignment alignment) : base(alias, secretIdentity, age, alignment)
        {
        }

        public double FlightSpeed { get; set; }
        public double MaxHeight { get; set; }
        public int PowerLevel { get; set; }
    }
}
