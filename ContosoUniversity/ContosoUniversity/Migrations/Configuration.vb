Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports ContosoUniversity.DAL
Imports ContosoUniversity.Models

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of SchoolContext)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        Protected Overrides Sub Seed(context As SchoolContext)
            Dim students = New List(Of Student)() From {
                New Student() With {
                    .FirstMidName = "Carson",
                    .LastName = "Alexander",
                    .EnrollmentDate = DateTime.Parse("2010-09-01"),
                    .Edad = 56
                },
                New Student() With {
                    .FirstMidName = "Meredith",
                    .LastName = "Alonso",
                    .EnrollmentDate = DateTime.Parse("2012-09-01"),
                    .Edad = 35
                },
                New Student() With {
                    .FirstMidName = "Arturo",
                    .LastName = "Anand",
                    .EnrollmentDate = DateTime.Parse("2013-09-01"),
                    .Edad = 69
                },
                New Student() With {
                    .FirstMidName = "Gytis",
                    .LastName = "Barzdukas",
                    .EnrollmentDate = DateTime.Parse("2012-09-01"),
                    .Edad = 26
                },
                New Student() With {
                    .FirstMidName = "Yan",
                    .LastName = "Li",
                    .EnrollmentDate = DateTime.Parse("2012-09-01"),
                    .Edad = 35
                },
                New Student() With {
                    .FirstMidName = "Peggy",
                    .LastName = "Justice",
                    .EnrollmentDate = DateTime.Parse("2011-09-01"),
                    .Edad = 39
                },
                New Student() With {
                    .FirstMidName = "Laura",
                    .LastName = "Norman",
                    .EnrollmentDate = DateTime.Parse("2013-09-01"),
                    .Edad = 49
                },
                New Student() With {
                    .FirstMidName = "Nino",
                    .LastName = "Olivetto",
                    .EnrollmentDate = DateTime.Parse("2005-08-11"),
                    .Edad = 89
                }
            }
            For Each s In students
                context.Students.AddOrUpdate(Function(p) p.LastName, s)
            Next

            context.SaveChanges()

            Dim courses = New List(Of Course)() From {
                New Course() With {
                    .CourseID = 1050,
                    .Title = "Chemistry",
                    .Credits = 3
                },
                New Course() With {
                    .CourseID = 4022,
                    .Title = "Microeconomics",
                    .Credits = 3
                },
                New Course() With {
                    .CourseID = 4041,
                    .Title = "Macroeconomics",
                    .Credits = 3
                },
                New Course() With {
                    .CourseID = 1045,
                    .Title = "Calculus",
                    .Credits = 4
                },
                New Course() With {
                    .CourseID = 3141,
                    .Title = "Trigonometry",
                    .Credits = 4
                },
                New Course() With {
                    .CourseID = 2021,
                    .Title = "Composition",
                    .Credits = 3
                },
                New Course() With {
                    .CourseID = 2042,
                    .Title = "Literature",
                    .Credits = 4
                }
            }
            For Each c In courses
                context.Courses.AddOrUpdate(Function(p) p.Title, c)
            Next
            context.SaveChanges()

            Dim enrollments = New List(Of Enrollment)() From {
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Alexander").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Chemistry").CourseID,
                    .Grade = Grade.A
                },
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Alexander").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Microeconomics").CourseID,
                    .Grade = Grade.C
                },
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Alexander").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Macroeconomics").CourseID,
                    .Grade = Grade.B
                },
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Alonso").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Calculus").CourseID,
                    .Grade = Grade.B
                },
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Alonso").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Trigonometry").CourseID,
                    .Grade = Grade.B
                },
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Alonso").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Composition").CourseID,
                    .Grade = Grade.B
                },
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Anand").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Chemistry").CourseID
                },
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Anand").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Microeconomics").CourseID,
                    .Grade = Grade.B
                },
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Barzdukas").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Chemistry").CourseID,
                    .Grade = Grade.B
                },
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Li").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Composition").CourseID,
                    .Grade = Grade.B
                },
                New Enrollment() With {
                    .StudentID = students.Single(Function(s) s.LastName = "Justice").ID,
                    .CourseID = courses.Single(Function(c) c.Title = "Literature").CourseID,
                    .Grade = Grade.B
                }
            }

            For Each e As Enrollment In enrollments
                Dim enrollmentInDataBase = context.Enrollments.Where(Function(s) s.Student.ID = e.StudentID AndAlso s.Course.CourseID = e.CourseID).SingleOrDefault()
                If enrollmentInDataBase Is Nothing Then
                    context.Enrollments.Add(e)
                End If
            Next
            context.SaveChanges()
        End Sub


    End Class

End Namespace