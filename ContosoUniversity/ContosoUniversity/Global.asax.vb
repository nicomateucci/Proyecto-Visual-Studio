Imports System.Web.Optimization

'Capitulo 4 del curso
Imports ContosoUniversity.DAL
Imports System.Data.Entity.Infrastructure.Interception

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        'Capitulo 4 del curso
        DbInterception.Add(New SchoolInterceptorTransientErrors())
        DbInterception.Add(New SchoolInterceptorLogging())
    End Sub
End Class
