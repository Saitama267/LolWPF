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
    /// Interaction logic for FreeRotationWindow.xaml
    /// </summary>
    public partial class FreeRotationWindow : Window
    {
        public FreeRotationWindow()
        {
            ControllerRotation controller = new ControllerRotation();
            InitializeComponent();
            this.DataContext = controller.GetContext();

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.ShowDialog();
            Environment.Exit(0);
        }
    }
}
