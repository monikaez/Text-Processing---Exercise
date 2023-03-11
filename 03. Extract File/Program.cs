using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads the path to a file and subtracts the file name and its extension.

            string[] input = Console.ReadLine().Split("\\");//C:\Internal\training-internal\Template.pptx
            string file = input[input.Length - 1];//Template.pptx
            string[] splitLastWord = file.Split(".");//[Template,pptx]
            string fileName = splitLastWord[0];//Template
            string extansion = splitLastWord[1];//pptx

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extansion}");
        }
    }
}
