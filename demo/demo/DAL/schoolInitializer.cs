using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using demo.Models;

namespace demo.DAL
{
    public class schoolInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students=new List<Student>
            {
                new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var instructors = new List<Instructor>
            {
                new Instructor{ InstructorID=111,InstructorTitle=Title.Doctor,InstructorName="Frank Doe"},
                new Instructor{ InstructorID=222,InstructorTitle=Title.Miss,InstructorName="Emily Cops"},
                new Instructor{ InstructorID=333,InstructorTitle=Title.Misses,InstructorName="Sarah Loops"},
                new Instructor{ InstructorID=444,InstructorTitle=Title.Professor,InstructorName="George Costanza"}
            };
            instructors.ForEach(s => context.Instructors.Add(s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department{ DepartmentID=123,InstructorID=111,DepartmentName="Sciences"},
                new Department{ DepartmentID=456,InstructorID=222,DepartmentName="Economics"},
                new Department{ DepartmentID=789,InstructorID=222,DepartmentName="Math"},
                new Department{ DepartmentID=741,InstructorID=333,DepartmentName="Humanities"},
                new Department{ DepartmentID=852,InstructorID=333,DepartmentName="History"},
                new Department{ DepartmentID=963,InstructorID=444,DepartmentName="Art"},
                new Department{ DepartmentID=753,InstructorID=444,DepartmentName="Architecture"}
            };
            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var courses =new List<Course>
            {
                new Course{CourseID=1050,DepartmentID=123,Title="Chemistry",Credits=3},
                new Course{CourseID=4022,DepartmentID=456,Title="Microeconomics",Credits=3},
                new Course{CourseID=4041,DepartmentID=456,Title="Macroeconomics",Credits=3},
                new Course{CourseID=1045,DepartmentID=789,Title="Calculus",Credits=4},
                new Course{CourseID=3141,DepartmentID=789,Title="Trigonometry",Credits=4},
                new Course{CourseID=2021,DepartmentID=741,Title="Composition",Credits=3},
                new Course{CourseID=2042,DepartmentID=741,Title="Literature",Credits=4}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050,Grade=Grade.C},
                new Enrollment{StudentID=4,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
                new Enrollment{StudentID=8,CourseID=1050,Grade=Grade.B}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}