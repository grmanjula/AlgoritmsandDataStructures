using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AlgoritmsandDataStructures
{
    class PrintAllSubstrings
    {
        String input = "seattle";
        
    

        public void printallSubStrings(String str)
        {
            int n = str.Length;

            // consider all sub-strings starting from i
            for (int i = 0; i < n; i++)
            {
                // consider all sub-strings ending at j
                for (int j = i; j < n; j++)
                {
                    Console.WriteLine("'" + str.Substring(i, j-i+1) + "', ");
                }
            }
        }

     
    }
}
