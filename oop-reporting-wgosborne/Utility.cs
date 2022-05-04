namespace oop_reporting_wgosborne
{
    public class Utility
    {
        //search and sort the data. binary search, do it before Weds

        private Students[] myStudents; // accepting the array

        public Utility(Students[] myStudents)
        {
            this.myStudents = myStudents;
        }

        public void Sort() // needs no data bc it  can access array and count through class
        {
            for (int i = 0; i < Students.GetCount() - 1; i++)
            {
                int min = i;
                for (int j = i+1; j <Students.GetCount(); j++)
                {
                    if (myStudents[j].CompareTo(myStudents[min]) < 0)
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    Swap(min, i);
                }
            }
        }

        private void Swap(int x, int y)
        {
            Students temp = myStudents[x];
            myStudents[x] = myStudents [y];
            myStudents[y] = temp;

        }

        //sequent search

        public int Search(string searchVal)
        {
            int found = -1;
            for (int i = 0; i < Students.GetCount(); i ++)
            {
                if (myStudents[i].CompareTo(searchVal) == 0)
                {
                    return i;
                }
                
                return found;
            }
            return null;
        }

        

    }
}