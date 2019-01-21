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
using Projekt_PO;

namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy UzytkownikWindow.xaml
    /// </summary>
    public partial class UzytkownikWindow : Window
    {
     
        Uzytkownik user = new Uzytkownik();
        Ocena oc = new Ocena();
        Baza_filmow baza = new Baza_filmow();
        ObservableCollection<Film> lista;

        public UzytkownikWindow()
        {
            InitializeComponent();
            lista = new ObservableCollection<Film>();
            baza = Baza_filmow.OdczytajXML("C:/Users/zioma/Desktop/projektPO/GUI/bin/Debug/bazafilmow"); // Sciezke ustawic na ....  Desktop/projektPO/GUI/bin/Debug/bazafilmow
            lista = new ObservableCollection<Film>(baza.Lista_Filmów);
            textBox_recenzja.Text = "Podziel się krótką recenzją...";
            textBox_imie.Text = "";
            textBox_nazwisko.Text = "";
            textBox_nick.Text = "";
            listBox_filmy.ItemsSource = lista;
            
        }


        private void zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            
            user.Imie = textBox_imie.Text;
            user.Nazwisko = textBox_nazwisko.Text;
            user.Nick = textBox_nick.Text;

            if (comboBox_ocena.Text == "slaby")
            {
                oc.Nota = Nota.slaby;
            }
            if (comboBox_ocena.Text == "przecietny")
            {
                oc.Nota = Nota.przecietny;
            }
            if (comboBox_ocena.Text == "beznadziejny")
            {
                oc.Nota = Nota.beznadziejny;
            }
            if (comboBox_ocena.Text == "dobry")
            {
                oc.Nota = Nota.dobry;
            }
            if (comboBox_ocena.Text == "bdobry")
            {
                oc.Nota = Nota.bdobry;
            }
            if (comboBox_ocena.Text == "rewelacyjny")
            {

                oc.Nota = Nota.rewelacyjny;
            }
            
            oc.U = user;
            int zaznaczony = listBox_filmy.SelectedIndex;
            baza.Lista_Filmów.ElementAt(zaznaczony).dodaj_Ocene(oc);
            lista.RemoveAt(zaznaczony);
            lista.Insert(zaznaczony, baza.Lista_Filmów.ElementAt(zaznaczony));
            Baza_filmow.ZapiszXML("bazafilmow", baza);
        }

      
    }
}
