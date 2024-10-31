using ContosoUniversity.Models;

namespace ContosoUniversity.Data;

public static class DbInitializer
{
    public static void Initialize(SchoolContext context)
    {
        // Look for any students.
        if (context.Students.Any())
        {
            return;   // DB has been seeded
        }

        var alexander = new Student
        {
            FirstMidName = "Carson",
            LastName = "Alexander",
            EnrollmentDate = DateTime.Parse("2016-09-01")
        };

        var alonso = new Student
        {
            FirstMidName = "Meredith",
            LastName = "Alonso",
            EnrollmentDate = DateTime.Parse("2018-09-01")
        };

        var anand = new Student
        {
            FirstMidName = "Arturo",
            LastName = "Anand",
            EnrollmentDate = DateTime.Parse("2019-09-01")
        };

        var barzdukas = new Student
        {
            FirstMidName = "Gytis",
            LastName = "Barzdukas",
            EnrollmentDate = DateTime.Parse("2018-09-01")
        };

        var li = new Student
        {
            FirstMidName = "Yan",
            LastName = "Li",
            EnrollmentDate = DateTime.Parse("2018-09-01")
        };

        var justice = new Student
        {
            FirstMidName = "Peggy",
            LastName = "Justice",
            EnrollmentDate = DateTime.Parse("2017-09-01")
        };

        var norman = new Student
        {
            FirstMidName = "Laura",
            LastName = "Norman",
            EnrollmentDate = DateTime.Parse("2019-09-01")
        };

        var olivetto = new Student
        {
            FirstMidName = "Nino",
            LastName = "Olivetto",
            EnrollmentDate = DateTime.Parse("2011-09-01")
        };

        var abercrombie = new Instructor
        {
            FirstMidName = "Kim",
            LastName = "Abercrombie",
            HireDate = DateTime.Parse("1995-03-11")
        };

        var fakhouri = new Instructor
        {
            FirstMidName = "Fadi",
            LastName = "Fakhouri",
            HireDate = DateTime.Parse("2002-07-06")
        };

        var harui = new Instructor
        {
            FirstMidName = "Roger",
            LastName = "Harui",
            HireDate = DateTime.Parse("1998-07-01")
        };

        var kapoor = new Instructor
        {
            FirstMidName = "Candace",
            LastName = "Kapoor",
            HireDate = DateTime.Parse("2001-01-15")
        };

        var zheng = new Instructor
        {
            FirstMidName = "Roger",
            LastName = "Zheng",
            HireDate = DateTime.Parse("2004-02-12")
        };

        var officeAssignments = new OfficeAssignment[]
        {
                new OfficeAssignment {
                Instructor = fakhouri,
                Location = "Smith 17" },
                new OfficeAssignment {
                Instructor = harui,
                Location = "Gowan 27" },
                new OfficeAssignment {
                Instructor = kapoor,
                Location = "Thompson 304" },
        };

        context.AddRange(officeAssignments);

        var ingles = new Department
        {
            Name = "Ingles",
            Budget = 350000,
            StartDate = DateTime.Parse("2007-09-01"),
            Administrator = abercrombie
        };

        var matematicas = new Department
        {
             Name = "Matematicas",
             Budget = 10000,
             StartDate = DateTime.Parse("2007-09-0"),
             Administrator = harui
        };

        var ingenieria = new Department
        {
             Name = "Ingenieria",
             Budget = 350000,
             StartDate = DateTime.Parse("2007-09-01"),
             Administrator = harui
        };

        var economias = new Department
        {
            Name = "Economias",
            Budget =100000,
            StartDate = DateTime.Parse("2007-09-01"),
            Administrator = kapoor
        };

        var quimica = new Course
        {
            CourseID = 1050,
            Title = "Quimica",
            Credits = 3,
            Department = ingenieria,         
            Instructors = new List<Instructor> { kapoor, harui }
        };

        var microeconomias = new Course
        {
            CourseID = 4022,
            Title = "Microeconomias",
            Credits = 3,
            Department = economias,           
            Instructors = new List<Instructor> { zheng }
        };

        var macroeconmias = new Course
        {
            CourseID = 4041,
            Title = "Macroeconomias",
            Credits = 3,
            Department = economias,
            Instructors = new List<Instructor> { zheng }
        };

        var calculo = new Course
        {
            CourseID = 1045,
            Title = "Calculo",
            Credits = 4,
            Department = matematicas,
            Instructors = new List<Instructor> { fakhouri }
        };

        var trigonometria = new Course
        {
            CourseID = 3141,
            Title = "Trigonometria",
            Credits = 4,
            Department = matematicas,
            Instructors = new List<Instructor> { harui }
        };

        var composicion = new Course
        {
            CourseID = 2021,
            Title = "Composicion",
            Credits = 3,
            Department = ingles,
            Instructors = new List<Instructor> { abercrombie }
        };

        var literatura = new Course
        {
            CourseID = 2042,
            Title = "Literatura",
            Credits = 4,
            Department = ingles,
            Instructors = new List<Instructor> { abercrombie }
        };

        var enrollments = new Enrollment[]
        {
                new Enrollment {
                Student = alexander,
                Course = quimica,
                Grade = Grade.A
                },
                new Enrollment {
                Student = alexander,
                Course = microeconomias,
                Grade = Grade.C
                },
                new Enrollment {
                Student = alexander,
                Course = macroeconmias,
                Grade = Grade.B
                },
                new Enrollment {
                Student = alonso,
                Course = calculo,
                Grade = Grade.B
                },
                new Enrollment {
                Student = alonso,
                Course = trigonometria,
                Grade = Grade.B
                },
                new Enrollment {
                Student = alonso,
                Course = composicion,
                Grade = Grade.B
                },
                new Enrollment {
                Student = anand,
                Course = quimica,
                },
                new Enrollment {
                Student = anand,
                Course = microeconomias,
                Grade = Grade.B
                },
                new Enrollment {
                Student = barzdukas,
                Course = quimica,
                Grade = Grade.B
                },
                new Enrollment {
                Student = li,
                Course = composicion,
                Grade = Grade.B
                },
                new Enrollment {
                Student = justice,
                Course = literatura,
                Grade = Grade.B
                }
        };

        context.AddRange(enrollments);
        context.SaveChanges();
    }
}
