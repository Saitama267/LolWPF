using System;
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
        30=  Karthus ,
        31=  Cho Gath ,
        32=  Amumu ,
        33=  Rammus ,
        34=  Anivia ,
        35=  Shaco ,
        36=  Dr.Mundo ,
        37=  Sona ,
        38=  Kassadin ,
        39=  Irelia ,
        40=  Janna ,
        41=  Gangplank ,
        42=  Corki ,
        43=  Karma ,
        44=  Taric ,
        45=  Veigar ,
        48=  Trundle ,
        50=  Swain ,
        51=  Caitlyn ,
        53=  Blitzcrank ,
        54=  Malphite ,
        55=  Katarina ,
        56=  Nocturne ,
        57=  Maokai ,
        58=  Renekton ,
        59=  JarvanIV ,
        60=  Elise ,
        61=  Orianna ,
        62=  Wukong ,
        63=  Brand ,
        64=  LeeSin ,
        67=  Vayne ,
        68=  Rumble ,
        69=  Cassiopeia ,
        72=  Skarner ,
        74=  Heimerdinger ,
        75=  Nasus ,
        76=  Nidalee ,
        77=  Udyr ,
        78=  Poppy ,
        79=  Gragas ,
        80=  Pantheon ,
        81=  Ezreal ,
        82=  Mordekaiser ,
        83=  Yorick ,
        84=  Akali ,
        85=  Kennen ,
        86=  Garen ,
        89=  Leona ,
        90=  Malzahar ,
        91=  Talon ,
        92=  Riven ,
        96=  Kog Maw ,
        98=  Shen ,
        99=  Lux ,
        101=  Xerath ,
        102=  Shyvana ,
        103=  Ahri ,
        104=  Graves ,
        105=  Fizz ,
        106=  Volibear ,
        107=  Rengar ,
        110=  Varus ,
        111=  Nautilus ,
        112=  Viktor ,
        113=  Sejuani ,
        114=  Fiora ,
        115=  Ziggs ,
        117=  Lulu ,
        119=  Draven ,
        120=  Hecarim ,
        121=  Kha Zix ,
        122=  Darius ,
        126=  Jayce ,
        127=  Lissandra ,
        131=  Diana ,
        133=  Quinn ,
        134=  Syndra ,
        136=  AurelionSol ,
        141=  Kayn ,
        142=  Zoe ,
        143=  Zyra ,
        145=  Kai sa ,
        147=  Seraphine ,
        150=  Gnar ,
        154=  Zac ,
        157=  Yasuo ,
        161=  Vel Koz ,
        163=  Taliyah ,
        166=  Akshan ,
        164=  Camille ,
        201=  Braum ,
        202=  Jhin ,
        203=  Kindred ,
        222=  Jinx ,
        223=  TahmKench ,
        234=  Viego ,
        235=  Senna ,
        236=  Lucian ,
        238=  Zed ,
        240=  Kled ,
        245=  Ekko ,
        246=  Qiyana ,
        254=  Vi ,
        266=  Aatrox ,
        267=  Nami ,
        268=  Azir ,
        350=  Yuumi ,
        360=  Samira ,
        412=  Thresh ,
        420=  Illaoi ,
        421=  Rek Sai ,
        427=  Ivern ,
        429=  Kalista ,
        432=  Bard ,
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
