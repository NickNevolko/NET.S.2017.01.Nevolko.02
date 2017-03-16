using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 3, 2, 1 };
            Console.WriteLine(Tasks.GetBalancedIndexOfArray(x));

            int[] y = { 1, 100, 50, -51, 1, 1 };
            Console.WriteLine(Tasks.GetBalancedIndexOfArray(y));


            Console.WriteLine(Tasks.Longest("xyaabbbccccdefww", "xxxxyyyyabklmopq"));
            Console.WriteLine(Tasks.Longest("xyaabbbccccdefww", "xyaabbbccccdefww"));
        }
    }
}
