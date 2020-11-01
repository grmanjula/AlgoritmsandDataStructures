using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsandDataStructures
{
    class ThirdLargestInArray
    {
        int[] Arr = new int[10] { 8, 98, 34, 56, 32, 9, 12, 33, 44, 22 };
        int first;
        int second;
        int third;

        public void Print()
        {
            Console.WriteLine("The elements are:");
            for (int i = 3; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " " );
            }

        }

        public int thirdLargest()
        {
            first = Arr[0];
            second = Arr[1];
            if(second > first)
            {
                second = Arr[0];
                first = Arr[1];
            }

            third = Arr[2];
            if(third > first)
            {
                int temp = first;
                
            }
            else if(third > second)
            {

            }

            for (int i = 3; i < Arr.Length; i++)
            {
                insert(Arr[i]);
            }

            return third;
        }

        public void insert(int i)
        {
            //{ 8, 98, 34, 56, 32, 9, 12, 33, 44, 22 };
            if (i> first)
            {
                third = second;
                second = first;
                first = i;
            }
            else if(i > second)
            {
                third = second;
                second = i;
            }
            else if(i > third)
            { 
                third = i;
            }
        }
    }
}
