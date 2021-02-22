using System;
using System.Linq;

namespace FindMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = "y";
            while (userInput == "y")
            {
                Random randomize = new Random();
                string arrayNumbers = string.Empty;

                //Insert random 9 numbers into array
                int[] numberArray = new int[9];
                for (int i = 0; i < 9; i++)
                {
                    bool noNewNumber = true;
                    while (noNewNumber)
                    {
                        int randomInt = randomize.Next(1, 11);
                        if (!numberArray.Contains(randomInt))
                        {
                            numberArray[i] = randomInt;
                            arrayNumbers = $"{arrayNumbers}[{randomInt}]";
                            noNewNumber = false;
                        }
                    }
                }
                Console.WriteLine($"Array Numbers are: {arrayNumbers}");

                //Calculate missing number
                int arraySum = numberArray.Sum();
                int arrayLength = numberArray.Length + 1;
                int actualSum = (arrayLength * (arrayLength + 1)) / 2;
                int missingNumber = actualSum - arraySum;


                Console.WriteLine($"Missing number id: {missingNumber}");
                Console.WriteLine("Again? ( y / n )");
                userInput = Console.ReadLine();
            }
            
        }
    }
}
