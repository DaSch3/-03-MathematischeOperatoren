using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematischeOperatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ein Ausdruck ist eine Rechnung die ein Ergebnis liefert (2 + 2) = 4
            int zahl = 10 / 3;
            int zahl2 = 10 % 3;
            
            Console.WriteLine(zahl);
            Console.WriteLine(zahl2);
            Console.ReadKey();
        }
    }
}
