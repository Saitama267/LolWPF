using System;
using System.Collections.Generic;

namespace LolWPF.Models
{
    public class ChampData
    {
        public string Name { get; set; }
        public string Lore { get; set; }
        public List<string> Allytips { get; set; }
        public List<string> Enemytips { get; set; }
    }
}