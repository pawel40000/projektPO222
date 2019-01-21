using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{
    /// <summary>klasa przechowuje imie i nazwisko osoby</summary>
    [Serializable]
    

    public abstract class Osoba
    {
        private string imie;
        private string nazwisko;

        /// <summary>
        ///   <para>nazwisko osoby</para>
        ///   <para></para>
        /// </summary>
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        /// <summary>
        ///   <para>imie osoby</para>
        ///   <para></para>
        /// </summary>
        public string Imie { get => imie; set => imie = value; }

        /// <summary>konstruktor osoby z imieniem i nazwiskiem</summary>
        /// <param name="i"></param>
        /// <param name="n"></param>
        public Osoba(string i, string n)
        {
            imie = i;
            nazwisko = n;

        }
        /// <summary>
        ///   <para>pusty konstruktor osoby</para>
        ///   <para></para>
        /// </summary>
        public Osoba()
        {
            imie = "";
            nazwisko = "";

        }
    }
}
