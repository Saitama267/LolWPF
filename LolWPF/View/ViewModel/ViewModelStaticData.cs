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
            Icon = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + data.Data.Name + "_0.jpg";
            Lore = data.Data.Lore;
            Allytips = $"{data.Data.Allytips[0]}\n{data.Data.Allytips[1]}\n{data.Data.Allytips[2]}";
            Enemytips = $"{data.Data.Enemytips[0]}\n{data.Data.Enemytips[1]}\n{data.Data.Enemytips[2]}";
        }
    }
}
