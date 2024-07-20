using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapApp
{
    internal class Student
    {
        public const double VALUE = 9.5;
        private int StudentRollNo { get; set; }
        private string StudentName {  get; set; }

        private double StudentCGPA { get; set; }

        public Student(int studentRollNo, string studentName, double studentCGPA)
        {
            StudentRollNo = studentRollNo;
            StudentName = studentName;
            StudentCGPA = studentCGPA;

            if (StudentRollNo > 0) 
            {
                StudentRollNo = studentRollNo;
            }
            else 
            {
                Console.WriteLine("Student Roll No. Should be positive");
            }
            

            
            if (StudentName.Length < 5)
            {
                StudentName = " ";
            }
            else
            {
                StudentName = studentName;
            }

            if ( StudentCGPA > 0 && StudentCGPA <= 10)
            {
                StudentCGPA = studentCGPA;
                
            }
            else
            {
                Console.WriteLine("CGPA Should be between 1 to 10");
            }
          
        }

        public double CGPAGenerator()
        {
            double percentage;
            percentage = StudentCGPA * VALUE;
            return percentage;
        }

        public string StudentDetails()
        {
            return("Student Roll No. is: "+StudentRollNo+ "\nStudent Name is: "+StudentName+"\nStudent CGPA is: "+CGPAGenerator());
        }


    }
}
