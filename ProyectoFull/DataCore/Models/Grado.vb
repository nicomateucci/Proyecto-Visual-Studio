Imports System.ComponentModel.DataAnnotations

Public Class Grado
    <Key>
    Public Property GradoId As Long

    <Display(Name:="Grado")>
    <StringLength(20)>
    Public Property Nombre As String

    Public Property Alumno As ICollection(Of Alumno)

End Class
