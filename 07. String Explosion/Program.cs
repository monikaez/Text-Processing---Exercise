using System;
using System.Diagnostics;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explosions are marked with '>'. Immediately after the mark, there will be an integer, which signifies the strength of the explosion.
            //You should remove x characters(where x is the strength of the explosion), starting after the punched character('>').
            //If you find another explosion mark('>') while you're deleting characters, you should add the strength to your previous explosion.
            //When all characters are processed, print the string without the deleted characters.
            //You should not delete the explosion character – '>', but you should delete the integers, which represent the strength.
            string textField = Console.ReadLine();//abv>1>1>2>2asdasd
            int bomb = 0;

            for (int i = 0; i < textField.Length; i++)
            {
                if (bomb>0 && textField[i]!='>')
                {
                    textField = textField.Remove(i, 1);
                    bomb--;
                    i--;
                }
                else if (textField[i]=='>')
                {
                    bomb += int.Parse(textField[i + 1].ToString());
                }
            }
            Console.WriteLine(textField);
        }
    }
}
