using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {


            string filePath = @"C:\demos\test.txt";

            List<Person> people = new List<Person>();

            List<String> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                Person p = new Person();
                p.firstName = entries[0];
                p.lastName = entries[1];
                p.url = entries[2];

                people.Add(p);

            }


            List<string> outputLines = new List<string>();
            Console.WriteLine("Here i the list of people I have:\n");
            foreach (Person p in people)
            {
                Console.WriteLine($"First Name: {p.firstName} Last Name: {p.lastName} URL: {p.url}");

                outputLines.Add($"First Name: {p.firstName} Last Name: {p.lastName} URL: {p.url}\n");

            }

            string outPath = @"C:\demos\peopleOut.txt";
            File.WriteAllLines(outPath, outputLines);




            Console.ReadLine();
        }
    }
}
