using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop Examples

            //// Different cities to iterate over
            //string[] countries = { "Germany", "France", "Italy", "Japan", "Turkey", "Poland" };

            //// Iterating and printing each country
            //foreach (string country in countries)
            //{
            //    Console.WriteLine(country);
            //}

            //// Array of integers to demonstrate iteration
            //int[] scores = { 90, 65, 85, 72, 100, 54, 88, 47 };

            //// Foreach loop to print all the scores
            //foreach (int score in scores)
            //{
            //    Console.WriteLine(score);
            //}

            //// Printing only even numbers
            //foreach (int score in scores)
            //{
            //    if (score % 2 == 0)
            //    {
            //        Console.WriteLine(score);
            //    }
            //}

            //// Calculating total of all the scores
            //int totalScore = 0;
            //foreach (int score in scores)
            //{
            //    totalScore += score;
            //}

            //Console.WriteLine("Total Score: " + totalScore);

            #endregion

            #region Example Exam System Application

            //Console.WriteLine("***** Programming Course Exam Application *****");
            //Console.WriteLine();

            //// Ask the user for the number of students
            //Console.Write("Enter the number of students in the class: ");
            //int numberOfStudents = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            //// Arrays to store students' names and their average grades
            //string[] students = new string[numberOfStudents];
            //double[] averages = new double[numberOfStudents];

            //// Gather data for each student
            //for (int i = 0; i < numberOfStudents; i++)
            //{
            //    Console.Write($"Enter the name of student #{i + 1}: ");
            //    students[i] = Console.ReadLine();

            //    double totalMarks = 0;

            //    // Collect three exam scores for each student
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter the score for exam {j + 1} for {students[i]}: ");
            //        double score = double.Parse(Console.ReadLine());
            //        totalMarks += score;
            //    }
            //    Console.WriteLine();

            //    // Calculate the average score
            //    averages[i] = totalMarks / 3;
            //}

            // Display each student's average and whether they passed or failed
            //for (int i = 0; i < numberOfStudents; i++)
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine($"The average score for {students[i]} is: {averages[i]:F2}");

            //    // Determine if the student passed
            //    if (averages[i] >= 60)
            //    {
            //        Console.WriteLine($"{students[i]} has passed.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{students[i]} has failed.");
            //    }
            //    Console.WriteLine("------------------------------");
            //}

            #endregion

            Console.Read();
        }
    }
}
