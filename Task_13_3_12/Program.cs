using System;
using System.Collections.Generic;

namespace Task_13_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            HashSet<char> hSet = new HashSet<char>(text.ToCharArray());
            var hDigits = new HashSet<char>(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            if (hSet.Overlaps(hDigits))
            {
                Console.WriteLine($"Текст \"{text}\" содержит цифры.");
            }
            else
            {
                Console.WriteLine($"Текст \"{text}\" не содержит цифры.");
            };
            var hDelimiters = new char[] { ' ', '\r', '\n', ',', '.' };
            Console.WriteLine();
            hSet.ExceptWith(hDelimiters);
            Console.WriteLine($"За исключением знаков препинания и пробелов в тесксте содержится {hSet.Count} символов.");
        }
    }
}
