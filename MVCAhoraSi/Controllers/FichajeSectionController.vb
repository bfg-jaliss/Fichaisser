Imports System.Web.Mvc


Namespace Controllers
    Public Class FichajeSectionController
        Inherits Controller

        ' GET: FichajeSection
        Function Fichaje() As ActionResult
            Dim id_user = 1
            ViewData("estado") = MySQLHelper.ObtenerEstado(id_user)
            Return View()
        End Function

        Function Entrada() As ActionResult
            Dim id_user = 1
            MySQLHelper.InsertarEntradaSalida("entradas", id_user)
            Return RedirectToAction("/") ' Redirige a la vista
        End Function

        Function Salida() As ActionResult
            Dim id_user = 1
            MySQLHelper.InsertarEntradaSalida("salidas", id_user)
            Return RedirectToAction("/") ' Redirige a la vista
        End Function

    End Class
End Namespace