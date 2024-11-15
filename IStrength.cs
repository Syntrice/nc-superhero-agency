using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal interface IStrength
    {
        public int StrengthLevel { get; set; }

        public void Lift(string alias)
        {
            Console.WriteLine($"{alias} lifts with all their might!");
        }
    }
}
