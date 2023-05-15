using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.Models
{
    public class ChampionInfo
    {
        public int MaxNewPlayerLevel { get; set; }
        public List<int> FreeChampionIdsForNewPlayers { get; set; }
        public List<int> freeChampionIds { get; set; }

    }
}
