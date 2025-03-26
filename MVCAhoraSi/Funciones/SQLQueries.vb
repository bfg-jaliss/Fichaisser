Imports MySql.Data.MySqlClient

Public Class MySQLHelper

    Private Shared Function ObtenerConexion() As MySqlConnection
        Dim conexion As New MySqlConnection("server=localhost;user id=root;password=1234;database=fichaje")
        conexion.Open()
        Return conexion
    End Function

    Public Shared Function InsertarEntradaSalida(tabla As String, id_usuario As Object) As Integer?

        Dim consulta = $"INSERT INTO {tabla} (id_usuario, dia_hora) VALUES ({id_usuario}, NOW())"

        Using conexion As MySqlConnection = ObtenerConexion()
            Using comando As New MySqlCommand(consulta, conexion)
                Return comando.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Shared Function ObtenerEstado(id_usuario) As String
        Dim consulta = $"Select estado from horas_sesion where id_usuario = {id_usuario}"

        Using conexion As MySqlConnection = ObtenerConexion()
            Using comando As New MySqlCommand(consulta, conexion)
                Return comando.ExecuteScalar()
            End Using
        End Using
    End Function

    'Public Shared Function InsertEntradas(columna As String, valor As Object, idEntrada As Integer) As Integer
    '    Dim consulta = $"UPDATE entradas SET {columna} = @valor WHERE id = @idEntrada"
    '    Using conexion As MySqlConnection = ObtenerConexion()
    '        Using comando As New MySqlCommand(consulta, conexion)
    '            comando.Parameters.AddWithValue("@valor", valor)
    '            comando.Parameters.AddWithValue("@idEntrada", idEntrada)
    '            Return comando.ExecuteNonQuery()
    '        End Using
    '    End Using
    'End Function

End Class
