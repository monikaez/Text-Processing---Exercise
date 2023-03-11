using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a string from the console and replaces any sequence of the same letter with a single corresponding letter.
            string text = Console.ReadLine();//aaaaabbbbbcdddeeeedssaa
            char previousChar = text[0];//a
            Console.Write(previousChar);
            for (int i = 1; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (previousChar != currentChar)//a!=b
                {
                    previousChar = currentChar;
                    Console.Write(previousChar);//b
                }
            }
        }
    }
}
