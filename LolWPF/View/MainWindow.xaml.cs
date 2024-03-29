﻿using LolWPF.Controller;
using LolWPF.Models;
using LolWPF.Utils;
using LolWPF.View;
using LolWPF.View.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LolWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ControllerMain controller;
        ViewModelMain viewModel;
        
        public MainWindow()
        {
            controller = new ControllerMain();
            viewModel = new ViewModelMain();
            
            InitializeComponent();
            

            
            this.DataContext = viewModel;
        }

        private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(viewModel.Region))
            {
                return;
            }
            if (string.IsNullOrEmpty(viewModel.SummonerName))
            {
                return;
            }
            if (controller.GetSummoner(viewModel.SummonerName) && controller.GetVersionOfGame())
            {
                WindowProfile profile = new WindowProfile();
                this.Close();
                profile.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void btnFreeRotaion_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(viewModel.Region))
            {
                return;
            }
            if (controller.GetChampionsRotaionInfo())
            {
                FreeRotationWindow rotation = new FreeRotationWindow();
                this.Close();
                
                rotation.ShowDialog();
                
            }
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnChampLore_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(viewModel.Region))
            {
                return;
            }
            if(controller.GetVersionOfGame())
            {
                ChampDetailsWindow champ = new ChampDetailsWindow();
                this.Close();
                champ.ShowDialog();
            }
            
        }
    }
}
