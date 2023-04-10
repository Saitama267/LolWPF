﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.API
{
    enum Champions
    {
        Annie = 1,
        Olaf = 2,
        Galio = 3,
        TwistedFate = 4,
        XinZhao = 5,
        Urgot = 6,
        LeBlanc = 7,
        Vladimir = 8,
        Fiddlesticks = 9,
        Kayle = 10,
        MasterYi = 11,
        Alistar = 12,
        Ryze = 13,
        Sion = 14,
        Sivir = 15,
        Soraka = 16,
        Teemo = 17,
        Tristana = 18,
        Warwick = 19,
        Nunu = 20,
        MissFortune = 21,
        Ashe = 22,
        Tryndamere = 23,
        Jax = 24,
        Morgana = 25,
        Zilean = 26,
        Singed = 27,
        Evelynn = 28,
        Twitch = 29,
        Karthus = 30,
        ChoGath = 31,
        Amumu = 32,
        Rammus =33,
        Anivia = 34,
        Shaco = 35,
        DrMundo =36,
        Sona = 37,
        Kassadin = 38,
        Irelia = 39,
        Janna = 40,
        Gangplank = 41,
        Corki = 42,
        Karma = 43,
        Taric = 44,
        Veigar = 45,
        Trundle = 48,
        Swain = 50,
        Caitlyn = 51,
        Blitzcrank = 53,
        Malphite = 54,
        Katarina = 55,
        Nocturne = 56,
        Maokai = 57,
        Renekton = 58,
        JarvanIV = 59,
        Elise = 60,
        Orianna = 61,
        Wukong = 62,
        Brand = 63,
        LeeSin = 64,
        Vayne = 67,
        Rumble = 68,
        Cassiopeia = 69,
        Skarner = 72,
        Heimerdinger = 74,
        Nasus = 75,
        Nidalee = 76,
        Udyr = 77,
        Poppy = 78,
        Gragas = 79,
        Pantheon = 80,
        Ezreal = 81,
        Mordekaiser = 82,
        Yorick = 83,
        Akali = 84,
        Kennen = 85,
        Garen = 86,
        Leona = 89,
        Malzahar = 90,
        Talon = 91,
        Riven = 92,
        KogMaw = 96,
        Shen = 98,
        Lux = 99,
        Xerath = 101,
        Shyvana = 102,
        Ahri = 103,
        Graves = 104,
        Fizz = 105,
        Volibear = 106,
        Rengar = 107,
        Varus = 110,
        Nautilus = 111,
        Viktor = 112,
        Sejuani = 113,
        Fiora = 114,
        Ziggs = 115,
        Lulu = 117,
        Draven = 119,
        Hecarim = 120,
        KhaZix = 121,
        Darius = 122,
        Jayce = 126,
        Lissandra = 127,
        Diana = 131,
        Quinn = 133,
        Syndra = 134,
        AurelionSol = 136,
        Kayn = 141,
        Zoe = 142,
        Zyra = 143,
        Kaisa = 145,
        Seraphine = 147,
        Gnar = 150,
        Zac = 154,
        Yasuo = 157,
        VelKoz = 161,
        Taliyah = 163,
        Akshan  = 166,
        Camille = 164,
        Braum = 201,
        Jhin = 202,
        Kindred = 203,
        Jinx = 222,
        TahmKench = 223,
        Viego = 234,
        Senna = 235,
        Lucian = 236,
        Zed = 238,
        Kled = 240,
        Ekko = 245,
        Qiyana = 246,
        Vi = 254,
        Aatrox = 266,
        Nami = 267,
        Azir = 268,
        Yuumi = 350,
        Samira = 360,
        Thresh = 412,
        Illaoi = 420,
        RekSai = 421,
        Ivern = 427,
        Kalista = 429,
        Bard = 432,
        Rakan = 497,
        Xayah = 498,
        Ornn = 516,
        Sylas = 517,
        Rell = 526,
        Neeko = 518,
        Aphelios = 523,
        Pyke = 555,
        Sett = 875,
        Vex = 711,
        Yone = 777 ,
        Gwen = 887,
        Lillia = 876,
    }
    public class Api
    {
        private string Key { get; set; }
        private string Region { get; set; }

        public Api(string region)
        {
            Region = region;
            Key = GetKey("../../API/Key.txt");
        }

        protected HttpResponseMessage GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                return result.Result;
            }
        }
        protected string GetURI(string path)
        {
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }
        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
        protected string GetLatestVersion()
        {
            return "https://ddragon.leagueoflegends.com/api/versions.json";
        }
    }
}
