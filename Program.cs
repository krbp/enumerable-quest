using System;
using System.Linq;

namespace MultipleConstructors
{
    public static class Program
    {
        public static void Main()
        {
            List<int> integers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            int total = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int length = 0; // length of integersLowerThan
            List<int> integersLowerThan = integers.Where((x) => x <= n).ToList();
            Console.Write("Array:");
            foreach (int value in integersLowerThan)
            {
                Console.Write(value);
                total += value;
                length++;
            }
            foreach (int value in integersLowerThan)
            {
                total += value;
                length++;
            }
            Console.Write("\nResult:");
            Console.Write(total / length);
        }
    }
}
