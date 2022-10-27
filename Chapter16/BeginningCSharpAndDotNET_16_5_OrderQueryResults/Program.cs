using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace BeginningCSharpAndDotNET_16_5_OrderQueryResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alonso", "Zheng", "Sith", "Jones", "Smythe", "Small",
               "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };

            // LINQ query syntax
            IEnumerable<string> queryResults =
                from n in names
                where n.StartsWith("S")
                orderby n.Length descending
                select n;

            // LINQ method syntax
            IEnumerable<string> queryResults1 = names.Where(n => n.StartsWith("S")).OrderBy(n => n.Length);

            WriteLine("Names beginning with S ordered by length:");
            foreach (var item in queryResults1)
            {
                WriteLine(item);
            }
            Write("Program finished, press Enter/Return to continue:");         }
    }
}
