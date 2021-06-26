using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQdemo
{
    class Student : IComparable<Student>
    {
        public string name { get; set; }
        public int age { get; set; }
        public int grade { get; set; }


        public Student()
        {

        }

        public Student(string a, int b, int c)
        {
            name = a;
            age = b;
            grade = c;
        }

        public int CompareTo(Student other)
        {
            if (grade == other.grade)
            {
                return name.CompareTo(other.name);
            }
            else
            {
                return grade.CompareTo(other.grade);
            }
        }

        public override string ToString()
        {
            return ($"Name: {name}, Age: {age}, Grade: {grade}");
        }
    }
}
