using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.View.ViewModel
{
    class ViewModelRotation
    {
        public string Champ1 { get; set; }
        public string Champ2 { get; set; }
        public string Champ3 { get; set; }
        public string Champ4 { get; set; }
        public string Champ5 { get; set; }
        public string Champ6 { get; set; }
        public string Champ7 { get; set; }
        public string Champ8 { get; set; }
        public string Champ9 { get; set; }
        public string Champ10 { get; set; }

        public ViewModelRotation( string name1, string name2, string name3, string name4, string name5, string name6, string name7, string name8, string name9, string name10)
        {
            Champ1 = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + name1 + "_0.jpg";
            Champ2 = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + name2 + "_0.jpg";
            Champ3 = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + name3 + "_0.jpg";
            Champ4 = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + name4 + "_0.jpg";
            Champ5 = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + name5 + "_0.jpg";
            Champ6 = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + name6 + "_0.jpg";
            Champ7 = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + name7 + "_0.jpg";
            Champ8 = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + name8 + "_0.jpg";
            Champ9 = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + name9 + "_0.jpg";
            Champ10 = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + name10 + "_0.jpg";
        }

    }
}
