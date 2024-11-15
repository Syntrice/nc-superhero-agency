using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal abstract class Mission<MissionRequirements>
    {
        public string Location { get; private set; }
        public int Reward { get; private set; }
        public List<MissionRequirements> HeroesDeployed { get; }

        protected Mission(string location, int reward)
        {
            Location = location;
            Reward = reward;
            HeroesDeployed = new List<MissionRequirements>();
        }
    }
}
