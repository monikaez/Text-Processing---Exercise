using System;
using System.ComponentModel;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads user names on a single line (joined by ", ") and prints all valid usernames. 
            //A valid username
            //•	has length between 3 and 16 characters
            //•	contains only letters, numbers, hyphens and underscores
            string[] usernames = Console.ReadLine().Split(", ");
            foreach  (string currName in usernames)
            {
                if (currName.Length>3 && currName.Length<=16)
                {
                    bool isUserNameValid = true;
                    foreach (char currChar in currName)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                        {
                            isUserNameValid = false;
                            break;
                        }
                    }
                    if (isUserNameValid)
                    {
                        Console.WriteLine(currName);
                    }

                }
            }

        }
    }
}
