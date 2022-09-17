using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Extentions
{
    static class Extention
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static int[] GetValueIndexes(this int[] arr, int num)
        {
            int[] newArr = { };

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == num)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = i;
                }
            }

            return newArr;
        }

        public static bool IsOdd(this int num) => num % 2 == 1;

        public static bool IsContainsDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    return true;
            }
            return false;
        }

        public static int[] GetValueIndexesStr(this string str, char chr)
        {
            int[] newArr = { };

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chr)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = i;
                }
            }

            return newArr;
        }
    }
}
