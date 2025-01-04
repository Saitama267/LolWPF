using LolWPF.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.View.ViewModel
{
    public class ViewModelMain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

       

        string region;
        public string Region
        {
            get { return region; }
            set { region = value; Constants.Region = value; NotifyPropertyChanged ("Region"); }
        }

        string summonerName;
        public string SummonerName
        {
            get { return summonerName; }
            set { summonerName = value; NotifyPropertyChanged("SummonerName"); }
        }

        string tag;
        public string Tag
        {
            get { return tag; }
            set { tag = value; NotifyPropertyChanged("Tag"); }
        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
