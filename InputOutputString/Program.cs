using System;

namespace InputOutputString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] line = args[0].ToCharArray();

            char[] arr = SortChars(line); // result of sorting

            // output to console
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != '\0')
                { Console.Write(arr[j]); }
            }

            Console.ReadLine();
        }

        // sorting an array of characters, removing duplicate ones
        static char[] SortChars(char[] line)
        {
            int numberLine = line.Length;
            char[] arr = new char[numberLine];

            for (int i = 0; i < numberLine; i++)
            {
                bool coincidence = false; // repeating character indicator
                char ch = line[i];
                for (int j = 0; j < numberLine; j++)
                {
                    if (i != j)
                    {
                        if (ch == arr[j])
                        {
                            coincidence = true;
                        }
                    }
                }
                if (!coincidence)
                {
                    arr[i] = ch;
                }
            }

            return arr;
        }
    }
}
