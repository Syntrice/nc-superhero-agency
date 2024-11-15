using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class ReconMission<MissionRequirements> : Mission<MissionRequirements> where MissionRequirements : IFly
    {
        public ReconMission(string location, int reward) : base(location, reward)
        {

        }
    }
}
