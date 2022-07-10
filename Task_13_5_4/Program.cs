using System;
using System.Collections.Generic;

namespace StackTest
{
    class Program
    {
        public static Stack<string> words = new Stack<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();
            string input;
            do
            {
                input = Console.ReadLine();

                switch(input)
                {
                    case "pop" :
                        words.TryPop(out string fromPop);
                        break;
                    case "peek" :
                        words.TryPeek(out string fromPeek);
                        break;
                    default : words.Push(input);
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
            while (!string.IsNullOrEmpty(input));
        }
    }
}