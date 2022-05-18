using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();

            // Finally, display the group who had the higher average.
            // I had trouble figuring this out. Both were equal in this case, but since we used void methods inside those classes I couldn't access the variables.
            // I tried using a return variable but it got messy and I just backed it up to what I originally had.


            Console.ReadLine();
        } // end main
    } // end class

    public class Task1
    {
        public Task1()
        {
            Thread t1 = new Thread(new ThreadStart(student1));
            t1.Start();
        }

        void student1()
        {
            StreamReader sr = new StreamReader(@"C:\Users\zacar\source\repos\ThreadingHW\student1.txt");

            var i = 0;
            var total = 0;
            
            while (!sr.EndOfStream)
            {
                i++;
                var line = sr.ReadLine();
                total += Convert.ToInt32(line);
                
            }

            var average1 = total / i;

            Console.WriteLine("Average for student 1: " + average1);
        }

    } // end task1

    public class Task2
    {
        public Task2()
        {
            Thread t1 = new Thread(new ThreadStart(student2));
            t1.Start();
        }

        void student2()
        {
            StreamReader sr = new StreamReader(@"C:\Users\zacar\source\repos\ThreadingHW\student2.txt");

            var i = 0;
            var total = 0;

            while (!sr.EndOfStream)
            {
                i++;
                var line = sr.ReadLine();
                total += Convert.ToInt32(line);

            }

            var average2 = total / i;

            Console.WriteLine("Average for student 2: " + average2);
        }

    } // end task2

} // end namespace
