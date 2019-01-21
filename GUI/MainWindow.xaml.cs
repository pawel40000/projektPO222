using Projekt_PO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UzytkownikWindow okno = new UzytkownikWindow();
            okno.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdminWindow okno = new AdminWindow();
            okno.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RankingWindow okno = new RankingWindow();
            okno.ShowDialog();
        }
    }
}
