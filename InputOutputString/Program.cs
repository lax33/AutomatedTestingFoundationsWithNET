using System;

namespace InputOutputString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char[] line = args[0].ToCharArray();

            char[] arr = SortChars(line); // result of sorting

            // output to console the new string 
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != '\0')
                { Console.Write(arr[j]); }
            }

            Console.WriteLine();
            Console.WriteLine(AmountDiffirentChar(arr));

            Console.WriteLine(AmountMaxEquelChar(arr));

            Console.ReadLine();
        }

        // sorting an array of characters, removing duplicate ones
        private static char[] SortChars(char[] line)
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

        private static int AmountDiffirentChar(char[] line)
        {
            int diff = 0;
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
                    diff++;
                }
            }

            return diff ;
        }

        private static int AmountMaxEquelChar(char[] line)
        {
            int eqChar=0;
            int numberLine = line.Length;
            char[] arr = new char[numberLine];

            for (int i = 0; i < numberLine; i++)
            {
                int r;
                bool coincidence = false; // repeating character indicator
                char ch = line[i];
                
                if (int.TryParse(ch.ToString(), out r)) continue;

                for (int j = 0; j < numberLine; j++)
                {
                    if (i != j)
                    {
                        if (ch == arr[j])
                        {
                            eqChar++;
                        }
                    }
                }
                //if (coincidence)
                //{
                //    eqChar++;
                //}
            }

            return eqChar ;
        }

        private static int AmountMaxEquelNumber(char[] line)
        {
            int eqNum=0;

            int numberLine = line.Length;
            char[] arr = new char[numberLine];

            for (int i = 0; i < numberLine; i++)
            {
                int r;
                bool coincidence = false; // repeating character indicator
                char ch = line[i];

                if (!int.TryParse(ch.ToString(), out r)) continue;

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
                if (coincidence)
                {
                    eqNum++;
                }
            }

            return eqNum;
        }
    }
}