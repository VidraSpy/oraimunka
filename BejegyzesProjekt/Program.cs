using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace BejegyzesProjekt
{
    class Program
    {
        Random r = new Random();
        static void Main(string[] args)
        {
            List<Bejegyzes> lista = new List<Bejegyzes>();
            var bejegyzes = new Bejegyzes();
            var bejegyzes2 = new Bejegyzes();
            Console.Write("Írja be hogy hány bejegyzést szeretne írni! ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var bejegyzes1 = new Bejegyzes();
            }
            Console.Write("Második bejegyzés módosítása: ");
            bejegyzes2.Tartalom = Console.ReadLine();
            foreach (var k in lista)
            {
                
            }            
            Console.ReadKey();

        }
    }
}
