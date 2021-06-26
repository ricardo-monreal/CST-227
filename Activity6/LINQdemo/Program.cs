using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new[] { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };

            Console.WriteLine("Get the scores form the array\n");

            foreach (var individualScore in scores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }

            Console.ReadLine();


            // use LINQ to ge the best scores
            var theBestStudents =
                from individualScore in scores
                where individualScore > 90
                select individualScore;

            Console.WriteLine("Use LINQ to get the scores higher then 90\n");
            foreach (var individualScore in theBestStudents)
            {
                Console.WriteLine("One of the BEST scores was {0}", individualScore);
            }

            Console.ReadLine();

            // use LINQ to sort the results
            var sortedScores =
                from individualScore in scores
                orderby individualScore
                select individualScore;

            Console.WriteLine("Use LINQ to sort results by score\n");

            foreach (var individualScore in sortedScores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }

            Console.ReadLine();

            // CHALLENGE - Print all students with a grade of B using array list of students in ascending order
            ArrayList bStudents = new ArrayList();
            bStudents.Add(new Student("Michael", 42, 81));
            bStudents.Add(new Student("Dwight", 38, 87));
            bStudents.Add(new Student("Pam", 28, 82));
            bStudents.Add(new Student("Creed", 55, 89));
            bStudents.Add(new Student("Stanley", 53, 85));
            bStudents.Add(new Student("Angela", 36, 84));

            var sortedBstudents =
                from Student student in bStudents
                where student.grade <= 89 && student.grade >= 80
                orderby student
                select student;


            Console.WriteLine("Use LINQ to sort grade B results in ascending order\n");

            foreach (var student in sortedBstudents)
            {
                Console.WriteLine("One of the the B score students was {0}", student.ToString());
            }

            Console.ReadLine();


        }
    }
}
