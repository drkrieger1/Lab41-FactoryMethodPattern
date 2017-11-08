using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FactoryPattern");

            DocStore mystore = new DocStore();
            Console.WriteLine("What kinda Document would you like?..(Resume || Report)");
            mystore.OrderDocument(Console.ReadLine().ToLower());
            Console.Read();
        }
    }
}
