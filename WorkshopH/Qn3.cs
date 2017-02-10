using System;

namespace WorkshopH
{
    class Qn3
    {
        static string[,] table = new string[,] { {"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F"},
                                                 {"0","1","2","3","4","5","6","7","8","9","10","11","12","13","14","15"} };
        static void Main()
        {
            string input = GetInputNChk();
            DeriveHex(input);
        }

        static string GetInputNChk()
        {
            bool isInteger = false;
            string input;
            do
            {
                Console.Write("Please enter an integer number: ");
                input = Console.ReadLine();

                int number;
                isInteger = Int32.TryParse(input, out number);
            } while (!isInteger);

            return input;
        }


        static void DeriveHex(string input)
        {
            int number = Convert.ToInt32(input);
            int count = 0;
            int temp = number;

            while (temp != 0)
            {
                count++;
                temp = temp/16;
            }
            int arraysize = count;

            // First remainder is last digit of hexadecimal. That's how hexa is derived, go google if unsure
            int[] arrayremainder = new int[arraysize];
            for (int i = arraysize-1; i >= 0; i--)
            {
                int remainder = number % 16;
                arrayremainder[i] = remainder;
                number = number / 16;
            }

            // number of remainder obtained = number of hexadecimal digits
            string[] hex = new string[arraysize];

            // compare your reaminder against hexadecimal table and store that in a array
            for (int j = 0; j < arraysize; j++)
            {
                for (int k=0; k<=15;k++)
                {
                    if (arrayremainder[j] == Convert.ToInt32(table[1, k]))
                    {
                        hex[j] = table[0, k];
                        break;
                    }
                }

            }

            // print the hex array 
            for (int m = 0; m < arraysize; m++)
            {
                Console.Write(hex[m]);
            }
            Console.WriteLine();

        }

    }
}
