using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_13_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new List<string>() {"Jan", "Feb", "Mar", "Apr", "May"};
            var missing = new ArrayList() {1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
            
            AddAbsent(months, missing);
            foreach (var m in months)
            {
                Console.WriteLine(m); 
            };

        }
        static void AddAbsent(List<string> target, ArrayList sorce)
        {
            var newMonths = new string[7];
            sorce.GetRange(4, 7).CopyTo(newMonths);
            target.AddRange(newMonths);
        }
    }
}
