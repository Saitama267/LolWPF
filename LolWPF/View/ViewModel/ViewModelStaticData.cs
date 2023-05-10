using LolWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.View.ViewModel
{
    class ViewModelStaticData
    {
        public string Icon { get; set; }
        public string Lore  { get; set; }
        public string Allytips { get; set; }
        public string Enemytips { get; set; }

        public ViewModelStaticData(ChampBaseDTO data)
        {
            Icon = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + data.Data.Galio.Name + "_0.jpg";
            Lore = data.Data.Galio.Lore;
            Allytips = $"{data.Data.Galio.Allytips[0]}\n{data.Data.Galio.Allytips[1]}\n{data.Data.Galio.Allytips[2]}";
            Enemytips = $"{data.Data.Galio.Enemytips[0]}\n{data.Data.Galio.Enemytips[1]}\n{data.Data.Galio.Enemytips[2]}";
        }
    }
}
