using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt_PO
{
    /// <summary>
    ///   <para>Klasa administrator dziedziczaca po osobie</para>
    ///   <para></para>
    /// </summary>
    [Serializable]
    public class Administrator: Osoba
    {
        private string iD;
        private string email;
        private static int nr = 0;

        /// <summary>id administatora</summary>
        public string ID { get => iD; set => iD = value; }
        /// <summary>emial admininstratora</summary>
        public string Email { get => email; set => email = value; }
        /// <summary>konstruktor z emailem, imieniem i nazwiskiem</summary>
        /// <param name="e"></param>
        /// <param name="i"></param>
        /// <param name="n"></param>
        public Administrator(string e, string i, string n): base(i,n)
        {
            email = e;
            nr++;
            iD = "admin/" + nr.ToString();

        }

    }

}
