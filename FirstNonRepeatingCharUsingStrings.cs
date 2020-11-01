using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsandDataStructures
{
    class FirstNonRepeatingCharUsingStrings
    {
        public void findNonRepeatingChar()
        {
            string input = "Seattle";
            string result = string.Empty;
            int count = 0;

            for(int i =0; i<input.Length; i++)
            {
                if (!(result.Contains(input[i])))
                {
                    result = result + input[i];
                    Console.WriteLine(result);
                    
                }
                //if (result.Contains(input[i]))
                //{
                //    count = count + 1;
                //    if (count > 1)
                //    {
                //        result = result.Remove(input[i]);
                //    }
                //}

                Console.WriteLine(result);
                
            }
        }
    }
}
