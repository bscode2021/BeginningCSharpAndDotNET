using System;

namespace OveroadingFuntions
{
    internal class Program
    {
        static int ShowDouble(int val)
        {
            Console.WriteLine($"doubled val {val * 2}");
            return val * 2;
        }
        static void ShowDouble(ref int val)
        {
            val *= 2;
            Console.WriteLine($"doubled val {val}");
        }
        static void ShowDouble(int val, out int doubled)
        {
            doubled = val * 2;
            Console.WriteLine($"doubled val {doubled}");
        }
        static int ShowDouble(string val)
        {
            int res = Convert.ToInt32(val) * 2;
            Console.WriteLine($"doubled val {res}");
            return res;
        }
        static void Main(string[] args)
        {
            int res1 = ShowDouble(5);
            int res2 = ShowDouble("5");
            int res3 = 5;
            ShowDouble(ref res3);
            ShowDouble(5, out int res4);
            Console.ReadLine();
        }
    }
}
