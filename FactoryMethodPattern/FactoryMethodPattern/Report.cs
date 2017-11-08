using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class Report : Document
    {
        public Report()
        {
            Pages.Add("Front page");
            Pages.Add("Some Business stuff");
            Pages.Add("Some more Business stuff");
            Pages.Add("a graph of sales");
            Pages.Add("some more Business stuff");
        }
    }
}
