using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt_PO
{
    [Serializable]
    public class Baza_filmow 
    {

        private int liczbaFilmów;
        private List<Film> lista_Filmów;
        private string nazwa;

        /// <summary>
        ///   <para>Ilosc filmow</para>
        ///   <para></para>
        /// </summary>
        public int LiczbaFilmów { get => liczbaFilmów; set => liczbaFilmów = value; }
        /// <summary>Lista filmow</summary>
        public List<Film> Lista_Filmów { get => lista_Filmów; set => lista_Filmów = value; }
        /// <summary>Nazwa</summary>
        public string Nazwa { get => nazwa; set => nazwa = value; }
        /// <summary>konstruktory nieparametryczny bazy filmow</summary>
        public Baza_filmow()
        {
            liczbaFilmów = 0;
            lista_Filmów = new List<Film>();
        }
        /// <summary>Konstrukot z nazwa</summary>
        /// <param name="nazaw"></param>
        public Baza_filmow(string nazaw)
        {
            nazwa = nazaw;
            liczbaFilmów = 0;
            Lista_Filmów = new List<Film>();
        }
        /// <summary>Metoda dodajaca film do listy</summary>
        /// <param name="f"></param>
        public void DodajFilm(Film f){
            Lista_Filmów.Add(f);
            liczbaFilmów++;
        }

        /// <summary>Ranking najelpszych filmow</summary>
        /// <param name="n"></param>
        public Baza_filmow Ranking(int n)
        {
            lista_Filmów.Sort();
            List<Film> rank = new List<Film>();
            Baza_filmow ranking = new Baza_filmow();
            ranking.liczbaFilmów = n;
            ranking.nazwa = "ranking1";       
            for(int i=0;i<n;i++)
            {
                rank.Add(lista_Filmów.ElementAt(lista_Filmów.Count-i-1));

            }
            ranking.lista_Filmów = rank;
            return ranking;
        }




        /// <summary>Wypisanie filmow</summary>
        public string WypiszFilmy()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Film f1 in lista_Filmów)
            {
                sb.Append(f1.ToString());
            }
            return sb.ToString();
        }
        /*
        public static void ZapiszJSON(string nazwaPliku, Baza_filmow b)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Baza_filmow));
            using (var fstream = File.Create(nazwaPliku))
            {
                jsonSerializer.WriteObject(fstream, b);
            }
        }
        public static Baza_filmow OdczytajJSON(string nazwaPliku)
        {
            try
            {
                FileStream fstream = new FileStream(nazwaPliku, FileMode.Open);
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Baza_filmow));
                fstream.Position = 0;
                Baza_filmow b = (Baza_filmow)jsonSerializer.ReadObject(fstream);
                fstream.Close();
                return b;
            }
            catch (FileNotFoundException)
            {
                SystemSounds.Exclamation.Play();
                Console.WriteLine("Plik {0} nie istnieje!!!", nazwaPliku);
            }
            return null;
       
        }  */
        /// <summary>zapisz do xml</summary>
        /// <param name="nazwa"></param>
        /// <param name="z"></param>
        public static void ZapiszXML(string nazwa, Baza_filmow z)
        {
            XmlSerializer s = new XmlSerializer(typeof(Baza_filmow));
            FileStream writer = new FileStream(nazwa, FileMode.Create);
            s.Serialize(writer, z);
            writer.Close();
        }
        /// <summary>odczyt </summary>
        /// <param name="nazwa"></param>
        public static Baza_filmow OdczytajXML(string nazwa)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Baza_filmow));
                Baza_filmow nowyZespol = new Baza_filmow();
                FileStream reader = new FileStream(nazwa, FileMode.Open);

                nowyZespol = (Baza_filmow)serializer.Deserialize(reader);
                reader.Close();

                return nowyZespol;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Plik nie istnieje!");
            }
            return null;
        }
        /// <summary>Nadpisanie metody ToString</summary>
        public override string ToString()
        {
            return nazwa + Environment.NewLine + "Filmy: " + WypiszFilmy();
        }
    }
}
