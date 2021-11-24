using System;
using Humanizer;

namespace humaizertest
{
    class Numberconverter
    {
        static void Main(string[] args)
        {
            string text;
        start:
            Console.WriteLine("Enter a Number To Convert:");
            text = Console.ReadLine();
            if (text.Contains("."))
            {
                string[] cents = text.Split('.');

                if (text.Length < 4)
                {
                    Console.WriteLine("You must have a number before the decimal place!");
                    goto start;
                }
                    int num = Convert.ToInt32(cents[0]);
                    int fcent = Convert.ToInt32(cents[1]);
                if (fcent > 99)
                {
                    Console.WriteLine("Too many decimal places!");
                    goto start;
                }
                else
                {
                    Console.WriteLine(num.ToWords() + " and " + fcent.ToWords() + " cents ");
                }
            }
            else
            {
                int num = Convert.ToInt32(text);
                Console.Clear();
                Console.WriteLine(num.ToWords());
            }
        }
    }
}