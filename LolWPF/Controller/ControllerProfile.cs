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
    public class ControllerProfile
    {
        public object GetContext()
        {
            var summoner = Constants.Summoner;
            var position = GetPoSition(summoner);
            return new ViewModelProfile(summoner.Name,summoner.ProfileIconId,summoner.SummonerLevel,position.Tier,position.Rank,position.Wins,position.Losses);
        }
        
        private PositionDTO GetPoSition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4(Constants.Region);
            var position = league.GetPositions(summoner.Id).Where(p=>p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();
            return position != null ? position : new PositionDTO();
 
        }
    }
}
