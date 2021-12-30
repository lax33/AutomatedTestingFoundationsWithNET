using System;
using System.Collections.Generic;

namespace NumberSystemConversion
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int number;
            int baseNumber;

            Console.Write("Enter the number - ");
            while (int.TryParse(Console.ReadLine(), out number) != true)
            {
                Console.WriteLine(" Incorrect data, please re-enter!");
            }

            Console.Write("A base number system - ");
            while (int.TryParse(Console.ReadLine(), out baseNumber) != true ||
                                                                baseNumber < 2 ||
                                                                baseNumber > 20 ||
                                                                baseNumber == 10)
            {
                Console.WriteLine(" Incorrect data, please re-enter!");
            }

            ResultOfTransferToAnotherSystemOutput(number, baseNumber);
            
            Console.ReadLine();


            void ResultOfTransferToAnotherSystemOutput(int numberL, int baseNumberL)
            {
                List<int> list = new List<int>();
                int wholePart = numberL;

                do
                {
                    int remainderDivision = wholePart % baseNumberL;
                    wholePart /= baseNumberL;
                    list.Add(remainderDivision);
                } while (baseNumberL <= wholePart);
                list.Add(wholePart);

                Console.Write("Result - ");

                if (baseNumberL <= 10)
                {
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        Console.Write(list[i]);
                    }
                }
                else
                {
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        switch (list[i])
                        {
                            case 10:
                                Console.Write("A");
                                break;
                            case 11: 
                                Console.Write("B");
                                break;
                            case 12:
                                Console.Write("C");
                                break;
                            case 13:
                                Console.Write("D");
                                break;
                            case 14:
                                Console.Write("E");
                                break;
                            case 15:
                                Console.Write("F");
                                break;
                            case 16:
                                Console.Write("G");
                                break;
                            case 17:
                                Console.Write("H");
                                break;
                            case 18:
                                Console.Write("I");
                                break;
                            case 19:
                                Console.Write("J");
                                break;
                            default:
                                Console.Write(list[i]);
                                break;
                        }
                    }
                }
            }
        }
    }
}
