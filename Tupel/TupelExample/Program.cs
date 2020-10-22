using System;
using System.Collections.Generic;
using System.Linq;

namespace TupelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.ValueTuple<int, int> data = new System.ValueTuple<int, int>(180, 30);
            /*
            var data = (180, 83);
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            */
            /*
            (int Height, int Weight) data = (180, 83);
            Console.WriteLine(data.Height);
            Console.WriteLine(data.Weight);
            */
            /*
            (int Height, int Weight) = (180, 83);
            Console.WriteLine(Height);
            Console.WriteLine(Weight);
            */
            /*
            var data = (Height: 180, Weight: 83);
            Console.WriteLine(data.Height);
            Console.WriteLine(data.Weight);
            */
            (int, int) data = Bereich(Enumerable.Range(1, 101).ToList<int>());
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            Console.WriteLine("--------------------------------------------");
            (string, string) data2 = TestMethod();
            Console.WriteLine(data2.Item1);
            Console.WriteLine(data2.Item2);
        }
        static (int, int) Bereich(List<int> zahlen)
        {
            int min = int.MinValue;
            int max = int.MaxValue;
            foreach(var zahl in zahlen){
                min = (zahl < min) ? zahl : min;
                max = (zahl > max) ? zahl : max;
            }

            return (min, max);
        }
        static (string x, string y) TestMethod()
        {
            string x = "a";
            string y = "b";

            string a = "x";
            string b = "y";

            // return (x, y);
            // OR :
            return (a, b);
        }
    }
}
