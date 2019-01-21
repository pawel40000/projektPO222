using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt_PO
{
    /// <summary>
    ///   <para>Klasa ocena przechowujaca note i recenzje udzielona przez uzytkownika</para>
    ///   <para></para>
    /// </summary>
    [Serializable]
    public class Ocena
    {
        private Nota nota;
        private string recenzja;
        private Uzytkownik u;

        /// <summary>recenzja filmu</summary>
        public string Recenzja { get => recenzja; set => recenzja = value; }
        /// <summary>
        ///   <para>nota filmu</para>
        ///   <para></para>
        /// </summary>
        public Nota Nota { get => nota; set => nota = value; }
        public Uzytkownik U { get => u; set => u = value; }

        /// <summary>konstruktor oceny</summary>
        public Ocena()
        {
            recenzja = null;
        }
        /// <summary>konstruktor oceny z uzytkownikiem nota i receznja</summary>
        /// <param name="r"></param>
        /// <param name="uu"></param>
        /// <param name="n"></param>
        public Ocena(string r, Uzytkownik uu, Nota n)
        {
            recenzja = r;
            nota = n;
            u = uu;

        }


    }
}
