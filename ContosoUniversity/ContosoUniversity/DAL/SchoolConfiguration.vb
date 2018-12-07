Imports System.Data.Entity
Imports System.Data.Entity.SqlServer

'Imports System.Data.Entity.Infrastructure.Interception

Namespace DAL
    Public Class SchoolConfiguration
        Inherits DbConfiguration

        Public Sub New()
            SetExecutionStrategy("System.Data.SqlClient", Function() New SqlAzureExecutionStrategy())

            'El metodo DbInterception.Add no puede estar reptido en dos lugares distintos.
            'DbInterception.Add(New SchoolInterceptorTransientErrors())
            'DbInterception.Add(New SchoolInterceptorLogging())
        End Sub

    End Class
End Namespace