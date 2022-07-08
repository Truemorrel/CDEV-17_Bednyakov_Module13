using System;
using System.Collections.Generic;

namespace Task_13_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "Подсчитайте, сколько уникальных символов в этом предложении, " +
                "используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
            char[] delimiters = new char[] { '\r', '\n' };
            var stext = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            HashSet<char> hSet = new HashSet<char>();
            foreach (var s in stext)
            {
                foreach (char c in s)
                {
                    hSet.Add(c);
                }
            }
            // HashSet<char> hSet = new HashSet<char>(text.ToCharArray());
            Console.WriteLine(hSet.Count);
        }
    }
}
