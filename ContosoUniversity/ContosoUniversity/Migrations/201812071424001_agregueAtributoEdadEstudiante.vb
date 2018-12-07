Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class agregueAtributoEdadEstudiante
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Student", "Edad", Function(c) c.Int(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Student", "Edad")
        End Sub
    End Class
End Namespace
