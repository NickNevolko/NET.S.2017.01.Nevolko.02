using System;
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
    }
}
