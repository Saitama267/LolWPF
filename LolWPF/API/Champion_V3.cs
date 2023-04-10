using LolWPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.API
{
    class Champion_V3 : Api
    {
        public Champion_V3(string region):base(region)
        {

        }

        public ChampionInfo GetChampionsRotationIds()
        {
            
            string path = "platform/v3/champion-rotations";
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<ChampionInfo>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
