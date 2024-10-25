using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    public class University
    {
        List<Department> departments=new List<Department>(); //new list
        public void AddDepartment(Department department) //add to list
        {
            departments.Add(department);
        }
        public void AddCourse(Department department, Department.Course course) //add to llist
        {
            department.courses.Add(course);
        }
        public void DisplayCourseDetails(Department.Course course)
        {
            Console.Write($"Course Name: {course.CourseName}, ");
            Console.Write($"Course Code: {course.CourseCode}, ");
            Console.WriteLine($"Credits: {course.CourseCredits}");
        }
        public class Department
        {
            public string DepartmentName {  get; set; }
            public Department(string departmentName)
            {
                DepartmentName = departmentName;
            }

            public List<Course> courses = new List<Course>(); //new list
            public class Course
            {
                public string CourseName { get; set; }
                public string CourseCode { get; set; }
                public int CourseCredits { get; set; }

                public Course(string courseName, string courseCode, int courseCredits)
                {
                    CourseName = courseName;
                    CourseCode = courseCode;
                    CourseCredits = courseCredits;
                }
            }
        }
    }
}
