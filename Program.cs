using System;

namespace AlgoritmsandDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
//            ThirdLargestInArray third = new ThirdLargestInArray();
//            third.Print();
//            Console.WriteLine("The third largest element is " + third.thirdLargest());

///*            FirstNonRepeatingCharacter f = new FirstNonRepeatingCharacter();
//            f.findFirstNRC();
//            FirstNonRepeatingCharUsingStrings f2 = new FirstNonRepeatingCharUsingStrings();
//            f2.findNonRepeatingChar();
// */

//            Leader l1= new Leader();
//            l1.getLeader();
            //BubbleSort b = new BubbleSort();
            //b.Sort();
            //Console.ReadKey();
            PrintAllSubstrings p = new PrintAllSubstrings();
            //p.printSubStrings();
            // p.printallSubStrings("seattle");
            //p.printallSubStrings("Amazon");
            AnagramsUsingDictionary a = new AnagramsUsingDictionary();
            a.areAnagrams("iceman", "cinema");
            Console.ReadKey();
        }
    }
}
