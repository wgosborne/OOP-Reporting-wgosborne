using System;
using System.IO;
namespace oop_reporting_wgosborne
{
    public class StudentReports
    {
        private Students [] myStudents;

        public StudentReports(Students [] myStudents)
        {
            this.myStudents = myStudents;
        }

        public void Print()
        {
            for (int i = 0; i < Students.GetCount(); i++)
            {
                System.Console.WriteLine(myStudents[i].ToString());
            }
        }
    }
}