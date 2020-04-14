using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReader
{
    public class SearchTerms
    {
        public string term { get; set; }
       // public int number = 0;

            public int number { get; set; }

        public SearchTerms (string y, int x)
        {
            number = x;
            term = y;
        }

    }
    

}
