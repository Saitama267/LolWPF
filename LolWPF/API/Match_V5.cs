using LolWPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.API
{
    public class Match_V5 : Api
    {
        private string PartOfWorld { get; set; }
        public Match_V5(string region) : base(region)
        {
            switch (region)
            {
                case "EUW1":
                case "TR1":
                case "EUN1":
                    PartOfWorld = "EUROPE";
                    break;
                case "KR":
                case "JP1":
                    PartOfWorld = "ASIA";
                    break;
                case "BR1":
                case "NA1":
                case "LA1":
                case "LA2":
                    PartOfWorld = "AMERICAS";
                    break;
                case "OC1":
                case "PH2":
                case "SG2":
                case "TH2":
                case "TW2":
                case "VN2":
                    PartOfWorld = "SEA";
                    break;
                default:
                    break;
            }
        }
        protected override string GetURI(string path)
        {
            return "https://" + PartOfWorld + ".api.riotgames.com/lol/" + path + "&api_key=" + Key;
        }

        private string GetURIForMatchData(string path)
        {
            return "https://" + PartOfWorld + ".api.riotgames.com/lol/" + path + "?api_key=" + Key; 
        }

        public List<string> GetMatchsId(string PUUID)
        {
            string path = "match/v5/matches/by-puuid/" + PUUID + "/ids?start=0&count=5";
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<string>>(content);
            }
            return null;
        }
        public MatchDto GetMatchInfo(string Id)
        { 
            string path = "match/v5/matches/" + Id;
            var response = GET(GetURIForMatchData(path));
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<MatchDto>(content);
            }
            return null;

        }
    }
}
