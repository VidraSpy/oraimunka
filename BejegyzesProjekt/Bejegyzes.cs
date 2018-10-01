using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {

        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes()
        {
        szerzo = "";
        tartalom = "";
        likeok = 0;
        letrejott = DateTime.UtcNow.Date;
        szerkesztve = DateTime.UtcNow.Date;
    }

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
        }

        public string Szerzo
        {
            get
            {
                return szerzo;
            }
        }
        public string Tartalom
        {
            get
            {
                return tartalom;
            }
            set
            {
                tartalom = value;
            }
        }
        public int Likeok
        {
            get
            {
                return likeok;
            }
        }
        public DateTime Letrejott
        {
            get
            {
                return letrejott;
            }
        }
        public DateTime Szerkesztve
        {
            get
            {
                return szerkesztve;
            }
        }


        public void Like()
        {
            likeok++;
        }


        public void kiir()
        {
            Console.WriteLine(szerzo + " - " + likeok + " - " + letrejott);
            Console.WriteLine("Szerkesztve: " + szerkesztve);
            Console.WriteLine(tartalom);
        }
    }
}
