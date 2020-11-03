using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsandDataStructures
{
    class AnagramsUsingDictionary
    {
        public void areAnagrams(string s1, string s2)
        {

            if(s1.Length != s2.Length)
            {
                Console.WriteLine("Not Anagrams");
                return;
            }

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i=0; i < s1.Length; i++)
            {
                if (dict.ContainsKey(s1[i]))
                {
                    dict[s1[i]] = dict[s1[i]] + 1;
                }
                else
                {
                    dict.Add(s1[i], 1);
                    Console.WriteLine(s1[i]);
                }
            }

            for (int j=0; j < s2.Length; j++)
            {
                if(dict.ContainsKey(s2[j]))
                {
                    //dict[s1[j]] = dict[s1[j]] -1;
                    if(dict[s2[j]] == 1)
                    {
                        dict.Remove(s2[j]);
                    }
                    else
                    {
                        dict[s2[j]] = dict[s2[j]] - 1;
                    }

                }
                else
                {
                    Console.WriteLine("Not Anagrams");
                    return;
                }

            }

            if(dict.Count  > 0)
            {
                Console.WriteLine("Not Anagrams");
            }
            else
            {
                Console.WriteLine("Anagrams");
            }


        }
    }
}
