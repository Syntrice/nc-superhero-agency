using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class Gadgeteer : Superhero, ITech, IStrength
    {
        public Gadgeteer(string alias, string secretIdentity, int age, Alignment alignment) : base(alias, secretIdentity, age, alignment)
        {
        }

        public string Gadget { get; set; }
        public int StrengthLevel { get; set; }
    }
}
