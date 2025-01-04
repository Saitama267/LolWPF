using LolWPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.API
{
    public class Summoner_V4 : Api
    {
        public Summoner_V4(string region) : base(region)
        {
        }

        public SummonerDTO GetSummonerByPuuid(string puuid)
        {
            string path = "summoner/v4/summoners/by-puuid/" + puuid;
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
