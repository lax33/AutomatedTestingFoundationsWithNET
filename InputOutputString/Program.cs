using System;

namespace InputOutputString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char[] line = args[0].ToCharArray();

            char[] arr = SortChars(line); // result of sorting

            foreach (var ar in arr)
            {
                Console.Write(ar);
            }

            Console.WriteLine();

            Console.WriteLine(AmountDiffirentChar(arr));

            Console.WriteLine(AmountMaxEquelChar(line));

            Console.WriteLine(AmountMaxEquelNumber(line));

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

        private static int AmountDiffirentChar(char[] arr)
        {
            int num = 0;
            foreach (var arrM in arr)
            {
                if (arrM != '\0') num++;
            }

            return num;
        }

        private static int AmountMaxEquelChar(char[] line)
        {
            return MaxEqual(line, false);
        }

        private static int AmountMaxEquelNumber(char[] line)
        {
            return MaxEqual(line, true);
        }

        private static int MaxEqual(char[] line, bool numberOrChar)
        {
            int equal = 0;

            int numberLine = line.Length;

            for (int i = 0; i < numberLine; i++)
            {
                int eqHelp = 1;
                char ch = line[i];

                if (numberOrChar)  // if search numbers
                {
                    if (!int.TryParse(ch.ToString(), out _)) continue;

                    for (int j = 0; j < numberLine; j++)
                    {
                        if (i != j)
                        {
                            if (ch == line[j])
                            {
                                eqHelp++;
                            }
                        }
                    }
                }
                else              // if search chars
                {
                    if (int.TryParse(ch.ToString(), out _)) continue;

                    for (int j = 0; j < numberLine; j++)
                    {
                        if (i != j)
                        {
                            if (ch == line[j])
                            {
                                eqHelp++;
                            }
                        }
                    }
                }

                if (eqHelp > equal && eqHelp != 1) equal = eqHelp;
            }

            return equal;
        }
    }
}