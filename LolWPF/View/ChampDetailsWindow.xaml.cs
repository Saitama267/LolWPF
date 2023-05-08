﻿using LolWPF.Utils;
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
        public ChampDetailsWindow()
        {
            InitializeComponent();
            foreach (var champ in Enum.GetNames(typeof(Champs)))
            {
                cbChampion.Items.Add(champ);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
        }
    }
}
