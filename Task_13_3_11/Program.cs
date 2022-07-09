using System;
using System.Collections.Generic;

namespace Task_13_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "Подсчитайте, сколько уникальных символов в этом предложении, " +
                "используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
            //char[] delimiters = new char[] { '\r', '\n' };
            //var stext = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            //HashSet<char> hSet = new HashSet<char>();
            //foreach (var s in stext)
            //{
            //    foreach (char c in s)
            //    {
            //        hSet.Add(c);
            //    }
            //}
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
            Console.WriteLine($"За исключением знаков препинания и пробелов в тесксте содержится {hSet.Count}");
        }
    }
}
