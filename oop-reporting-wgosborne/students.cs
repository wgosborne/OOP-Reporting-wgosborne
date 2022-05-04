using System;
using System.IO;

namespace oop_reporting_wgosborne
{
    public class Students
    {
        //public string temp = "";

        public double tempNum = 0;
        private string name; // prrivate because it keeps it safe and hidden from world "Data Hiding"

        private int creditHours;
        private int gpa;

        private string year;

        private static int count;


        public Students() //this is the constructor, you can always identify it bc it carries the same name as the class, and it doesnt have a return type
        {
            
        }

        public Students(string name, int creditHours, int gpa, string year)
        {
            this.name = name; // using the 'this' prevents data shadowing
            this.creditHours = creditHours;
            this.gpa = gpa;
            this.year = year;
        }


        public string GetName() // data accessor (getter)
        {
            return name;
        }
        public void SetName(string temp) // data mutator (setter)
        {
            name = temp;
        }

        public string GetYear()
        {
            return year;
        }

        public void SetYear(string temp)
        {
            year = temp;
        }
        public int GetGpa() // data accessor (getter)
        {
            return gpa;
        }
        public void SetGpa(int tempNum) // data mutator (setter)
        {
            gpa = tempNum;
        }
        public int GetCreditHours() // data accessor (getter)
        {
            return creditHours;
        }
        public void SetCreditHours(int tempNum) // data mutator (setter)
        {
            creditHours = tempNum;
        }

        public static void SetCount(int tempNum)
        {
            count = tempNum;
        }

        public static int GetCount()
        {
            return count;
        }

        public static void IntCount()
        {
            count ++;
        }

        public string ToString()
        {
            return name + "\t" + creditHours + "\t" + gpa + "\t" + year;
        }

        // public int CompareTo(Students student) // dont know if student is rirght
        // {
        //     this.name.CompareTo(Students.GetName());
        // }

        public int CompareTo(Students student)
        {
            return this.name.CompareTo(student.GetName());
        }

        public string ToFile()
        {
            return name + "#" + creditHours + "#" + gpa + "#" + year;
        }

    
    }
}