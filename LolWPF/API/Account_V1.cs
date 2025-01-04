using LolWPF.Models;
using Newtonsoft.Json;
using RiotSharp.Endpoints.SummonerEndpoint;
using RiotSharp.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.API
{
    public class Account_V1 : Api
    {
        public string Region  { get; set; }
        public Account_V1(string region):base("EUROPE") 
        {
            Region = "EUROPE";
        }
        protected virtual string GetURI(string path)
        {
            string uri = "https://" + Region  + ".api.riotgames.com/riot/" + path + "?api_key=" + Key;
            return uri;
        }
        public AccountDTO GetAccount(string gameName, string tag)
        {
            string path = "account/v1/accounts/by-riot-id/" + gameName + "/" + tag;
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<AccountDTO>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
