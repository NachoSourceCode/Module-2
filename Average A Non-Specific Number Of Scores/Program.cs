using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Create a console application that will accept an arbitrary number of test scores, specified 
 * by the user, between 0 and 100, average them, and report a letter grade for the average based
 * based on the usual scale. FLOW: teacher inputs the total number of tests, then inputs test
 * scores and see the average numberical grade and the letter grade. */

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
           Console.WriteLine($"The average letter grade for these tests are: {letterGrade}");
        }
        // Converts the string representation of the number entered and converts it to it's integer 
        // representation and passes that value back to nTests. 
        static int readInt() => int.Parse(Console.ReadLine());
        
        //Return the sum of test scores entered.
        //query test scores from the user between 0 and 100.
            //create query of test score.
            //test score entered to be between 0 and 100.
                //if score entered aren't between 0 and 100 return an error statement.
                //if score entered are between 0 and 100 do something.
        static int inputTestScores(int nTests)
        {
            int sumOfScores = 0;
            var testKeeperTrackerOfer = 0; 
            // Do this while number of tests to enter hasn't been met.
            // exit when the number of tests has been.
            // keep track of current tests that are valid.
            while (testKeeperTrackerOfer < nTests)
            {
                // create query of test score.
                Console.WriteLine("Enter a test score:");
                int testScore = int.Parse(Console.ReadLine());

                // test score entered to be between 0 and 100.
                if (testScore >= 0 && testScore <= 100)
                {
                    // do something
                    sumOfScores += testScore;
                    // record number of times the score has been entered.
                    testKeeperTrackerOfer += 1;
                }
                else
                {
                    // return an error statement.
                    Console.WriteLine("You did not enter a value between 0 and 100.");
                }
            }
            return sumOfScores;
        }
          static char makeLetterGrade(int avg)
          {
            
            int letterGradeAvg = avg;
            char letterGrade;
            
            // State what the range of A, B, C, D, and F.
            if ((letterGradeAvg>= 90) && (letterGradeAvg<= 100))
            {
                letterGrade = 'A';
            }
            else if ((letterGradeAvg>= 80) && (letterGradeAvg<= 89))
            {
                letterGrade = 'B';
            }
            else if ((letterGradeAvg>= 70) && (letterGradeAvg<= 79))
            {
                letterGrade = 'C';
            }
            else if ((letterGradeAvg >= 60) && (letterGradeAvg <= 69))
            {
                letterGrade = 'D';
            }
            else if ((letterGradeAvg >= 0) && (letterGradeAvg <= 59))
            {
                letterGrade = 'F';
            }
            else
            {
               Console.WriteLine("You either scored so badly that there isn't a letter" +
                    "grade for it or something else.");
               letterGrade = 'Z';
            }
            // return Letter equivalent of numerical average.
            //add throw statement.
            return letterGrade;
          }
    }
}
