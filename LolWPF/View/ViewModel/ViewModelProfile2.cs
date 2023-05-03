using LolWPF.Models;
using LolWPF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.View.ViewModel
{
    class ViewModelProfile2
    {
        public string SummonerName { get; private set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public string Tier { get; private set; }
        public string Rank { get; private set; }
        public string Emblem { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public string GameType { get; set; }
        public string Result { get; set; }
        public string ChampIcon { get; set; }
        public int ChampLevel { get; set; }
        public int GmKills { get; set; }
        public int GmDeaths { get; set; }
        public int GmAssists { get; set; }
        public string GmItem0 { get; set; }
        public string GmItem1 { get; set; }
        public string GmItem2 { get; set; }
        public string GmItem3 { get; set; }
        public string GmItem4 { get; set; }
        public string GmItem5 { get; set; }
        public string GmItem6 { get; set; }
        public string GmSummoner1 { get; set; }
        public string GmSummoner2 { get; set; }
        public int GmCS { get; set; }


        public ViewModelProfile2(SummonerDTO summoner,PositionDTO position, string gameType, ParticipantDto participantDto)
        {
            SummonerName = summoner.Name;
            Icon = "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/profileicon/" + summoner.ProfileIconId + ".png";
            Level = summoner.SummonerLevel;
            Tier = position.Tier;
            Rank = position.Rank;
            Wins = position.Wins;
            Losses = position.Losses;
            Emblem = "../../Assets/emblem/Emblem_" + position.Tier + ".png";
            GameType = gameType;
            Result = participantDto.Win == true?"WIN" : "LOSE";
            ChampIcon = "http://ddragon.leagueoflegends.com/cdn/13.9.1/img/champion/"+participantDto.ChampionName+".png";
            ChampLevel = participantDto.ChampLevel;
            GmKills = participantDto.Kills;
            GmDeaths = participantDto.Deaths;
            GmAssists = participantDto.Assists;
            GmItem0 = participantDto.Item0 >0? "http://ddragon.leagueoflegends.com/cdn/"+ Constants.Version +"/img/item/"+participantDto.Item0+".png" : "";
            GmItem1 = participantDto.Item1 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participantDto.Item1 + ".png" : ""; 
            GmItem2 = participantDto.Item2 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participantDto.Item2 + ".png" : ""; 
            GmItem3 = participantDto.Item3 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participantDto.Item3 + ".png" : ""; 
            GmItem4 = participantDto.Item4 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participantDto.Item4 + ".png" : ""; 
            GmItem5 = participantDto.Item5 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participantDto.Item5 + ".png" : ""; 
            GmItem6 = participantDto.Item6 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participantDto.Item6 + ".png" : ""; 
            GmSummoner1 = "";
            GmSummoner2 ="";
            GmCS = participantDto.TotalMinionsKilled;

    }
    }
}
