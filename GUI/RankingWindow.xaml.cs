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
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy RankingWindow.xaml
    /// </summary>
    public partial class RankingWindow : Window
    {
        Baza_filmow baza = new Baza_filmow();
        ObservableCollection<Film> rank;
        public RankingWindow()
        {

            InitializeComponent();
            rank = new ObservableCollection<Film>();
            baza = Baza_filmow.OdczytajXML("C:/Users/zioma/Desktop/projektPO/GUI/bin/Debug/bazafilmow");// Sciezke ustawic na ....  Desktop/projektPO/GUI/bin/Debug/bazafilmow
            rank = new ObservableCollection<Film>(baza.Ranking(10).Lista_Filmów);
            listView_ranking.ItemsSource = rank;
            textBox_nfilmow.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(textBox_nfilmow.Text);
            rank = new ObservableCollection<Film>(baza.Ranking(n).Lista_Filmów);
            listView_ranking.ItemsSource = rank;



        }
    }
}
