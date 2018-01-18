using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_A_Specific_Number_Of_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number of tests to input
            Console.WriteLine("Please enter number of tests you wish to input, then hit enter: ");
            var nTests = readInt();

            // Input test scores
            var elicitedSum = inputTestScores(nTests);

            // Average input test scores
            var avg = elicitedSum / nTests;

            // Output letter grade for average of test scores
            // Categorize the average as a letter grade
            var letterGrade = makeLetterGrade(avg);

            // Output the grade
            Console.WriteLine($"The average letter grade for this test is: {letterGrade}");
        }
        static int readInt(int nTests)
        {

        }
        static int inputTestScores(int avg)
        {

        }
        static char makeLetterGrade(int avg)
        {

        }
    }
}
