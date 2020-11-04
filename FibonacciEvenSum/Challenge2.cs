using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Challenge2
    {
        static void Main(string[] args)
        {
            //Each new term in the Fibonacci sequence is generated
            //by adding the previous two terms.By starting with
            //1 and 2, the first 10 terms will be:
            //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
            int nbr = 0;
            int previousnbr = 0;
            int sumnbrs = 0;

            while (nbr <= 4000000)
            {
                if (nbr % 2 == 0)
                {
                    sumnbrs += nbr;
                }
                int previous2 = nbr;
                if (nbr <= 1)
                {
                    nbr++;
                }
                else
                {
                    nbr += previousnbr;
                }

                previousnbr = previous2;
            }

            Console.WriteLine($"Your total is: {sumnbrs}");
            Console.ReadKey();
        }
    }
}
