using System;

namespace WorkshopH
{
    class Qn2
    {
        static void Main()
        {
            string[] s1 = new string[] { "The brown fox", "The brown fox", "The brown fox", "T", "The bras basah complex" };
            string[] s2 = new string[] { "O", "FOX", "bRO", "bRO", "bRO" };

            int length = s1.Length;

            for (int i = 0; i < length; i++)
            {
                if (Qn1.InString(s1[i], s2[i]))
                {
                    Console.WriteLine(FindWord(s1[i],s2[i]));
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
        }

        public static int FindWord(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            int s1Len = s1.Length;
            int s2Len = s2.Length;

            //when performing check on String S1, need to decide which is the last nth position to start
            int last = (s1Len - s2Len);

            for (int i = 0; i <= last; i++)
            {
                if (s2 == s1.Substring(i, s2Len))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
