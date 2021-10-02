using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList frutas = new ArrayList();
            frutas.Add("uva");
            frutas.Add("maçã");
            frutas.Add("abacate");
            frutas.Add("laranja");
            frutas.Add("pêssego");
            frutas.Add("goiaba");
            frutas.Add("figo");

            IEnumerable<string> query = frutas.Cast<string>().OrderBy(fruta => fruta).Select(fruta => fruta);   
            foreach (string fruta in query)
            {
                Console.WriteLine(fruta);
            }       
        }
    }
}