using System;

namespace _01._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task - 1
            /*            byte point = 87;

                        if (point > 0 && point < 101)
                        {
                            if (point <= 100 && point > 90)
                            {
                                Console.WriteLine("A");
                            }
                            else if (point <= 90 && point > 80)
                            {
                                Console.WriteLine("B");
                            }
                            else if (point < 51)
                            {
                                Console.WriteLine("kesildiniz");
                            }
                        }*/
            #endregion

            #region Task - 2
            /*            int sahe = 0;
                        int perimetr = 0;
                        int a = 12;
                        int b = 13;

                        sahe = a * b;
                        perimetr = (a + b)*2;

                        Console.WriteLine("Sahe - " + sahe);
                        Console.WriteLine("Perimetr - " + perimetr);*/
            #endregion

            #region Task - 3
            /*            for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Hello world!");
                        }*/
            #endregion

            #region Task - 4
            /*            int sum = 0;
                        for (int i = 0; i <= 100; i++)
                        {
                            if(i % 2 == 0)
                            {
                                sum += i;
                            }
                        }
                        Console.WriteLine(sum);*/
            #endregion

            #region Task - 5
            /*            int a = 5;
                        int fact = 1;
                        for (int i = 1; i <= a; i++)
                        {
                            fact *= i;
                        }
                        Console.WriteLine(fact);*/
            #endregion

            #region Task - 6
            /*            int a = 345;
                        int module = 0;
                        while (a > 0)
                        {
                            module = a % 10;
                            Console.WriteLine(module);
                            a = (a - module) / 10;
                        }*/

            #endregion

            #region Task - 7

            /*            int a = 234;
                        int count = 0;
                        for (int i = 1; i < a; i++)
                        {
                            if(a % i == 0)
                            {
                                count++;
                            }
                        }

                        if (count > 1)
                            Console.WriteLine("murekkebdir");
                        else
                            Console.WriteLine("sade");*/


            #endregion

            #region Task - 8
            /*            int a = 23;
                        int module = 0;
                        int sum = 0;
                        while (a > 0)
                        {
                            module = a % 10;
                            a = (a - module) / 10;
                            module = module * module * module;
                            sum+=module;
                        }

                        Console.WriteLine(sum);*/
            #endregion

            #region Task - 9
            /*            int n = 2;
                        int m = 20;
                        int count = 0;
                        for (int i = n; i <= m; i++)
                        {
                            if(i % 4 == 0)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);*/
            #endregion

            #region Task - 10
            /*            int a = 20;
                        int count = 0;
                        for (int i = 1; i < a; i++)
                        {
                            if(a % i == 0)
                                count++;
                        }

                        Console.WriteLine(count);*/
            #endregion

            #region Task - 11
/*            int a = 98732984;
            int module = 0;
            int bigNum = 0;
            int count = 0;
            int num = a;
            while (a > 0)
            {
                module = a % 10;
                if (bigNum < module)
                {
                    bigNum = module;
                }
                a = (a - module) / 10;

            }
            Console.WriteLine(bigNum);

            while (num > 0)
            {
                module = num % 10;
                if(module == bigNum)
                    count++;
                num = (num - module) / 10;

            }
            Console.WriteLine(count);*/
            #endregion
        }
    }
}
