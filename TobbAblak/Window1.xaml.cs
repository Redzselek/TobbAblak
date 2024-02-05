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

namespace TobbAblak
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string sz;

        public Window1(string szoveg)
        {
            InitializeComponent();
            sz = szoveg;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ((MainWindow)(Application.Current.MainWindow)).FoAblak.Text = AdatTxt.Text;
            ((MainWindow)(Application.Current.MainWindow)).UjAblak.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdatTxt.Text = ((MainWindow)(Application.Current.MainWindow)).FoAblak.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((MainWindow)(Application.Current.MainWindow)).valtozo);
        }
    }
}
