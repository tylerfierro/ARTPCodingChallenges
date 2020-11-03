using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            //If we list all the natural numbers below 10
            //that are multiples of 3 or 5, we get 3, 5,
            //6 and 9.The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.
            //Remember to commit changes to the repository.Submit your repo url to this assignment
            int sum = 0;

            for (int s = 1; s < 10; s++)

            {
                if (s % 3 == 0 || s % 5 == 0)
                    sum += s;
            }
            Console.WriteLine(sum);

            for (int s = 1; s < 1000; s++)

            {
                if (s % 3 == 0 || s % 5 == 0)
                    sum += s;
            }
            Console.WriteLine(sum);
        }
    }
}
