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
            //task 1
            int[] x = { 1, 2, 3, 4, 3, 2, 1 };
            Console.WriteLine(Tasks.GetBalancedIndexOfArray(x));

            int[] y = { 1, 100, 50, -51, 1, 1 };
            Console.WriteLine(Tasks.GetBalancedIndexOfArray(y));

            //task 2
            Console.WriteLine(Tasks.Longest("xyaabbbccccdefww", "xxxxyyyyabklmopq"));
            Console.WriteLine(Tasks.Longest("xyaabbbccccdefww", "xyaabbbccccdefww"));

            //task3
            Console.WriteLine(Tasks.InsertIntToInt(8,15,0,0));
            Console.WriteLine(Tasks.InsertIntToInt(0, 15, 30, 30));
            Console.WriteLine(Tasks.InsertIntToInt(0, 15, 0, 30));
            Console.WriteLine(Tasks.InsertIntToInt(15, -15, 0, 4));
            Console.WriteLine(Tasks.InsertIntToInt(15, int.MaxValue, 3, 5));
            
        }
    }
}
