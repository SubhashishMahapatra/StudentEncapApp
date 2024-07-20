using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = { new Student(45, "Subhashish", 10), (new Student(50, "Shreya", 9)) };

            foreach (Student student in students) 
            {
               PrintDetails(student);
            }
            
        }

        static void PrintDetails(Student student)
        {
            Console.WriteLine(student.StudentDetails());
            Console.WriteLine();
        }
    }
}
