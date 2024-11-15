using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class RescueMission<MissionRequirements> : Mission<MissionRequirements>
    {
        public RescueMission(string location, int reward) : base(location, reward)
        {
        }

    }
}
