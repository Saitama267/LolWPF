using LolWPF.Models;
using LolWPF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.View.ViewModel
{
    public class ViewModelProfile
    {
        public string SummonerName { get; private set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public string Tier { get; private set; }
        public string Rank { get; private set; }
        public string Emblem { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }

        public ViewModelProfile(SummonerDTO summoner,PositionDTO position)
        {
            SummonerName = summoner.Name;
            Icon = "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/profileicon/" + summoner.ProfileIconId + ".png";
            Level = summoner.SummonerLevel;
            Tier = position.Tier;
            Rank = position.Rank != null ? position.Rank : "UNRANKED";
            Wins = position.Wins;
            Losses = position.Losses;
            Emblem = "../../Assets/emblem/Emblem_" + (position.Tier != null ? position.Tier : "Unranked") + ".png";
        }
    }
}
