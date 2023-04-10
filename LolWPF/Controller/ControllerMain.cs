using LolWPF.API;
using LolWPF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.Controller
{
    class ControllerMain
    {
        public bool GetSummoner( string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(Constants.Region);
            var summoner = summoner_V4.GetSummonerByName(summonerName);

            Constants.Summoner = summoner;

            return summoner != null;
        }

        public bool GetVersionOfGame()
        {
            Game_Version game_Version = new Game_Version(Constants.Region);
            var version = game_Version.GetVersion();
            Constants.Version = version.First();
            return version != null;
        }
    }
}
