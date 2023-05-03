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
            var position = GetPoSition(summoner);
            var gameInfo = GetGameInfo();
            var participant = gameInfo.Participants.Find(p => p.Puuid == Constants.Summoner.Puuid);
            return new ViewModelProfile2(summoner,position, gameInfo.GameMode,participant);
        }

        private PositionDTO GetPoSition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4(Constants.Region);
            var position = league.GetPositions(summoner.Id).Where(p => p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();
            return position != null ? position : new PositionDTO();

        }

        private InfoDTO GetGameInfo()
        {
            Match_V5 match_V5 = new Match_V5(Constants.Region);
            List<string> ids=match_V5.GetMatchsId(Constants.Summoner.Puuid);
            MatchDto matchDTO = match_V5.GetMatchInfo(ids.First());
            return matchDTO != null ? matchDTO.Info : new InfoDTO();

        }
    }
}
