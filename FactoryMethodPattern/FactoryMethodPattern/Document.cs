using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class Document
    {
        public string Type { get; set; }
        public List<string> Pages = new List<string>();

        public void Print()
        {
            Console.WriteLine("Printing your documents... \n");
            foreach(string page in Pages)
            {
                Console.WriteLine(page);
            }
        }
    }
}
