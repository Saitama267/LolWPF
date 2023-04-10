using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.API
{
    public class Game_Version : Api
    {
        public Game_Version(string region) : base(region)
        {
        }

        public List<string> GetVersion()
        {
            var response = GET(GetLatestVersion());
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<string>>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
