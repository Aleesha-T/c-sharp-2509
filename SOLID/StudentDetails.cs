using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    interface IMarksFirstYear
    {
        void FirstYear(int s1, int s2);        
    }
    interface IMarksSecondYear 
    { 
        void SecondYear(int s3, int s4);    
    }
    interface IMarksThirdYear
    {
        void ThirdYear(int s5, int s6);
    }
    interface IMarksFourthYear
    {
        void FourthYear(int s7, int s8);
    }

    public class StudentDetails
    {
        public string Name { get; set; }
        public string AdmissionNumber { get; set; }
        public StudentDetails(string name, string admissionNumber) 
        {
            Name = name;
            AdmissionNumber = admissionNumber;
        }
    }
    public class StudentMarks : IMarksFirstYear, IMarksSecondYear, IMarksThirdYear, IMarksFourthYear
    {
        public void FirstYear(int s1, int s2)
        {
            Console.WriteLine("S1 and S2");
        }

        public void FourthYear(int s7, int s8)
        {
            Console.WriteLine("S7 and S8");
        }

        public void SecondYear(int s3, int s4)
        {
            Console.WriteLine("S3 and S4");
        }

        public void ThirdYear(int s5, int s6)
        {
            Console.WriteLine("S5 and S6");
        }
    }
    public class LETStudentMarks : IMarksSecondYear, IMarksThirdYear, IMarksFourthYear
    {
        public void FourthYear(int s7, int s8)
        {
            Console.WriteLine("S7 and S8");
        }

        public void SecondYear(int s3, int s4)
        {
            Console.WriteLine("S3 and S4");
        }

        public void ThirdYear(int s5, int s6)
        {
            Console.WriteLine("S5 and S6");
        }
    }
}
