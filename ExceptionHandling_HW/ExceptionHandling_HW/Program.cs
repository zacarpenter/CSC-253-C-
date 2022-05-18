using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // declare variables
                int sum = 0;
                int numScores = 0;
                double avg;
                bool isNegative = false;
                int highestScore = 0;
                // set this to the highest possible score
                int lowestScore = 100;
                string line = "";
                string previousLine1 = "";
                string previousLine2 = "";

                // created new files so I could test the exceptions I created below 
                StreamReader inputFile = new StreamReader("input1.txt");


                while (!inputFile.EndOfStream)
                {

                    line = inputFile.ReadLine();

                    // does the line have score
                    if (int.TryParse(inputFile.ReadLine(), out int score))
                    {
                        // check for negative
                        if (score >= 0)
                        {
                            // check for highest score
                            if (score >= highestScore)
                            {
                                highestScore = score;
                                previousLine1 = line;
                            }

                            // check for lowest score
                            if (score <= lowestScore)
                            {
                                lowestScore = score;
                                previousLine2 = line;
                            }

                            // add the scores to create a total
                            sum += score;

                            // increment the number of scores so I can caculate the average
                            numScores++;
                        }
                        else
                        {
                            isNegative = true;
                        }
                    }
                } // end while

                // Calculate the average
                avg = (double)sum / (double)numScores;

                // check if average meets the requirements
                if (avg < 60)
                {
                    throw new AvgException();
                }
                else if (isNegative == true)
                {
                    throw new NegativeException();
                }
                else
                {
                    // display the average
                    Console.WriteLine("The average for the class is: {0}", avg);

                    // display the highest score
                    Console.WriteLine(previousLine1 + " " + highestScore);

                    // display the lowest score
                    Console.WriteLine(previousLine2 + " " + lowestScore);

                    // write to the ouput.txt file
                    StreamWriter output = new StreamWriter("output.txt");

                    output.WriteLine($"The average for the class is: {avg}");
                    output.WriteLine($"{previousLine1} had the highest score of: {highestScore}");
                    output.WriteLine($"{previousLine2} had the lowest score of: {lowestScore}");
                    output.Close();
                }

            }
            catch (AvgException e)
            {
                e.Avg();
            }
            catch (NegativeException e)
            {
                e.Negative();
            }

            Console.ReadLine();

        } // end main
    } // end class

    // Exception Classes
    class AvgException : Exception
    {
        public void Avg()
        {
            Console.WriteLine("Average not up to NC State standards. Class is eliminated.");
        }
    }

    class NegativeException : Exception
    {
        public void Negative()
        {
            Console.WriteLine("Invalid data. Please check file.");
        }
    }

} // end namespace
