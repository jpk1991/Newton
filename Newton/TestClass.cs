using System;

namespace Newton
{
    /// <summary>
    /// Testclass with inputs
    /// </summary>
    class TestClass
    {
        public static void Main()
        {
            Root root1 = new Root(2, 9);
            Root root2 = new Newton.Root(4, 16);
            Root root3 = new Newton.Root(4);
            Root root4 = new Newton.Root(9);

            Newtonfunction newt1 = new Newtonfunction(root1);
            Newtonfunction newt2 = new Newtonfunction(root2);
            Newtonfunction newt3 = new Newtonfunction(root3);
            Newtonfunction newt4 = new Newtonfunction(root4);

            Console.WriteLine("Root root1 = new Root(2, 9);");
            Console.WriteLine(root1.ToString());
            Console.WriteLine(newt1.ToString());
            Console.WriteLine("Root root2 = new Newton.Root(4, 16);");
            Console.WriteLine(root2.ToString());
            Console.WriteLine(newt2.ToString());
            Console.WriteLine("Root root3 = new Newton.Root(4);");
            Console.WriteLine(root3.ToString());
            Console.WriteLine(newt3.ToString());
            Console.WriteLine("Root root4 = new Newton.Root(9);");
            Console.WriteLine(root4.ToString());
            Console.WriteLine(newt4.ToString());


            Console.ReadKey();
        }

    }
}
