Imports ContosoUniversity.DAL
Imports ContosoUniversity.ViewModels

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Dim db As SchoolContext = New SchoolContext()
    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        Dim data As IQueryable(Of EnrollmentDateGroup) = db.Students.GroupBy _
                                                     (Function(s) s.EnrollmentDate).Select _
                                                     (Function(g) New EnrollmentDateGroup With
                                                                  {.EnrollmentDate = g.Key, .StudentCount = g.Count()})
        Return View(data.ToList())
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
