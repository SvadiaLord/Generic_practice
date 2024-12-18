using Generic_practice1.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int, string> pair = new Pair<int, string>(1, "One");
            pair.Display();
            pair.First = 2;
            pair.Second = "Two";
            pair.Display();

            ClassMassiv<int> classMassiv = new ClassMassiv<int>();
            int[] numbers = { 4, 5, 6, 7 };
            classMassiv.Swap(numbers, 2, 0);
            Console.WriteLine(string.Join(", ", numbers));

            ClassAreEqual<bool> classAreEqual = ClassAreEqual<bool>("LF", "LF");


        }
    }
}
