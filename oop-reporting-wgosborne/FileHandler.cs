namespace oop_reporting_wgosborne
{
    public class FileHandler
    {
        //streamread here
        private string fileName;

        public FileHandler(string fileName)
        {
            this.fileName = fileName;
        }


        public Students[] GetAllStudents()
        {
            Students.SetCount(0);
            Students [] myStudents = new Students[50]; //getting an array to hold studente
            StreamReader inFile = new StreamReader(fileName);
            string line = inFile.ReadLine();

            while (line != null)
            {
                line.Split("#");
                string [] temp = line;
                myStudents[Students.GetCount()] = new Students(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]), int.Parse(temp[3])); //may need to int.parse
                Students.IntCount();


                line = inFile.ReadLine();
            }

            inFile.Close();
            return myStudents;
        }

        public void Save(Students [] myStudents)
        {
            StreamWriter outFile = new StreamWriter(fileName);
            for (int i = 0; i < Students.GetCount(); i ++)
            {
                outFile.WriteLine(myStudents[i].ToFile()); //not done
            }

            outFile.Close();
        }

    }
}