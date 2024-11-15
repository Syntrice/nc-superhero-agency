using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency 
{
    internal class CombatMission<MissionRequirements> : Mission<MissionRequirements>
    {
        public CombatMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
