using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Task_13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("D:\\Repos\\Skillfactory\\Text1.txt");
            char[] separators = { ' ', '\n', '\r', '\t', '.', ',' };
            string[] words = text.Split(separators);
            List<string> wordCollection = new List<string>();
            Stopwatch test = new Stopwatch();
            
            test.Start();
            for (int i = 0; i < words.Length; i++)
            {
                wordCollection.Add(words[i]);
            };
            test.Stop();
            
            
            Console.WriteLine($"В словарь загружено {wordCollection.Count} из {words.Length} слов исходного текста, за {test.Elapsed.TotalSeconds} секунд.");

            wordCollection.Clear();
            wordCollection.TrimExcess();

            LinkedList<string> wordLinkedCollection = new LinkedList<string>();

            test.Restart();
            for (int i = 0; i < words.Length; i++)
            {
                wordLinkedCollection.AddLast(words[i]);
            };
            test.Stop();
            Console.WriteLine($"В связанный список загружено {wordLinkedCollection.Count} из {words.Length} слов исходного текста, за {test.Elapsed.TotalSeconds} секунд.");
        }
    }
}
