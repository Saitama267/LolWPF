using LolWPF.API;
using LolWPF.Models;
using LolWPF.Utils;
using LolWPF.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.Controller
{
    class ControllerProfile2
    {
        public object GetContext()
        {
            var summoner = Constants.Summoner;
            var position = Constants.Position;
            var gameInfo = GetGameInfo();
            var participant1 = gameInfo[0].Participants.Find(p => p.Puuid == Constants.Summoner.Puuid);
            var participant2 = gameInfo[1].Participants.Find(p => p.Puuid == Constants.Summoner.Puuid);
            var participant3 = gameInfo[2].Participants.Find(p => p.Puuid == Constants.Summoner.Puuid);
            return new ViewModelProfile2(summoner,position, gameInfo[0].GameMode,participant1,gameInfo[1].GameMode,participant2,gameInfo[2].GameMode,participant3);
        }

        private List<InfoDTO> GetGameInfo()
        {
            Match_V5 match_V5 = new Match_V5(Constants.Region);
            MatchDto matchDTO = new MatchDto();
            List<string> ids=match_V5.GetMatchsId(Constants.Summoner.Puuid);
            List<InfoDTO> info = new List<InfoDTO>();
            for (int i = 0; i < 3; i++)
            {
                matchDTO = match_V5.GetMatchInfo(ids[i]);
                info.Add(matchDTO != null ? matchDTO.Info : new InfoDTO());
            }
            
            return info;

        }
    }
}
