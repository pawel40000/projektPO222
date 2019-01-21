using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt_PO
{
    /// <summary>Kategorie do wyboru</summary>
    [Serializable]
    public enum Kategoria { Komedia, Dramat, Thriller, Akcja, Horror, Animacja }
    /// <summary>Noty filmu do wyboru</summary>
    public enum Nota {beznadziejny=1, slaby =2,przecietny =3, dobry =4, bdobry=5,rewelacyjny=6}

    class Program
    {
        static void Main(string[] args)
        {
            Baza_filmow all = new Baza_filmow();
            all.Nazwa = "alka";
            Uzytkownik user1 = new Uzytkownik("Alfred", "Mocny", "alfredzio13");
            Ocena oc1 = new Ocena();
            oc1.Nota = Nota.slaby;
            oc1.Recenzja = "Ponad przeciętny poziom efektów specjalnych";

            Ocena oc2 = new Ocena();
            oc2.Nota = Nota.przecietny;
            oc2.Recenzja = "Nic ciekawego";

            Ocena oc3 = new Ocena();
            oc3.Nota = Nota.slaby;
            oc3.Recenzja = "Ten reżyser powieninien się już zająć szukaniem miejsca spokojnej starości, ogólnie w porządku";

            Ocena oc4 = new Ocena();
            oc4.Nota = Nota.beznadziejny;
            oc4.Recenzja = "Gra aktorska na poziomie ekstraklasy";

            Ocena oc5 = new Ocena();
            oc5.Nota = Nota.dobry;
            oc5.Recenzja = "Haha a ja jak w tym filmie cyk blancik po robocie";

            Ocena oc6 = new Ocena();
            oc6.Nota = Nota.slaby;
            oc6.Recenzja = "Słabizna!!!1111";

            Ocena oc7 = new Ocena();
            oc7.Nota = Nota.bdobry;
            oc7.Recenzja = "Arycdzieło kinematografii!";

            Ocena oc8 = new Ocena();
            oc8.Nota = Nota.bdobry;
            oc8.Recenzja = "Fenomenalny!";

            Ocena oc9 = new Ocena();
            oc9.Nota = Nota.rewelacyjny;
            oc9.Recenzja = "Prawie idealny!";

            Ocena oc10 = new Ocena();
            oc10.Nota = Nota.przecietny;
            oc10.Recenzja = "Początek dobry, ale z każdą minuta coraz gorzej";

            Ocena oc11 = new Ocena();
            oc11.Nota = Nota.dobry;
            oc11.Recenzja = "Całkiem dobry film, w sam raz na wolne popołudnie";

            Ocena oc12 = new Ocena();
            oc12.Nota = Nota.beznadziejny;
            oc12.Recenzja = "Katastrofa, straiłem 2h mojego życia na ten film";

            Ocena oc13 = new Ocena();
            oc13.Nota = Nota.beznadziejny;
            oc13.Recenzja = "Odradzam oglądanie tego filmu, chyba że maja państwo kłopoty z bezsennością";

            Ocena oc14 = new Ocena();
            oc14.Nota = Nota.dobry;
            oc14.Recenzja = "Polecam ten film";

            Ocena oc15 = new Ocena();
            oc15.Nota = Nota.slaby;
            oc15.Recenzja = "Strata czasu";

            Ocena oc16 = new Ocena();
            oc16.Nota = Nota.przecietny;
            oc16.Recenzja = "Nic specjalnego, tysiące takich filmów już było";

            Ocena oc17 = new Ocena();
            oc17.Nota = Nota.przecietny;
            oc17.Recenzja = "Przewidywalny do bólu";

            Ocena oc18 = new Ocena();
            oc18.Nota = Nota.rewelacyjny;
            oc18.Recenzja = "Perfecto";

            Ocena oc19 = new Ocena();
            oc19.Nota = Nota.slaby;
            oc19.Recenzja = "Bez ładu";

            Ocena oc20 = new Ocena();
            oc20.Nota = Nota.rewelacyjny;
            oc20.Recenzja = "Wzruszający";






            
            

            Film f1 = new Film("Matrix", "Lilly Wachowski", 1999, Kategoria.Akcja, "Australia");
            Film f2 = new Film("Iron Man", "Akcja", 2008, Kategoria.Akcja, "USA");
            Film f3 = new Film("Nietykalni", "Olivier Nakache", 2012, Kategoria.Komedia, "Francja");
            Film f4 = new Film("Pianista", "Roman Polański", 2002, Kategoria.Dramat, "Polska");
            Film f5 = new Film("Egzorcysta", "William Friedkin", 2014, Kategoria.Horror, "USA");
            Film f6 = new Film("Wyspa tajemnic", "Martin Scorsese", 2010, Kategoria.Komedia, "Polska");
            Film f7 = new Film("Złap mnie jeśli potrafisz", "Steven Spielberg", 2003, Kategoria.Komedia, "USA");
            Film f8 = new Film("Dracula", "Francis Ford Coppola", 1992, Kategoria.Horror, "USA");
            Film f9 = new Film("Obecność", "James Wan", 2013, Kategoria.Horror, "USA");
            Film f10 = new Film("Zielona Mila", "Frank Darabont", 1999, Kategoria.Dramat, "USA");
            Film f11 = new Film("Skazani na Shawshank", "Frank Darabont", 1994, Kategoria.Dramat, "USA");
            Film f12 = new Film("Forrest Gump", "Robert Zemeckis", 1994, Kategoria.Dramat, "USA");
            Film f13 = new Film("Adwokat Diabła", "Taylor Hackford", 1997, Kategoria.Thriller, "Niemcy");
            Film f14 = new Film("Prestiż", "Chrisopher Nolan", 2006, Kategoria.Thriller, "USA");
            Film f15 = new Film("Przełęcz ocalonych", "Mel Gibson", 2016, Kategoria.Dramat, "Australia");
            Film f16 = new Film("Whiplash", "Damien Chazelle", 2014, Kategoria.Dramat, "USA");            
            Film f17 = new Film("Gladiator", "Ridley Scott", 2000, Kategoria.Dramat, "USA/Wielka Brytania");            
            Film f18 = new Film("Siedem", "David Fincher", 1995, Kategoria.Thriller, "USA");
            Film f19 = new Film("Amrican Gangster", "Ridley Scoot", 2007, Kategoria.Akcja, "USA");
            Film f20 = new Film("Gran Torino", "Clint Eastwood", 2008, Kategoria.Dramat, "USA");
            Film f21 = new Film("Jestem Legendą", "Francis Lawrence", 2011, Kategoria.Horror, "USA");
            Film f22 = new Film("Obcy - 8. pasażer Nostromo", "Ridley Scott", 1979, Kategoria.Horror, "USA");
            Film f23 = new Film("Szybcy i Wściekli 5", "Justin Lin", 2011, Kategoria.Akcja, "USA");
            Film f24 = new Film("Bękarty Wojny", "Quentin Tarantion", 2009, Kategoria.Komedia, "Niemcy");
            Film f25 = new Film("Infiltracja", "Martin Scorese", 2006, Kategoria.Akcja, "USA");
            all.DodajFilm(f1);
            all.DodajFilm(f2);
            all.DodajFilm(f3);
            all.DodajFilm(f4);
            all.DodajFilm(f5);
            all.DodajFilm(f6);
            all.DodajFilm(f7);
            all.DodajFilm(f8);
            all.DodajFilm(f9);
            all.DodajFilm(f10);
            all.DodajFilm(f11);
            all.DodajFilm(f12);
            all.DodajFilm(f13);
            all.DodajFilm(f14);
            all.DodajFilm(f15);
            all.DodajFilm(f16);
            all.DodajFilm(f17);
            all.DodajFilm(f18);
            all.DodajFilm(f19);
            all.DodajFilm(f20);
            all.DodajFilm(f21);
            all.DodajFilm(f22);
            all.DodajFilm(f23);
            all.DodajFilm(f24);
            all.DodajFilm(f25);
            /*
            f1.dodaj_Ocene(oc4);
            f1.dodaj_Ocene(oc4);
            f1.dodaj_Ocene(oc4);
            f1.dodaj_Ocene(oc7);*/


            /*
                 Console.Write(all);
                  Console.WriteLine();
                 Console.WriteLine(" === Zapis do pliku JSON ==== ");
                   Baza_filmow.ZapiszJSON("baza.json", all);
                Console.WriteLine(" === Zapisano !!! === ");
            Baza_filmow all = new Baza_filmow();
            Console.WriteLine("=== Odczyt z pliku JSON ====");
            all = Baza_filmow.OdczytajJSON("baza.json");
            Console.WriteLine(" ===========  Odczytano  =========");
            Console.Write(all.WypiszFilmy());
            Console.WriteLine();*/


            
            all.Lista_Filmów.ElementAt(0).dodaj_Ocene(oc1);
            all.Lista_Filmów.ElementAt(0).dodaj_Ocene(oc2);
            all.Lista_Filmów.ElementAt(0).dodaj_Ocene(oc3);
            all.Lista_Filmów.ElementAt(0).dodaj_Ocene(oc4);


            all.Lista_Filmów.ElementAt(1).dodaj_Ocene(oc5);
            all.Lista_Filmów.ElementAt(1).dodaj_Ocene(oc6);
            all.Lista_Filmów.ElementAt(1).dodaj_Ocene(oc7);
            all.Lista_Filmów.ElementAt(1).dodaj_Ocene(oc8);

            all.Lista_Filmów.ElementAt(2).dodaj_Ocene(oc1);
            all.Lista_Filmów.ElementAt(2).dodaj_Ocene(oc15);
            all.Lista_Filmów.ElementAt(2).dodaj_Ocene(oc11);
            all.Lista_Filmów.ElementAt(2).dodaj_Ocene(oc8);           

            all.Lista_Filmów.ElementAt(3).dodaj_Ocene(oc13);
            all.Lista_Filmów.ElementAt(3).dodaj_Ocene(oc20);
            all.Lista_Filmów.ElementAt(3).dodaj_Ocene(oc19);
            all.Lista_Filmów.ElementAt(3).dodaj_Ocene(oc18);
            
            all.Lista_Filmów.ElementAt(4).dodaj_Ocene(oc10);
            all.Lista_Filmów.ElementAt(4).dodaj_Ocene(oc11);
            all.Lista_Filmów.ElementAt(4).dodaj_Ocene(oc16);
            all.Lista_Filmów.ElementAt(4).dodaj_Ocene(oc2);
            all.Lista_Filmów.ElementAt(4).dodaj_Ocene(oc18);
            all.Lista_Filmów.ElementAt(4).dodaj_Ocene(oc18);

            all.Lista_Filmów.ElementAt(5).dodaj_Ocene(oc5);
            all.Lista_Filmów.ElementAt(5).dodaj_Ocene(oc7);
            all.Lista_Filmów.ElementAt(5).dodaj_Ocene(oc10);
            all.Lista_Filmów.ElementAt(5).dodaj_Ocene(oc20);

            all.Lista_Filmów.ElementAt(6).dodaj_Ocene(oc4);
            all.Lista_Filmów.ElementAt(6).dodaj_Ocene(oc8);
            all.Lista_Filmów.ElementAt(6).dodaj_Ocene(oc15);
            all.Lista_Filmów.ElementAt(6).dodaj_Ocene(oc20);

            all.Lista_Filmów.ElementAt(7).dodaj_Ocene(oc14);
            all.Lista_Filmów.ElementAt(7).dodaj_Ocene(oc18);
            all.Lista_Filmów.ElementAt(7).dodaj_Ocene(oc1);
            all.Lista_Filmów.ElementAt(7).dodaj_Ocene(oc20);

            all.Lista_Filmów.ElementAt(8).dodaj_Ocene(oc4);
            all.Lista_Filmów.ElementAt(8).dodaj_Ocene(oc18);
            all.Lista_Filmów.ElementAt(8).dodaj_Ocene(oc10);
            all.Lista_Filmów.ElementAt(8).dodaj_Ocene(oc9);

            all.Lista_Filmów.ElementAt(9).dodaj_Ocene(oc3);
            all.Lista_Filmów.ElementAt(9).dodaj_Ocene(oc6);
            all.Lista_Filmów.ElementAt(9).dodaj_Ocene(oc1);
            all.Lista_Filmów.ElementAt(9).dodaj_Ocene(oc10);
            
            all.Lista_Filmów.ElementAt(10).dodaj_Ocene(oc19);
            all.Lista_Filmów.ElementAt(10).dodaj_Ocene(oc18);
            all.Lista_Filmów.ElementAt(10).dodaj_Ocene(oc6);
            all.Lista_Filmów.ElementAt(10).dodaj_Ocene(oc2);

            all.Lista_Filmów.ElementAt(11).dodaj_Ocene(oc6);
            all.Lista_Filmów.ElementAt(11).dodaj_Ocene(oc18);
            all.Lista_Filmów.ElementAt(11).dodaj_Ocene(oc7);
            all.Lista_Filmów.ElementAt(11).dodaj_Ocene(oc5);

            all.Lista_Filmów.ElementAt(12).dodaj_Ocene(oc4);
            all.Lista_Filmów.ElementAt(12).dodaj_Ocene(oc8);
            all.Lista_Filmów.ElementAt(12).dodaj_Ocene(oc15);
            all.Lista_Filmów.ElementAt(12).dodaj_Ocene(oc20);

            all.Lista_Filmów.ElementAt(13).dodaj_Ocene(oc4);
            all.Lista_Filmów.ElementAt(13).dodaj_Ocene(oc8);
            all.Lista_Filmów.ElementAt(13).dodaj_Ocene(oc15);
            all.Lista_Filmów.ElementAt(13).dodaj_Ocene(oc20);

            all.Lista_Filmów.ElementAt(13).dodaj_Ocene(oc4);
            all.Lista_Filmów.ElementAt(13).dodaj_Ocene(oc8);
            all.Lista_Filmów.ElementAt(13).dodaj_Ocene(oc15);
            all.Lista_Filmów.ElementAt(13).dodaj_Ocene(oc20);

            all.Lista_Filmów.ElementAt(14).dodaj_Ocene(oc4);
            all.Lista_Filmów.ElementAt(14).dodaj_Ocene(oc8);
            all.Lista_Filmów.ElementAt(14).dodaj_Ocene(oc15);
            all.Lista_Filmów.ElementAt(14).dodaj_Ocene(oc20);

            all.Lista_Filmów.ElementAt(15).dodaj_Ocene(oc4);
            all.Lista_Filmów.ElementAt(15).dodaj_Ocene(oc8);
            all.Lista_Filmów.ElementAt(15).dodaj_Ocene(oc15);
            all.Lista_Filmów.ElementAt(15).dodaj_Ocene(oc20);

            all.Lista_Filmów.ElementAt(16).dodaj_Ocene(oc4);
            all.Lista_Filmów.ElementAt(16).dodaj_Ocene(oc8);
            all.Lista_Filmów.ElementAt(16).dodaj_Ocene(oc2);
            all.Lista_Filmów.ElementAt(16).dodaj_Ocene(oc3);

            all.Lista_Filmów.ElementAt(17).dodaj_Ocene(oc2);
            all.Lista_Filmów.ElementAt(17).dodaj_Ocene(oc1);
            all.Lista_Filmów.ElementAt(17).dodaj_Ocene(oc3);
            all.Lista_Filmów.ElementAt(17).dodaj_Ocene(oc4);

            all.Lista_Filmów.ElementAt(18).dodaj_Ocene(oc15);
            all.Lista_Filmów.ElementAt(18).dodaj_Ocene(oc18);
            all.Lista_Filmów.ElementAt(18).dodaj_Ocene(oc13);
            all.Lista_Filmów.ElementAt(18).dodaj_Ocene(oc3);

            all.Lista_Filmów.ElementAt(19).dodaj_Ocene(oc19);
            all.Lista_Filmów.ElementAt(19).dodaj_Ocene(oc15);
            all.Lista_Filmów.ElementAt(19).dodaj_Ocene(oc4);
            all.Lista_Filmów.ElementAt(19).dodaj_Ocene(oc7);

            all.Lista_Filmów.ElementAt(20).dodaj_Ocene(oc18);
            all.Lista_Filmów.ElementAt(20).dodaj_Ocene(oc7);
            all.Lista_Filmów.ElementAt(20).dodaj_Ocene(oc6);
            all.Lista_Filmów.ElementAt(20).dodaj_Ocene(oc1);
            f22.dodaj_Ocene(oc9);
            f22.dodaj_Ocene(oc1);
            f23.dodaj_Ocene(oc14);
            f24.dodaj_Ocene(oc3);
            f25.dodaj_Ocene(oc19);

            Console.WriteLine("przed zapisem: ");
            Console.WriteLine(all);
            Console.WriteLine("Zapis do pliku XML...");
            Baza_filmow.ZapiszXML("bazafilmow", all);
            Console.WriteLine("Odczyt...");
            Baza_filmow odczytanaXML = Baza_filmow.OdczytajXML("bazafilmow");
            Console.WriteLine(odczytanaXML.WypiszFilmy());


          //  Console.WriteLine(all.Ranking(7));
          //  Console.WriteLine(f5.Oceny.ElementAt(1).Recenzja);


            Console.ReadKey();
            
        }
    }
}
