using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_HW
{
    class Program
    {
        public delegate void Add(); // addition delegate
        public delegate void Subtract(); // subtraction delegate
        public delegate void Multiply(); // multiply delegate
        public delegate void Divide(); // divide delegate

        static void Main(string[] args)
        {
            Console.WriteLine("Addition Method");
            Console.WriteLine("");

            Add a = new Add(AddRandom);
            a.Invoke();

            Console.WriteLine("");
            Console.WriteLine("Subtraction Method");
            Console.WriteLine("");

            Subtract b = new Subtract(SubtractRandom);
            b.Invoke();

            Console.WriteLine("");
            Console.WriteLine("Multiplication Method");
            Console.WriteLine("");

            Multiply c = new Multiply(MultiplyRandom);
            c.Invoke();

            Console.WriteLine("");
            Console.WriteLine("Division Method");
            Console.WriteLine("");

            Divide d = new Divide(DivideRandom);
            d.Invoke();

            // Pause
            Console.ReadLine();

        } // end main

        public static void AddRandom()
        {
            Random r = new Random();
            for (int i = 1; i <= 100; i++)
            {
                int x = r.Next(1, 50);
                int y = r.Next(1, 50);
                int z = x + y;
                Console.WriteLine("{0}. {1} + {2} = {3}", i, x, y, z);
            }
        }

        public static void SubtractRandom()
        {
            Random r = new Random();
            for (int i = 1; i <= 100; i++)
            {
                int x = r.Next(1, 50);
                int y = r.Next(1, 50);
                if (x > y)
                {
                    int z = x - y;
                    Console.WriteLine("{0}. {1} - {2} = {3}", i, x, y, z);
                }
                else
                {
                    int z = y - x;
                    Console.WriteLine("{0}. {1} - {2} = {3}", i, y, x, z);
                }
            }
        }

        public static void MultiplyRandom()
        {
            Random r = new Random();
            for (int i = 1; i <= 100; i++)
            {
                int x = r.Next(1, 50);
                int y = r.Next(1, 50);
                int z = x * y;
                Console.WriteLine("{0}. {1} * {2} = {3}", i, x, y, z);
            }
        }

        public static void DivideRandom()
        {
            Random r = new Random();
            for (int i = 1; i <= 100; i++)
            {
                int x = r.Next(1, 50);
                int y = r.Next(1, 50);
                if (x > y)
                {
                    int z = x / y;
                    Console.WriteLine("{0}. {1} / {2} = {3}", i, x, y, z);
                }
                else
                {
                    int z = y / x;
                    Console.WriteLine("{0}. {1} / {2} = {3}", i, y, x, z);
                }
            }
        }

    } // end class
} // end  namespace
