using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton
{
    /// <summary>
    /// Testclass with inputs
    /// </summary>
    class TestClass
    {
        public static void Main()
        {
            Newtonfunction function1 = new Newtonfunction(3, 27, 4);
            Newtonfunction function2 = new Newtonfunction(3, 27);

            Console.WriteLine(function1.ToString());
            Console.WriteLine(function2.ToString());

            function1.OrderOfRoot = 4;
            Console.WriteLine(function1.ToString());
            function2.PrecisionOfCalculation = 20;
            Console.WriteLine(function2.ToString());

            Console.ReadKey();
        }

    }
}
