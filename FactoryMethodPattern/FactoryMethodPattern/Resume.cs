using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class Resume : Document
    {
        public Resume()
        {
            Pages.Add("Coverletter");
            Pages.Add("Refrences");
            Pages.Add("Work history");
            Pages.Add("summary");
        }
    }
}
