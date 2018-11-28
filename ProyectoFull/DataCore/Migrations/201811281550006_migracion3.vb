Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class migracion3
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Grado",
                Function(c) New With
                    {
                        .GradoId = c.Long(nullable := False, identity := True),
                        .Nombre = c.String(maxLength := 20)
                    }) _
                .PrimaryKey(Function(t) t.GradoId)
            
            AddColumn("dbo.Alumno", "GradoId", Function(c) c.Long(nullable := False))
            CreateIndex("dbo.Alumno", "GradoId")
            AddForeignKey("dbo.Alumno", "GradoId", "dbo.Grado", "GradoId", cascadeDelete := True)
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Alumno", "GradoId", "dbo.Grado")
            DropIndex("dbo.Alumno", New String() { "GradoId" })
            DropColumn("dbo.Alumno", "GradoId")
            DropTable("dbo.Grado")
        End Sub
    End Class
End Namespace
