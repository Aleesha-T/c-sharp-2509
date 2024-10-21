using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class StudentDetails
    {
        public string Name;
        public string ID;
        private int[] marks;
        //private int biologyMarks;
        //private int englishMarks;
        //private int scienceMarks;

        public StudentDetails(string name, string id)
        {
            Name = name;
            ID = id;
            //biologyMarks = 0;
            //englishMarks = 0;
            //scienceMarks = 0;
        }
        //public int BiologyMarks
        //{
        //    get { return biologyMarks; }
        //    set
        //    {
        //        if (value < 0 || value > 100)
        //        {
        //            throw new ArgumentException("Invalid marks");
        //        }
        //        biologyMarks = value;
        //    }
        //}
        //public int EnglishMarks
        //{
        //    get { return englishMarks; }
        //    set
        //    {
        //        if (value < 0 || value > 100)
        //        {
        //            throw new ArgumentException("Invalid marks");
        //        }
        //        englishMarks = value;
        //    }
        //}
        //public int ScienceMarks
        //{
        //    get { return scienceMarks; }
        //    set
        //    {
        //        if (value < 0 || value > 100)
        //        {
        //            throw new ArgumentException("Invalid marks");
        //        }
        //        scienceMarks = value;
        //    }
        //}
        // public void AddBiologyMarks(int marks)
        // {
        //    BiologyMarks += marks;
        //    if (BiologyMarks>100)
        //    {
        //        throw new ArgumentException("Invalid");
        //    }
        // }
        //public void AddEnglishMarks(int marks)
        //{
        //    EnglishMarks += marks;
        //    if (EnglishMarks > 100)
        //    {
        //        throw new ArgumentException("Invalid");
        //    }
        //            }
        //public void AddScienceMarks(int marks)
        //{
        //    ScienceMarks += marks;
        //    if (ScienceMarks > 100)
        //    {
        //        throw new ArgumentException("Invalid");
        //    }
        //}

        //public void Average()
        //{
        //    float average = (BiologyMarks + EnglishMarks + ScienceMarks) / 3;
        //    Console.WriteLine("Average is: "+average);
        //}

        public int[] Marks
        {
           get {return marks; }
            set
            {
                if 
            }
        }


    }
}
