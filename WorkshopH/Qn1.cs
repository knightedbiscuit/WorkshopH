using System;

namespace WorkshopH
{
    class Qn1
    {
        static void Main()
        {
            string[] s1 = new string [] {"The brown fox", "The brown fox", "The brown fox", "T", "The bras basah complex"};
            string[] s2 = new string [] {"O","FOX","bRO", "bRO", "bRO"};

            int length = s1.Length; 

            for (int i = 0; i < length; i++)
            {
                    Console.WriteLine(InString(s1[i], s2[i]));
            }
        }

        // This method check if Sting S2 is a subset of String S1
        // check the entire S2 against a sub.string of S1. Knowing the length of S2
        // will allow us to determine the length of S1 to be carved out as a substring to be checked
        // The checking will start from left to right and terminate the moment S2 can be matched to a substring of S1
         
        public static bool InString(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            int s1Len = s1.Length;
            int s2Len = s2.Length;

            //when performing check on String S1, need to decide which is the last nth position to start
            int last = (s1Len-s2Len);

            for (int i = 0; i <= last; i++)
            {
                if (s2 == s1.Substring(i, s2Len))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
