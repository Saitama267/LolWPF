using LolWPF.Models;
using LolWPF.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.API
{
    public class Static_Champion_Details : Api
    {
        public Static_Champion_Details(string region):base(region)
        {
        }

        public Dictionary<string, Dictionary<string, ChampData>> GetStaticChampioInfo(string champName)
        {
            var response = GET(GetURI(champName));
            string content = response.Content.ReadAsStringAsync().Result;
            var text = content.Split(new char[] { ',' }, 5);
            var c = "{"+text[3]+"," + text[4] ;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Dictionary<string,Dictionary<string,ChampData>>>(c);
            }
            else
            {
                return null;
            }
        }
        protected override string GetURI(string path)
        {
            return "http://ddragon.leagueoflegends.com/cdn/" + Constants.Version + "/data/en_US/champion/" + path + ".json";
        }
    }
}
