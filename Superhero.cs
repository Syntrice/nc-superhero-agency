using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal abstract class Superhero
    {
        public string Alias { get; }
        public string SecretIdentity { get; }
        public int Age { get; }
        public Alignment Alignment { get; }

        protected Superhero(string alias, string secretIdentity, int age, Alignment alignment)
        {
            Alias = alias;
            SecretIdentity = secretIdentity;
            Age = age;
            Alignment = alignment;
        }
    }

    public enum Alignment
    {
        GOOD,
        EVIL
    }
}
