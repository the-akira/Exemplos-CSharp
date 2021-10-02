using System;
using System.Collections.Generic;
using System.Linq;

namespace Where
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dates = new List<int> { 1970, 1975, 1965, 1999, 1992, 1982, 1977 };

            IEnumerable<int> query = dates.Where(date => date > 1970);  
            
            foreach (int date in query)
                Console.WriteLine(date);          
        }
    }
}