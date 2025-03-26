Imports MySql.Data.MySqlClient

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Dim conexion As String = "server=127.0.0.1;uid=root;pwd=1234;database=testsql"
        Dim datos As New DataTable()

        Try
            Using conexionMySQL As New MySqlConnection(conexion)
                conexionMySQL.Open()

                Dim comandoSQL As String = "SELECT * FROM alumnos"
                Using adaptador As New MySqlDataAdapter(comandoSQL, conexionMySQL)
                    adaptador.Fill(datos)
                End Using
            End Using
            Return View(datos)

        Catch ex As MySqlException
            Return View("Error") ' Crea una vista de error
        End Try
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
