﻿using LolWPF.Models;
using LolWPF.Utils;
using LolWPF.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.Controller
{
    class ControllerRotation
    {
        public object GetContext()
        {
            var champsInfo = Constants.Champions;
            var names = GetChampionNames(champsInfo);
            return new ViewModelRotation(names);
        }

        private List<string> GetChampionNames(ChampionInfo championInfo)
        {
            List<string> temp = new List<string>();
            foreach (var item in championInfo.freeChampionIds)
            {
                if(Enum.IsDefined(typeof(Champs), item))
                {
                    temp.Add(Enum.GetName(typeof(Champs), item));
                }
            }
            return temp;

        }
    }
}
