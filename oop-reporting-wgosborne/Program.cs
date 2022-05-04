using System;
using System.IO;
namespace oop_reporting_wgosborne

{ 

    class Program 
    { 
        static void Main() 
        { 
            //is there already supposed to be the starter .txt file? did i download it correctly
            //ask about get all students method
            //Ask about error
            
            //Greet the user
            Console.WriteLine("Welcome to the Culverhouse Student Database!!");
            System.Console.WriteLine("Our records show that the best student in the database is Wagner Osborne btw");
            System.Console.WriteLine("#yalsyssup #eatdown #howneatisthat #veryneat");
            System.Console.WriteLine();
            
            //Menu
            string userInput = " ";
            while (userInput != "7")
            {
                userInput = GetMenuChoice();
                Route(userInput);
            }

            //Read in the file
            // StreamReader inFile = new StreamReader("students.txt");
            // string student = inFile.ReadLine(); 

            //prints out students
            FileHandler myDataHandler = new FileHandler("students.txt");
            Students [] myStudents = myDataHandler.GetAllStudents();
            StudentReports reports = new StudentReports(myStudents); 
            reports.Print();

            Utility myUtility = new Utility(myStudents); // instansiatef class
            myUtility.Sort();

            //after sort print
            System.Console.WriteLine();
            System.Console.WriteLine("After Sort--------------------------------------------------");
            StudentReports.Print();

            string searchVal = "Makayla Townsend";
            
            int found = myUtility.Search(searchVal);
            if (found != -1)
            {
                System.Console.WriteLine("What should the credit hours be?");
                int updatedHours = int.Parse(Console.ReadLine());
                myStudents[found].SetCreditHours(updatedHours);
            }

            myDataHandler.Save(myStudents); // wrong


        }
        

        static void DisplayMenu()
        {
            System.Console.WriteLine("Please use an integer to select which menu item you would like to run from below. ");
            System.Console.WriteLine("1) Look up a student");
            System.Console.WriteLine("2) Write all reports to a file");
            System.Console.WriteLine("3) Only hit 3 if you are Adam Sandler");
            System.Console.WriteLine("4) GPA Range Report");
            System.Console.WriteLine("5) Hours by Year Report");
            System.Console.WriteLine("6) Excess Credit Hours Report");
            System.Console.WriteLine("7) Exit the system");
        }

        static string GetMenuChoice()
        {
            
            DisplayMenu();
            string userInput = Console.ReadLine();
            return userInput;

            // there is room for input validating here
        }

        static void Route(string userInput)
        {
            if (userInput == "1")
            {
                //Looking up a student
                StudentSearch();
                
            }
            else if (userInput == "2")
            {
                //Write the report to a given file
                WriteToFile();
            }
            else if (userInput == "3")
            {
                //The user is Adam Sandler
                AdamSandler();

            }
            else if (userInput == "4")
            {
                //GPA range report
                GpaRange();

            }
            else if (userInput == "5")
            {
                //Hours by year report
                HoursByYear();

            }
            else if (userInput == "6")
            {
                //excess credit hours report
                ExcessHours();

            }
            else if (userInput == "7")
            {
                Console.Clear();
                Console.WriteLine("good riddance.");
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("Invalid choice you jolly ol bloke!");
            }
        }

        static void StudentSearch()
        {
            System.Console.WriteLine("Please enter the name of the student you are looking for:");
            string userInput = Console.ReadLine();
        }

        static void WriteToFile()
        {
            //writes report to a file that the user will give the name of
        }

        static void AdamSandler()
        {
            System.Console.WriteLine("Congrats on your new job at Alabama, Sandy. Good to see you are onto bigger and better things.");


            //Make a list of options for why he hasnt replied, give snarky responses
        }

        static void GpaRange()
        {

        }

        static void HoursByYear()
        {

        }

        static void ExcessHours()
        {

        }

        //DUE BEFORE THE FINAL
    }

}
