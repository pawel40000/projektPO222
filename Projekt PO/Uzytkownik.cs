using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace Projekt_PO
{
    /// <summary>
    ///   <para>Klasa uzytkownik dziedzicząca po osobie(imie i nazwisko)</para>
    ///   <para></para>
    /// </summary>
    [Serializable]
    public class Uzytkownik: Osoba
    {
        private string nick;

        /// <summary>nick uzytkownika</summary>
        public string Nick { get => nick; set => nick = value; }
        /// <summary>Pusty konstruktor uzytkownika</summary>
        public Uzytkownik() : base()
        {

        }
        /// <summary>konstruktor uzytkownika z nickiem, imieniem i nazwiskiem</summary>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <param name="ni"></param>
        public Uzytkownik(string i, string n, string ni):base(i,n)
        {
            nick = ni;

        }
       
    }
}
