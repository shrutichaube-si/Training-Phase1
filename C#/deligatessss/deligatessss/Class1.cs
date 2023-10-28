using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace deligatessss
{
    
        public class NumberDisplay
        {
            public void FormatCurrency(double number)
            {
            Console.WriteLine(string.Format("${0:0.00}", number));
            }
        public void FormatPercantage(double number)
        {
            Console.WriteLine(string.Format("{0:0.00}%", number));
         }
 
        }
    }

