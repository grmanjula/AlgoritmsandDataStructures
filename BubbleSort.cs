using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace AlgoritmsandDataStructures
{
    class BubbleSort
    {
        public void Sort()
        {
            int[] Arr = new int[15] { 10, 2, 43, 56, 1,23,42,87,98,65,23,41,90,11,9 };

            var swapped = false;

            for (var j = 0; j < Arr.Length; j++)
            {
                for (int i = 0; i < Arr.Length - 1; i++)
                {
                    var element1 = Arr[i];
                    var element2 = Arr[i + 1];
                    swapped = false;

                    if (element1 > element2)
                    {
                        Arr[i] = element2;
                        Arr[i + 1] = element1;
                        swapped = true;
                    }

                }

            }
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int aa in Arr)
                Console.Write(aa + " ");
            Console.Write("\n");

        }
               

        public void swap(int a , int b)
        {

           int temp = b;
            b = a;
            a = temp;

        }

    }
}



