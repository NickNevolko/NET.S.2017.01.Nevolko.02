using NUnit.Framework;
using static Tasks3.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.TestsTask2
{
    [TestFixture]
    public class Tasks2Tests
    {
        #region task3 InsertIntToInt
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
        [TestCase(15, 15, 1, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 1, 4, ExpectedResult = 15)]
        [TestCase(-8, -15, 1, 4, ExpectedResult = -6)]
        public int InsertIntToInt_PositiveTest(int first, int second, int startPosition, int finishPosition)
        {
            return InsertIntToInt(first, second, startPosition, finishPosition);
        }

        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 31, 5)]
        public void InsertIntToInt_ThrowsArgumentOutOfRangeException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => InsertIntToInt(first, second, startPosition, finishPosition));
        }

        [TestCase(8, 15, 7, 5)]
        [TestCase(8, 15, 1, 0)]
        public void InsertIntToInt_ThrowsArgumentException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentException>(() => InsertIntToInt(first, second, startPosition, finishPosition));
        }
        #endregion
        #region task2 Longest

        [TestCase("xyaabbbccccdefww", "xxxxyyyyabklmopq", ExpectedResult = "abcdefklmopqwxy")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", ExpectedResult = "abcdefghijklmnopqrstuvwxyz")]
        public static string Longest_ArrayTest(string str1, string str2)
        {
            return Longest(str1, str2);
        }

        [TestCase("DJJHFUJFnk23234r", "xxxxyyyyabklmopq")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "iew((00")]
        public static void Longest_ArgumentOutOfException(string str1, string str2)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Longest(str1, str2));
        }

        [TestCase(null, "xxxxyyyyabklmopq")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", null)]
        public static void Longest_ArgumentNullException(string str1, string str2)
        {
            Assert.Throws<ArgumentNullException>(() => Longest(str1, str2));
        }
        #endregion
        #region task1

        [TestCase(new[] { 1, 2, 3, 4, 3, 2, 1 }, ExpectedResult = 3)]
        [TestCase(new[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new[] {1, 2, 3, 4}, ExpectedResult = -1)]
        public static int GetBalancedIndexOfArray_Testing(int[] array)
        {
            return GetBalancedIndexOfArray(array);
        }

        [TestCase(null)]
        public static void GetBalancedIndexOfArray_ArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => GetBalancedIndexOfArray(array));
        }
        #endregion
    }

}
