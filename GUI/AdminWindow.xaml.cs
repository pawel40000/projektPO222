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
    /// Logika interakcji dla klasy AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        Baza_filmow baza = new Baza_filmow();
        ObservableCollection<Film> lista;
        Film film = new Film();
        public AdminWindow()
        {
         
            InitializeComponent();
            lista = new ObservableCollection<Film>();
            baza = Baza_filmow.OdczytajXML("C:/Users/zioma/Desktop/projektPO/GUI/bin/Debug/bazafilmow"); // Sciezke ustawic na ....  Desktop/projektPO/GUI/bin/Debug/bazafilmow
            lista = new ObservableCollection<Film>(baza.Lista_Filmów);
            textBox_tytul.Text = "";
            textBox_rezyser.Text = "";
            textBox_rokprod.Text = "";
            textBox_kraj.Text = "";
        }

        private void zatwierdzfilm_Button_Click(object sender, RoutedEventArgs e)
        {
            film.Tytul = textBox_tytul.Text;
            film.Rezyser = textBox_rezyser.Text;
            try
            {
                film.Rok_prod = int.Parse(textBox_rokprod.Text);
            }
            catch(System.FormatException)
            {
                

            }
     
            
            film.Kraj_prod = textBox_kraj.Text;


            if (comboBox_kategoria.Text == "Komedia")
            {
                film.Kategoria = Kategoria.Komedia;
            }
            if (comboBox_kategoria.Text == "Dramat")
            {
                film.Kategoria = Kategoria.Dramat;
            }
            if (comboBox_kategoria.Text == "Horror")
            {
                film.Kategoria = Kategoria.Horror;
            }
            if (comboBox_kategoria.Text == "Thriller")
            {
                film.Kategoria = Kategoria.Thriller;
            }
            if (comboBox_kategoria.Text == "Animacja")
            {
                film.Kategoria = Kategoria.Animacja;
            }
            if (comboBox_kategoria.Text == "Akcja")
            {
                film.Kategoria = Kategoria.Akcja;
            }
            baza.DodajFilm(film);
            lista.Add(film);
            Baza_filmow.ZapiszXML("bazafilmow", baza);

        }
    }
}
