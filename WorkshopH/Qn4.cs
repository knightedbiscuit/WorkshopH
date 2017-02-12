using System;

namespace WorkshopH
{
    class Qn4
    {
        static void Main()
        {
            Console.Write("Enter your string of text: ");
            string s = Console.ReadLine();
            Console.Write("Enter the character to be replaced: ");
            char c1 = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Enter the character to be used as replacement: ");
            char c2 = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine(Substitute(s, c1, c2));
       }


       static string Substitute(string s, char c1, char c2)
        {
            string c1s = c1.ToString(); 
            string c2s = c2.ToString();
            int stringLength = s.Length;
            string[] newWordArr = new string[stringLength];
            string[] oldWordArr = new string[stringLength];

            // convert string into a array
            for (int i = 0; i < stringLength; i++)
            {
                oldWordArr[i] = s.Substring(i, 1);
            }

            // Compare old and new word and replace 
            for (int j = 0; j < stringLength; j++)
            {
                if (oldWordArr[j] == c1s)
                {
                    newWordArr[j] = c2s;
                }
                else {
                    string temp = oldWordArr[j];
                    newWordArr[j] = temp;
                }           
            }

            string newWord = string.Join("", newWordArr);

            return newWord;
        }

    }
}
