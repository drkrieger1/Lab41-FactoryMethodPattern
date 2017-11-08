using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class DocumentCreator
    {
        Document document = new Document();

        public static Document CreateDocument(string type)
        {
            Document document = new Document();

            switch (type)
            {
                case "resume":
                    Console.WriteLine("resume is on its way");
                    document = new Resume();
                    break;
                case "report":
                    Console.WriteLine("report is on its way");
                    document = new Report();
                    break;
            }
            return document;
        }
       
    }
}

