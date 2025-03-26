Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "FichajeSection", .action = "Fichaje", .id = UrlParameter.Optional}
        )

        routes.MapRoute(
            name:="AccionBoton1",
            url:="FichajeSectionController/AccionBoton1/{id}",
            defaults:=New With {.controller = "FichajeSectionController", .action = "AccionBoton1", .id = UrlParameter.Optional}
        )

    End Sub
End Module