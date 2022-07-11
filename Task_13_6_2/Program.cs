using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace Task_13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("D:\\Repos\\Skillfactory\\Text1 (1).txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] separators = { ' ', '\n', '\r', '\t', '.', ',' };
            string[] words = noPunctuationText.Split(separators);

            SortedDictionary<string, int> wordDictionary = new SortedDictionary<string, int>();

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
                wordDictionary.TryAdd(words[i],1);
                }
            };
            wordDictionary.OrderByDescending(x => x.Key);
            test.Stop();
            
            Console.WriteLine($"В словарь загружено {wordDictionary.Count} из {words.Length} слов исходного текста, за {test.Elapsed.TotalSeconds} секунд.");

        }
    }
}
