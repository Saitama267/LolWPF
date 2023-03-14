using LolWPF.API;
using LolWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.Controller
{
    public class ControllerProfile
    {
        public object GetContext(SummonerDTO summoner)
        {
            var position = GetPoSition(summoner);
            return null;
        }

        private object GetPoSition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4("");
            return null; 
        }
    }
}
