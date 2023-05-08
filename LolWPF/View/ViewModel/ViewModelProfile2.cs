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
        public string Game1Type { get; set; }
        public string Result1 { get; set; }
        public string ChampIcon1 { get; set; }
        public int ChampLevel1 { get; set; }
        public int Gm1Kills { get; set; }
        public int Gm1Deaths { get; set; }
        public int Gm1Assists { get; set; }
        public string Gm1Item0 { get; set; }
        public string Gm1Item1 { get; set; }
        public string Gm1Item2 { get; set; }
        public string Gm1Item3 { get; set; }
        public string Gm1Item4 { get; set; }
        public string Gm1Item5 { get; set; }
        public string Gm1Item6 { get; set; }
        public string Gm1Summoner1 { get; set; }
        public string Gm1Summoner2 { get; set; }
        public int Gm1CS { get; set; }
        public string Game2Type { get; set; }
        public string Result2{ get; set; }
        public string ChampIcon2 { get; set; }
        public int ChampLevel2 { get; set; }
        public int Gm2Kills { get; set; }
        public int Gm2Deaths { get; set; }
        public int Gm2Assists { get; set; }
        public string Gm2Item0 { get; set; }
        public string Gm2Item1 { get; set; }
        public string Gm2Item2 { get; set; }
        public string Gm2Item3 { get; set; }
        public string Gm2Item4 { get; set; }
        public string Gm2Item5 { get; set; }
        public string Gm2Item6 { get; set; }
        public string Gm2Summoner1 { get; set; }
        public string Gm2Summoner2 { get; set; }
        public int Gm2CS { get; set; }
        public string Game3Type { get; set; }
        public string Result3 { get; set; }
        public string ChampIcon3 { get; set; }
        public int ChampLevel3 { get; set; }
        public int Gm3Kills { get; set; }
        public int Gm3Deaths { get; set; }
        public int Gm3Assists { get; set; }
        public string Gm3Item0 { get; set; }
        public string Gm3Item1 { get; set; }
        public string Gm3Item2 { get; set; }
        public string Gm3Item3 { get; set; }
        public string Gm3Item4 { get; set; }
        public string Gm3Item5 { get; set; }
        public string Gm3Item6 { get; set; }
        public string Gm3Summoner1 { get; set; }
        public string Gm3Summoner2 { get; set; }
        public int Gm3CS { get; set; }
        public ViewModelProfile2(SummonerDTO summoner,PositionDTO position, string game1Type, ParticipantDto participant1Dto, string game2Type, ParticipantDto participant2Dto, string game3Type, ParticipantDto participant3Dto)
        {
            SummonerName = summoner.Name;
            Icon = "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/profileicon/" + summoner.ProfileIconId + ".png";
            Level = summoner.SummonerLevel;
            Tier = position.Tier;
            Rank = position.Rank != null ? position.Rank : "UNRANKED";
            Wins = position.Wins;
            Losses = position.Losses;
            Emblem = "../../Assets/emblem/Emblem_" + (position.Tier!=null?position.Tier:"Unranked") + ".png";
            Game1Type = game1Type;
            Result1 = participant1Dto.Win == true?"WIN" : "LOSE";
            ChampIcon1 = "http://ddragon.leagueoflegends.com/cdn/13.9.1/img/champion/"+participant1Dto.ChampionName+".png";
            ChampLevel1 = participant1Dto.ChampLevel;
            Gm1Kills = participant1Dto.Kills;
            Gm1Deaths = participant1Dto.Deaths;
            Gm1Assists = participant1Dto.Assists;
            Gm1Item0 = participant1Dto.Item0 >0? "http://ddragon.leagueoflegends.com/cdn/"+ Constants.Version +"/img/item/"+participant1Dto.Item0+".png" : "";
            Gm1Item1 = participant1Dto.Item1 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant1Dto.Item1 + ".png" : ""; 
            Gm1Item2 = participant1Dto.Item2 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant1Dto.Item2 + ".png" : ""; 
            Gm1Item3 = participant1Dto.Item3 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant1Dto.Item3 + ".png" : ""; 
            Gm1Item4 = participant1Dto.Item4 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant1Dto.Item4 + ".png" : ""; 
            Gm1Item5 = participant1Dto.Item5 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant1Dto.Item5 + ".png" : ""; 
            Gm1Item6 = participant1Dto.Item6 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant1Dto.Item6 + ".png" : ""; 
            Gm1Summoner1 = "http://ddragon.leagueoflegends.com/cdn/"+ Constants.Version + "/img/spell/"+  Enum.GetName(typeof(SummonerSpells), participant1Dto.Summoner1Id) + ".png";
            Gm1Summoner2 = "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/spell/" + Enum.GetName(typeof(SummonerSpells), participant1Dto.Summoner2Id) + ".png";
            Gm1CS = participant1Dto.TotalMinionsKilled + participant1Dto.NeutralMinionsKilled;

            Game2Type = game2Type;
            Result2 = participant2Dto.Win == true ? "WIN" : "LOSE";
            ChampIcon2 = "http://ddragon.leagueoflegends.com/cdn/13.9.1/img/champion/" + participant2Dto.ChampionName + ".png";
            ChampLevel2 = participant2Dto.ChampLevel;
            Gm2Kills = participant2Dto.Kills;
            Gm2Deaths = participant2Dto.Deaths;
            Gm2Assists = participant2Dto.Assists;
            Gm2Item0 = participant2Dto.Item0 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant2Dto.Item0 + ".png" : "";
            Gm2Item1 = participant2Dto.Item1 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant2Dto.Item1 + ".png" : "";
            Gm2Item2 = participant2Dto.Item2 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant2Dto.Item2 + ".png" : "";
            Gm2Item3 = participant2Dto.Item3 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant2Dto.Item3 + ".png" : "";
            Gm2Item4 = participant2Dto.Item4 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant2Dto.Item4 + ".png" : "";
            Gm2Item5 = participant2Dto.Item5 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant2Dto.Item5 + ".png" : "";
            Gm2Item6 = participant2Dto.Item6 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant2Dto.Item6 + ".png" : "";
            Gm2Summoner1 = "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/spell/" + Enum.GetName(typeof(SummonerSpells), participant2Dto.Summoner1Id) + ".png";
            Gm2Summoner2 = "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/spell/" + Enum.GetName(typeof(SummonerSpells), participant2Dto.Summoner2Id) + ".png";
            Gm2CS = participant2Dto.TotalMinionsKilled + participant2Dto.NeutralMinionsKilled;

            Game3Type = game3Type;
            Result3 = participant3Dto.Win == true ? "WIN" : "LOSE";
            ChampIcon3 = "http://ddragon.leagueoflegends.com/cdn/13.9.1/img/champion/" + participant3Dto.ChampionName + ".png";
            ChampLevel3 = participant3Dto.ChampLevel;
            Gm3Kills = participant3Dto.Kills;
            Gm3Deaths = participant3Dto.Deaths;
            Gm3Assists = participant3Dto.Assists;
            Gm3Item0 = participant3Dto.Item0 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant3Dto.Item0 + ".png" : "";
            Gm3Item1 = participant3Dto.Item1 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant3Dto.Item1 + ".png" : "";
            Gm3Item2 = participant3Dto.Item2 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant3Dto.Item2 + ".png" : "";
            Gm3Item3 = participant3Dto.Item3 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant3Dto.Item3 + ".png" : "";
            Gm3Item4 = participant3Dto.Item4 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant3Dto.Item4 + ".png" : "";
            Gm3Item5 = participant3Dto.Item5 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant3Dto.Item5 + ".png" : "";
            Gm3Item6 = participant3Dto.Item6 > 0 ? "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/item/" + participant3Dto.Item6 + ".png" : "";
            Gm3Summoner1 = "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/spell/" + Enum.GetName(typeof(SummonerSpells), participant3Dto.Summoner1Id) + ".png";
            Gm3Summoner2 = "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/img/spell/" + Enum.GetName(typeof(SummonerSpells), participant3Dto.Summoner2Id) + ".png";
            Gm3CS = participant3Dto.TotalMinionsKilled + participant3Dto.NeutralMinionsKilled;

        }
    }
}
