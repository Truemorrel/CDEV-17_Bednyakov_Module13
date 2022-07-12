using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace Task_13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("D:\\Repos\\Skillfactory\\Text1 (1).txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] separators = { ' ', '\n', '\r', '\t', '.', ',' };
            string[] words = noPunctuationText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordDictionary = new Dictionary<string, int>();

            Stopwatch test = new Stopwatch();

            test.Start();

            for (int i = 0; i < words.Length; i++)
            {
                if (wordDictionary.ContainsKey(words[i]))
                {
                    wordDictionary[words[i]]++;
                }
                else
                {
                    wordDictionary.TryAdd(words[i], 1);
                }
            };
            IEnumerable<KeyValuePair<string, int>> hitWordDictionary = wordDictionary.OrderByDescending(x => x.Value);

            test.Stop();

            Console.WriteLine($"В словаре загружено {hitWordDictionary.Count()} уникальных слов и отсортировано по рейтингу употребления за {test.Elapsed.TotalMilliseconds} милисекунд.");
            Console.WriteLine("Чаще всего встречаются 10 слов");
            foreach (var p in hitWordDictionary.Take(10))
            {
                Console.WriteLine($"{p.Key} : {p.Value}");

            }
        }
    }
}
