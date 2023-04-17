using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.Models
{
    public class ParticipantDto
    {
        public int ChampLevel { get; set; }
        public string ChampionName { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int Item0 { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; }
        public int Summoner1Id { get; set; }
        public int Summoner2Id { get; set; }
        public int TotalMinionsKilled { get; set; }
        public string Puuid { get; set; }
        public bool Win { get; set; }
    }
}
