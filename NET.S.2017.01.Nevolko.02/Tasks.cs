using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tasks
{
    public static class Tasks
    {
        #region task1
        public static int GetBalancedIndexOfArray(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            int sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }

            int subsum = 0;
            for (int i = 0; i <= arr.Length-1; i++)
            {
                sum -= arr[i];
                subsum += arr[i];
                
                if(subsum + arr[i+1] == sum) //do not ++i
                {
                    return ++i;
                }
            }
            return -1;
        }
        #endregion
          
        #region task2
        public static string Longest(string str1, string str2)
        {
            if (str1 == null || str2 == null)
            {
                throw new ArgumentNullException();
            }

            CheckStr(str1);
            CheckStr(str2);
            string result = str1 + str2;
            result = RemoveSameSymbols(result);

            char[] buff = result.ToCharArray();
            Array.Sort(buff);
            result = new string(buff);

            return result;
        }

        private static void CheckStr(string str)
        { 
            foreach (var item in str)
            {
                if (item < 97 || item > 122) // 97 - "a" ASCII number, 122 - "z" ASCII number
                {
                    throw new ArgumentException();
                }
            }
        }

        private static string RemoveSameSymbols(string str)
        {
            string str_of_uniqs = "";
            foreach (var item in str)
            {
                if(!str_of_uniqs.Contains(item))
                {
                    str_of_uniqs += item;
                }
            }
            return str = str_of_uniqs;
        }
        #endregion

        #region task3
        public static int InsertIntToInt(int number1, int number2, int i, int j)
        {
            if (i > j || i < 0 || j < 0 || i > 32 || j > 32)
            {
                throw new ArgumentException();
            }
        
             var bit_arr1 = new BitArray(new int[] { number1 });
             var bit_arr2 = new BitArray(new int[] { number2 });

             for (int k = i; k <= j; k++)
             {
                 bit_arr1[k] |= bit_arr2[k];
             }

             int[] buff = new int[1];
             bit_arr1.CopyTo(buff, 0);
             return buff[0];
        }
        #endregion
    }
}
