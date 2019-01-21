using Projekt_PO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glowny
{
    [Serializable]
    class Baza_uzytkownikow
    {
        private List<Uzytkownik> lista_uzytkownikow;


        public Baza_uzytkownikow()
        {
            Lista_uzytkownikow = new List<Uzytkownik>();
        }

        public List<Uzytkownik> Lista_uzytkownikow { get => lista_uzytkownikow; set => lista_uzytkownikow = value; }

        public void Dodaj(Uzytkownik u)
        {
            Lista_uzytkownikow.Add(u);
        }
    }
}
