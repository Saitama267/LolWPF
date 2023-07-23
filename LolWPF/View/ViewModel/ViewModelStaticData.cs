using LolWPF.Models;
using LolWPF.Utils;
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

        public ViewModelStaticData(Dictionary<string, Dictionary<string, ChampData>> data)
        {
            Dictionary<string, ChampData> champ = data["data"];
            Icon = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + Constants.ChampName + "_0.jpg";
            Lore = champ[$"{Constants.ChampName}"].Lore;
            foreach (var item in champ[$"{Constants.ChampName}"].Allytips)
            {
                Allytips += $"{item}\n";
            }
            foreach (var item in champ[$"{Constants.ChampName}"].Enemytips)
            {
                Enemytips += $"{item}\n";
            }
        }
    }
}
