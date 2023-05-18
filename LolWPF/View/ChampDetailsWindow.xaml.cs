using LolWPF.Controller;
using LolWPF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LolWPF.View
{
    /// <summary>
    /// Interaction logic for ChampDetailsWindow.xaml
    /// </summary>
    public partial class ChampDetailsWindow : Window
    {
        ControllerStaticChampData controller;
        string championName;
        public ChampDetailsWindow()
        {
            InitializeComponent();
            foreach (var champ in Enum.GetNames(typeof(Champs)))
            {
                cbChampion.Items.Add(champ);
            }
            controller = new ControllerStaticChampData();
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
        }

        private void cbChampion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            championName = (sender as ComboBox).SelectedValue.ToString();
        }

        private void btnShowInfo_Click(object sender, RoutedEventArgs e)
        {
            Constants.ChampName = championName;
            this.DataContext = controller.GetContext(championName);
        }
    }
}
