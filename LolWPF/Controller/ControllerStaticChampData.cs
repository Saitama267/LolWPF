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
    class ControllerStaticChampData
    {
        public object GetContext(string name)
        {
            var champ = GetStaticChampData(name);
            return new ViewModelStaticData(champ);
        }

        private ChampBaseDTO GetStaticChampData(string name)
        {
            Static_Champion_Details static_Champion = new Static_Champion_Details(Constants.Region);
            var data = static_Champion.GetStaticChampioInfo(name);
            return data != null ? data : new ChampBaseDTO();


        }
    }
}
