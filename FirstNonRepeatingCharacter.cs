using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsandDataStructures
{
    class FirstNonRepeatingCharacter
    {
        public void findFirstNRC()
        {
            string input = "Seattle";
            StringBuilder outputstring = new StringBuilder(input);
            //outputstring = StringBuilder.;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i =0; i< input.Length; i++)
            {
                if(dict.ContainsKey(input[i]))
                {
                    dict[input[i]] = dict[input[i]] + 1; 
                }
                else
                {
                    dict.Add(input[i], 1);
                }
            }

            for (int j =0; j< input.Length; j++)
            {
                if (dict.ContainsValue(1))
                {
                    Console.WriteLine(input[j]);
                    return;
                }
            }

            //foreach (KeyValuePair<char,int> pair in dict)
            //{
            //    if(pair.Value== 1)
            //    {
            //        Console.WriteLine(pair.Key);
            //    }
            //}

        }
    }
}
