using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LargestNum myLargestNum = new LargestNum();

            int largestNumber = myLargestNum.LargestNumber(10, 13);
            Console.WriteLine(largestNumber);

            int largestNumber2 = myLargestNum.LargestNumber(4, 255, 45);
            Console.WriteLine(largestNumber2);

            int largestNumber3 = myLargestNum.LargestNumber(42, 75, 81, 17);
            Console.WriteLine(largestNumber3);

            // I didn't include code for if all the numbers were equal, I was struggling with the overloading methods. But I managed to get it working!

            Console.ReadLine();

        } // end main
    } // end class
} // end namespace
