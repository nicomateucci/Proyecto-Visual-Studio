Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class migracion1
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Alumno",
                Function(c) New With
                    {
                        .Id = c.Long(nullable := False, identity := True),
                        .Apellido = c.String(nullable := False, maxLength := 100),
                        .Nombre = c.String(nullable := False, maxLength := 100),
                        .NroDocumento = c.String(maxLength := 30)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Alumno")
        End Sub
    End Class
End Namespace
