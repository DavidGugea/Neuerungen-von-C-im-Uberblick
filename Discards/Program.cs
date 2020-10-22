using System;

namespace Discards
{
    class Program
    {
        static void Main(string[] args)
        {
            var (id_name, date, _, _) = GetSomeData(5);
            Console.WriteLine(id_name);
            Console.WriteLine(date);
        }
        static (string, DateTime, int, int) GetSomeData(int id)
        {
            switch (id)
            {
                case 1:
                    return ("A", DateTime.Now, 1, 2);
                case 2:
                    return ("B", new DateTime(2020, 10, 22, 21, 7, 59), 3, 4);
                default:
                    return ("C", new DateTime(2003, 10, 15, 4, 30, 0), 25, 1000);
            }
        }
    }
}
