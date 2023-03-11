using System;
using System.Threading;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that returns an encrypted version of the same text. Encrypt the text by shifting each character with three positions forward.For example, A would be replaced by D, B would become E and so on.Print the encrypted text.

            string input = Console.ReadLine();//Programming is cool!
            string encryptedString = string.Empty;//""

            foreach (char currChar in input)
            {
                int currPosition = currChar;//currChar = a => int 97
                currPosition += 3;//int= 97+3=100 => currChar =d
                encryptedString += (char)currPosition;
            }
            Console.WriteLine(encryptedString);
        }
    }
}
