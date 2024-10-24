// See https://aka.ms/new-console-template for more information
namespace Assignment{
    using System;

    public record Student (string Name, int Age, char Grade);

    class Program
    {
        public static Student CreateFromTuple((string Name, int Age, char Grade) studentTuple)
        {
            return new Student(studentTuple.Name, studentTuple.Age, studentTuple.Grade);
        }

        public static void Main(string[] args)
        {
            var studentTuple = ("Aleesha", 21, 'S');
            Console.WriteLine("Tuple initialization");
            Console.WriteLine($"Name: {studentTuple.Item1}, Age: {studentTuple.Item2}, Grade: {studentTuple.Item3}");
            Console.WriteLine();

            Student student1 = new Student("Riya", 22, 'A');
            Console.WriteLine("Record initialization");
            Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, Grade: {student1.Grade}");
            Console.WriteLine();

            Student student2 = CreateFromTuple(("Lily", 23, 'B'));
            Console.WriteLine("Student Record from Tuple");
            Console.WriteLine($"Name: {student2.Name}, Age: {student2.Age}, Grade: {student2.Grade}");
            Console.ReadLine();
        }
    }
}
