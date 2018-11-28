Imports System.ComponentModel.DataAnnotations

Public Class Alumno
    <Key>
    Public Property Id As Long

    <Display(Name:="Apellido")>
    <StringLength(100)>
    <Required>
    Public Property Apellido As String

    <Display(Name:="Nombre")>
    <StringLength(100)>
    <Required>
    Public Property Nombre As String

    <Display(Name:="N° Documento")>
    <StringLength(30)>
    Public Property NroDocumento As String

    <Display(Name:="Fecha Nacimiento")>
    <DataType(DataType.Date)>
    Public Property FechaNacimiento As Date

    Public Property GradoId As Long
    Public Overridable Property Grado As Grado

End Class
