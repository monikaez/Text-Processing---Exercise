using System;
using System.Numerics;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are given two lines – the first one can be a really big number (0 to 1050). The second one will be a single-digit number (0 to 9). Your task is to display the product of these numbers.
            // Note: do not use the BigInteger class.
            string input = Console.ReadLine();//23
            int multiplyer = int.Parse(Console.ReadLine());//2

            StringBuilder sb = new StringBuilder();//empty Sb
            int reminder = 0;
            if (input == "0" || multiplyer == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = input.Length - 1; i >= 0; i--)//23=>32
            {
                int currentDigit = int.Parse(input[i].ToString());//3
                int product = currentDigit * multiplyer + reminder;//3*2+0
                int result = product % 10;//32/10=>3
                reminder = product / 10;//3/10=>0
                sb.Insert(0, result);//6 na  1 va iteracia,na 2 ra 46
            }
            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb);
        }
    }
}
