Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Public Class ApplicationDbContext
    Inherits DbContext
    Public Sub New()
        MyBase.New("DefaultConnection")
        Database.SetInitializer(New MigrateDatabaseToLatestVersion(Of ApplicationDbContext, Migrations.Configuration)("DefaultConnection"))
    End Sub
    Public Shared Function Create() As ApplicationDbContext
        Return New ApplicationDbContext
    End Function
    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
        modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
    End Sub

    Public Property Alumno As DbSet(Of Alumno)
    Public Property Grado As DbSet(Of Grado)
End Class
