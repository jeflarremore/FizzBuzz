using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSolution
{
    class Program
    {
        // generates a list of integers from 1 to 100
       
        public static List<int> GetIntegers()
        {
            var integerList = new List<int>();
            for (var i = 1; i <= 100; i++)
            {
                integerList.Add(i);
            }
            return integerList;
        }
        // Iterates through a list of integers and writes the appropriate string to the console
        public static void FizzBuzz(List<int> integerList)
        {
            foreach (var item in integerList)
            {
                if (item % 3 == 0 && item % 5 == 0)
                {
                    Console.WriteLine(item.ToString() + " FizzBuzz");
                }
                else if (item % 3 == 0)
                {
                    Console.WriteLine(item.ToString() + " Fizz");
                }
                else if (item % 5 == 0)
                {
                    Console.WriteLine(item.ToString() + " Buzz");
                }
                else
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            var integerList = GetIntegers();
            FizzBuzz(integerList);
            Console.ReadLine();
        }
    }
}
