

using LolWPF.Utils;
using Newtonsoft.Json;
using System;

namespace LolWPF.Models
{
    public class Data
    {
        [JsonProperty(PropertyName ="Galio,Annie")]
        public ChampData Champion { get; set; }
    }
}