Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class migracion2
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Alumno", "FechaNacimiento", Function(c) c.DateTime(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Alumno", "FechaNacimiento")
        End Sub
    End Class
End Namespace
