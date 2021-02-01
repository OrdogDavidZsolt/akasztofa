using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akasztofa
{
    class Program
    {
        static void akasztofa() {
            string szo = "ALMA";
            string allas = "";
            string ideiglenes = "";
            int szamolo = 0;

            for (int i = 0; i < szo.Length; i++)
            {
                allas+="_";
            }
            bool megyAJatek = true;
            Console.WriteLine(allas);
            while (megyAJatek) {
                Console.WriteLine("Választott betű:");
                char betu = Console.ReadKey().KeyChar;
                szamolo++;
                Console.WriteLine();
                for (int i = 0; i < szo.Length; i++)
                {
                    if (betu == szo[i]) { ideiglenes += szo[i]; }
                    else { ideiglenes += allas[i]; }
                }
                allas = ideiglenes;
                ideiglenes = "";
                if (allas.Contains("_")) { Console.WriteLine(allas+" próbálkozások száma: "+szamolo); if (szamolo >= szo.Length + 5) { Console.WriteLine("Vesztettél! A szó a(z) "+szo+" volt!");megyAJatek = false; } }
                else { Console.WriteLine(allas); Console.WriteLine("Nyertél a szó a(z) " + szo + " volt!"); megyAJatek = false; }
            }
        }

        static void Main(string[] args)
        {
            akasztofa();
            Console.ReadKey();
        }
    }
}
