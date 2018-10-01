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
        private int likeok = 0;
        private DateTime letrejott = DateTime.UtcNow.Date;
        private DateTime szerkesztve = DateTime.UtcNow.Date;

        public Bejegyzes(string szerzo, string tartalom, int likeok, DateTime letrejott, DateTime szerkesztve)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = likeok;
            this.letrejott = letrejott;
            this.szerkesztve = szerkesztve;
        }

        public string Szerzo
        {
            get
            {
                return szerzo;
            }
        }
        public string getTartalom
        {
            get
            {
                return tartalom;
            }
        }
        public string setTartalom
        {
            set
            {
                tartalom = value;
            }
        }
        public int getLikeok
        {
            get
            {
                return likeok;
            }
        }
        public DateTime getLetrejott
        {
            get
            {
                return letrejott;
            }
        }
        public DateTime getSzerkesztve
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
