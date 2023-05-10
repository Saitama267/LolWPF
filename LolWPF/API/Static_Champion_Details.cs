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

        public ChampBaseDTO  GetStaticChampioInfo(string champName)
        {
            var response = GET(GetURI(champName));
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<ChampBaseDTO>(content);
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
