using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class HackingMission<MissionRequirements> : Mission<MissionRequirements> where MissionRequirements : ITech
    {
        public HackingMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
