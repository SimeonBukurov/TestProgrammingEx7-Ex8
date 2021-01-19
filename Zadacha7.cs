using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "13", "5", "32", "0", "4", "19", "23", "22", "52" };
            int[] intArray = array.Select(int.Parse).Where(n => n % 2 == 0).OrderByDescending(n => n).ToArray();
            Console.WriteLine(String.Join(", ", intArray));
        }
    }
}
