using System;
using System.Linq;
using DefaultCore.Models;

namespace DefaultCore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
                return; // DB has been seeded

            var students = new[]
            {
                new Student
                {
                    Firstname = "Carson",
                    Lastname = "Alexander",
                    EnrollmentDate = DateTime.Parse("2005-09-01")
                },
                new Student
                {
                    Firstname = "Meredith",
                    Lastname = "Alonso",
                    EnrollmentDate = DateTime.Parse("2002-09-01")
                },
                new Student {Firstname = "Arturo", Lastname = "Anand", EnrollmentDate = DateTime.Parse("2003-09-01")},
                new Student
                {
                    Firstname = "Gytis",
                    Lastname = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2002-09-01")
                },
                new Student
                {
                    Firstname = "Yan", Lastname = "Li", EnrollmentDate = DateTime.Parse("2002-09-01")
                },
                new Student {Firstname = "Peggy", Lastname = "Justice", EnrollmentDate = DateTime.Parse("2001-09-01")},
                new Student {Firstname = "Laura", Lastname = "Norman", EnrollmentDate = DateTime.Parse("2003-09-01")},
                new Student {Firstname = "Nino", Lastname = "Olivetto", EnrollmentDate = DateTime.Parse("2005-09-01")}
            };
            foreach (var s in students)
                context.Students.Add(s);
            context.SaveChanges();

            var courses = new[]
            {
                new Course {CourseId = 1050, Title = "Chemistry", Credit = 3},
                new Course {CourseId = 4022, Title = "Microeconomics", Credit = 3},
                new Course {CourseId = 4041, Title = "Macroeconomics", Credit = 3},
                new Course {CourseId = 1045, Title = "Calculus", Credit = 4},
                new Course {CourseId = 3141, Title = "Trigonometry", Credit = 4},
                new Course {CourseId = 2021, Title = "Composition", Credit = 3},
                new Course {CourseId = 2042, Title = "Literature", Credit = 4}
            };
            foreach (var c in courses)
                context.Courses.Add(c);
            context.SaveChanges();

            var enrollments = new[]
            {
                new Enrollment
                {
                    StudentId = 1,
                    CourseId = 1050,
                    Grade = Grade.A
                },
                new Enrollment {StudentId = 1, CourseId = 4022, Grade = Grade.C},
                new Enrollment {StudentId = 1, CourseId = 4041, Grade = Grade.B},
                new Enrollment {StudentId = 2, CourseId = 1045, Grade = Grade.B},
                new Enrollment {StudentId = 2, CourseId = 3141, Grade = Grade.F},
                new Enrollment {StudentId = 2, CourseId = 2021, Grade = Grade.F},
                new Enrollment {StudentId = 3, CourseId = 1050},
                new Enrollment {StudentId = 4, CourseId = 1050},
                new Enrollment {StudentId = 4, CourseId = 4022, Grade = Grade.F},
                new Enrollment {StudentId = 5, CourseId = 4041, Grade = Grade.C},
                new Enrollment {StudentId = 6, CourseId = 1045},
                new Enrollment {StudentId = 7, CourseId = 3141, Grade = Grade.A}
            };
            foreach (var e in enrollments)
                context.Enrollments.Add(e);
            context.SaveChanges();
        }
    }
}