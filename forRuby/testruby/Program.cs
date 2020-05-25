using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace testruby
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Random element = new Random();
            int elements_int = element.Next(1, 9);

            Random linesnumber = new Random();

            int lines_number_int = linesnumber.Next(4, 10);


          

            Row row = new Row(elements_int, lines_number_int);

            



        }

        
    }
}
