using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
     public abstract class DocumentStore
    {
        public Document OrderDocument(string type)
        {
            Document document = null;
            document = DocumentCreator.CreateDocument(type);
            document.Print();
            return document;
        }
    }
}
