using System;
using System.Security.Cryptography.X509Certificates;

namespace _08._Letters_Change_Numbers__not_included_in_final_score_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);//"A12b s17G"
            double sum = 0;

            foreach (string item in input)
            {
                char firstLetter = item[0];//A
                char lastLetter = item[^1];//b
                string numAsAString = item[1..^1];//12
                double numFromString = double.Parse(numAsAString);

                if (char.IsUpper(firstLetter))
                {
                    int positionOfTheLetter = firstLetter - 64;
                    numFromString /= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstLetter - 96;
                    numFromString *= positionOfTheLetter;
                }
                if (char.IsUpper(lastLetter))
                {
                    int positionOfTheLetter = lastLetter - 64;
                    numFromString -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastLetter - 96;
                    numFromString += positionOfTheLetter;
                }
                sum += numFromString;
            }
            Console.WriteLine($"{sum:f2}");

        }
    }
}
