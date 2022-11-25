using System;

namespace ConsoleApp11
{
    class Program
    {


        static void Main(string[] args)
        {



            int[] mas = new int[5] { 1, 4, 2, 3, 5 };
            int[] masi = new int[5] { 6, 8, 7, 9, 5 };
            // Сортировка по возростанию
            Array.Sort(mas); 
            foreach (int i in mas)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Array.Sort(masi, SortDescending); 
            //Сортировка по убыванию
            foreach (int i in masi)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            int[] a = ConcatArrays(mas, masi); //объединили массивы
            foreach (int i in a)
            {
                Console.Write($"{i} ");
            }
        }

        static int SortDescending(int x, int y)
        {
            if (x < y)

                return 1;

            if (x == y)

                return 0;

            return -1;
        }

        static int[] ConcatArrays(int[] mas, int[] masi)
        {
            int[] a = new int[mas.Length + masi.Length];
            for (int i = 0; i < mas.Length; i++) 
                a[i] = mas[i];
            for (int i = mas.Length; i < mas.Length + masi.Length; i++) 
                a[i] = masi[i - mas.Length]; 
            return a;


        }
    }
}

