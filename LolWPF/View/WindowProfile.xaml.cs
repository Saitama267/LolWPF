using LolWPF.Controller;
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
    /// Interaction logic for WindowProfile.xaml
    /// </summary>
    public partial class WindowProfile : Window
    {
        ControllerProfile controller;
        public WindowProfile()
        {
            InitializeComponent();
            controller = new ControllerProfile();
            this.DataContext = controller.GetContext();

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
            
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            WindowProfile2 windowProfile2 = new WindowProfile2();
            windowProfile2.ShowDialog();
        }
    }
}
