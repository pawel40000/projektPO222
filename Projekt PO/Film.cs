using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt_PO
{
    /// <summary>Klasa film przechowujaca dane o filmie</summary>
    [Serializable]
    

    public class Film: IComparable<Film>
    {
        private string tytul;
        private string rezyser;
        private int rok_prod;
        private Kategoria kategoria;
        private string kraj_prod;
        private List <Ocena> oceny;
        private double srednia;

        /// <summary>tytul filmu</summary>
        public string Tytul { get => tytul; set => tytul = value; }
        /// <summary>rezyser filmu</summary>
        public string Rezyser { get => rezyser; set => rezyser = value; }
        /// <summary>rok produkcji filmu</summary>
        public int Rok_prod { get => rok_prod; set => rok_prod = value; }
        /// <summary>kategoria filmu</summary>
        public Kategoria Kategoria { get => kategoria; set => kategoria = value; }
        /// <summary>
        ///   <para>kraj produkcji filmu</para>
        ///   <para></para>
        /// </summary>
        public string Kraj_prod { get => kraj_prod; set => kraj_prod = value; }
        /// <summary>Lista ocen</summary>
        public List<Ocena> Oceny { get => oceny; set => oceny = value; }
        /// <summary>Srednia ocen filmu</summary>
        public double Srednia { get => srednia; set => srednia = value; }

        /// <summary>Konstruktor nieparametryczny filmu</summary>
        public Film()
        {
            tytul = null;
            rezyser = null;
            rok_prod = 0;
            kraj_prod = null;
            oceny = new List<Ocena>();
       
            Srednia = 0;
        }

        /// <summary>Konstruktor parametryczny filmu</summary>
        /// <param name="tyt"></param>
        /// <param name="rez"></param>
        /// <param name="rok"></param>
        /// <param name="kat"></param>
        /// <param name="kraj"></param>
        public Film(string tyt, string rez, int rok, Kategoria kat,string kraj)
        {
            tytul = tyt;
            rezyser = rez;
            rok_prod = rok;
            kategoria = kat;
            kraj_prod = kraj;
            oceny = new List<Ocena>();
        }

        /// <summary>Metoda dodaje ocene do filmu</summary>
        /// <param name="o"></param>
        public void dodaj_Ocene(Ocena o)
        {
            Oceny.Add(o);
            double sum = 0;
            foreach(Ocena o2 in Oceny)
            {
                sum += (double)o2.Nota;

            }
            Srednia = sum / oceny.Count;
            srednia =  Math.Round(Srednia,2);



        }
        /// <summary>Porownanie filmow</summary>
        /// <param name="f"></param>
        public int CompareTo(Film f)
        {
            return Srednia.CompareTo(f.Srednia);
        }

        /// <summary>Nadpisaniem metody ToString</summary>
        public override string ToString()
        {
            return tytul + " " + rok_prod.ToString() + " " + Srednia.ToString() + " " + Oceny.Count + Environment.NewLine;
        }
        

    }
    



}
