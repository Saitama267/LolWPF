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
    /// Interaction logic for WindowProfile2.xaml
    /// </summary>
    public partial class WindowProfile2 : Window
    {
        ControllerProfile2 controller;
        public WindowProfile2()
        {
            InitializeComponent();
            controller = new ControllerProfile2();
            this.DataContext = controller.GetContext();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
