using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameData
{
    public enum CloudTeam
    {
        Dragon,
        Panda,
        Raven,
        Cat,
        Unicorn,
        Wombat,
        Elephant,
        Nye
    }

    public static class CloudTeamConverter
    {
        // Where the 0 index item of the value is the primary conversion.
        public static readonly IReadOnlyDictionary<CloudTeam, string[]> StringValues = new Dictionary<CloudTeam, string[]>
        {
            { CloudTeam.Dragon, new string[] {"D", "Dragon"} },
            { CloudTeam.Panda, new string[] {"P", "Panda"} },
            { CloudTeam.Raven, new string[] {"R", "Raven"} },
            { CloudTeam.Cat, new string[] {"C", "Cat"} },
            { CloudTeam.Unicorn, new string[] {"U", "Unicorn"} },
            { CloudTeam.Wombat, new string[] {"W", "Wombat"} },
            { CloudTeam.Elephant, new string[] {"E", "Elephant"} },
            { CloudTeam.Nye, new string[] {"N", "Nye"} },
        };

        public static string? GetLongString(this CloudTeam team)
            => StringValues.TryGetValue(team, out var vals) ? vals[1] : null;

        public static string? GetShortString(this CloudTeam team)
            => StringValues.TryGetValue(team, out var vals) ? vals[0] : null;

        public static bool TryParse(string value, out CloudTeam? team)
        {
            foreach(var item in StringValues)
            {
                foreach(var val in item.Value)
                {
                    if(val.Equals(value, StringComparison.OrdinalIgnoreCase))
                    {
                        team = item.Key;
                        return true;
                    }
                }
            }

            team = null;
            return false;
        }
    }
}
