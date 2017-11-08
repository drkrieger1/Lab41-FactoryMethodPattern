using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class DocStore : DocumentStore
    {
        public DocStore()
        {
            Console.WriteLine("Welcome to the doc store");
        }
    }
}
