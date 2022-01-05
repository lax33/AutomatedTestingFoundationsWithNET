using System;
using System.Linq;

namespace InputOutputString
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberArgs = args.Length;

            char[] line = args[0].ToCharArray();
            int numberLine = line.Length;
            char[] arr = new char[numberLine];
            
            for (int i = 0; i < numberLine; i++)
            {
                bool coincidence = false;
                char ch = line[i];
                for (int j = 0; j < numberLine; j++)
                {
                    if (i != j)
                    {
                        if (ch == line[j])
                        {
                            coincidence = true;
                        }
                    }
                    
                }

                if (!coincidence)
                {
                    arr[i] = line[i];
                }
            }

            
            for (int i = 0; i < numberLine; i++)
            {
                Console.WriteLine(args[i]);
            }

            Console.ReadLine();
        }
    }
}
