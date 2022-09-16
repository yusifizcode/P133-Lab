using System;

namespace _09._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task - 1
            //Verilmiş string dəyərində verilmiş char-ın hansı index-də yerləşdiyini tapıb qaytaran metod.
            //Misalçün metodu call edib "salam" və 'l' dəyərləri göndərsək geriyə 2 qaytarmalıdır
            //amma char həmin string-də olmasa - 1 qaytarmalıdır.


            //var word = Console.ReadLine();
            //var chr = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine($"index: {CharIndex(word,chr)}");
            #endregion

            #region Task - 2
            //Verilmiş  ədədin ən yaxın aşağı kökaltısını tapıb qaytaran metod.

            //Console.WriteLine(FindBelowSqrt(29));
            #endregion

            #region Task - 3
            //Verilmiş integer array-in  bütün elementlərini  musbet şəkildə qaytaran metod.
            //Misalçün parametr olaraq { 1,-4,9,-8}
            //dəyərləri olan array daxil edilsə arqument kimi metod bizə { 1,4,9,8}
            //dəyərləri olan array qaytarmalıdır.

            //int[] arr = { 1, 24, -34, 56, -46 };

            //foreach (var item in ChangePositive(arr))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Task - 4
            //Verilmiş string variable-ın dəyərini içərisində hər söz arasında bir boşluq gələcək
            //vəzyətə salan metod.
            //Misalçün bu metoda dəyəri " salam,      Dunya" olan string variable göndərsək həmin metod
            //bu variable - ın dəyərini dəyişib "salam, Dunya" vəziyyətinə salmalıdır.
            //Yəni, göndərilən string-də sözlər arasında birdən çox boşluq ola bilər, onu hər söz arasında
            //bir boşluq olan vəziyyətə  salan metod yazırsınız.
            //Metod geriyə dəyər qaytarmır!

            //string sentence = "heloo,         world";

            //ChangeString(sentence);
            #endregion

            #region Task - 5
            //Worker Classimiz olur.
            //Ishcinin adini, soyadini, yashini saat bashi qazandigi pul
            //ve bu ay nece saat ishlediyini bildiren fieldler olur.
            //Maashi hesablayan methodu olur.Methodda isçinin bu ay qazanacagi meblegi geri qaytarir.
            //Ishcinin adini, soyadini, yashini, maashini daxil etmeden classdan instance almak olmasın.
            //Eger ishcinin yashi 18 - den azdirsa ekrana "ishlemek ucun minimum yashi 18 
            //olmalidir" yazısı olsun.

            Worker worker = new Worker("Abbas", "Abbasov", 45, 34);
            worker.Hour = 45;

            string name = "Memmed";
            Worker worker1 = new Worker(name, "Memmedov",18,30);


            if(worker.CalcSalary() != -1)
            {
                Console.WriteLine(worker.CalcSalary());
            }
            else
            {
                Console.WriteLine("hele ishileye bilmez");
            }
            #endregion
        }

        static int CharIndex(string str, char chr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == chr)
                    return i;
            }
            return -1;
        }

        static int FindBelowSqrt(int num)
        {
            int result = 0;
            for (int i = 0; i*i < num; i++)
            {
                result = i;
            }
            return result;
        }

        static int[] ChangePositive(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0 - numbers[i];
                }
            }
            return numbers;
        }

        static void ChangeString(string sentence)
        {
            string[] arr = sentence.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string text = String.Join(" ", arr);
            Console.WriteLine(text);
        }


    }
}
