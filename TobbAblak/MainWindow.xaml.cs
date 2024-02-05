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

namespace TobbAblak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {  
        public MainWindow()
        {
            InitializeComponent();
        }
        public string valtozo;
        private void UjAblak_Click(object sender, RoutedEventArgs e)
        {
            Window1 ujablak = new Window1(FoAblak.Text);
            UjAblak.IsEnabled = false;
            valtozo = "asdasdasd";
            ujablak.Show();
            
        }
    }
}
