using System;

namespace DateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Date newDate = new Date(3, 24, 2021);

            Console.WriteLine($"{newDate.Display()}");
        }
    }
}
