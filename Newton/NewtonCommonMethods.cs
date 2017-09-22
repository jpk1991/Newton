using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton
{
    class NewtonCommonMethods
    {
        public void ReadInput()
        {
            Console.WriteLine("Bitte zu berechnende Quadratwurzel eingeben:");
            Console.WriteLine("Radikand: ");
            int radicand = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Gewünschte Präzision der Berechnung (Anzahl Nachkommastellen): ");
            int precision = Int32.Parse(Console.ReadLine());
        }

        public void Print(Newtonfunction function)
        {
            Console.WriteLine(function.ToString());
        }
    }
}
