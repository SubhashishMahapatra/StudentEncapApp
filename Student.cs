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
        private int _studentRollNo;
        private string _studentName;

        private double _studentCGPA;

        public int GetStudentRollNo()
        {
            return _studentRollNo;
        }

        public string GetStudentName()
        {
            return _studentName;
        }

        public double GetStudentCGPT()
        {
            return _studentCGPA;
        }

        public void SetStudentRollNo(int studentRollNo)
        {
            if(_studentRollNo > 0)
            {
                _studentRollNo = studentRollNo;
            }
            else
            {
                Console.WriteLine("Student Roll No. Should be positive");
            }
        }

        public void SetStudentName(string studentName) 
        {
            _studentName = (_studentName.Length < 5)?" ": studentName;
            
        }

        public void SetStudentCGPA(double studentCGPA)
        {
            if (_studentCGPA > 0 && _studentCGPA <= 10)
            {
                _studentCGPA = studentCGPA;

            }
            else
            {
                Console.WriteLine("CGPA Should be between 1 to 10");
            }

        }

        public double CGPAGenerator()
        {
            double percentage;
            percentage = _studentCGPA * VALUE;
            return percentage;
        }

        public string StudentDetails()
        {
            return("Student Roll No. is: "+_studentRollNo+ "\nStudent Name is: "+_studentName+"\nStudent CGPA is: "+CGPAGenerator());
        }

    }
}
