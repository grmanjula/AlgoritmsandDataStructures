using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsandDataStructures
{
    class Leader
    {
        public void getLeader()
        {
            int[] input = new int[5] { 23, 3, 56, 2, 12 };
            int Leader = input[input.Length - 1];
            Console.WriteLine(Leader);

            for(int i = input.Length-2; i>-1; i--)
            { 
                if (input[i] > Leader)
                {
                    Leader = input[i];
                    Console.WriteLine(Leader);
                }

            }
        }
    }
}
