using System;

namespace WorkshopH
{
    class Qn1
    {
        static void Main()
        {
            string[] s1 = new string [] { "The brown fox", "The brown fox", "The brown fox", "T", "The bras basah complex"};
            string[] s2 = new string [] {"O","FOX","bRO", "bRO", "bRO"};

            int length = s1.Length; 

            for (int i = 0; i < length; i++)
            {
                    Console.WriteLine(InString(s1[i], s2[i]));
            }

        }


        // This method check if Sting S2 is a subset of String S1
        static bool InString(string s1, string s2)
        {
        return true;
        }
    }
}
