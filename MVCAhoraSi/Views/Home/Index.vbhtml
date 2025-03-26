@ModelType System.Data.DataTable

@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
    <p><a href="https://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>

<h2>Datos de la Tabla</h2>

@Code
    If Model IsNot Nothing AndAlso Model.Rows.Count > 0 Then
End Code
<table border = "1" >
    <thead>
        <tr>
            @Code
                For Each columna As System.Data.DataColumn In Model.Columns
            End Code
            <th>@columna.ColumnName</th>
            @Code
                Next
            End Code
        </tr>
    </thead>
    <tbody>
        @Code
            For Each fila As System.Data.DataRow In Model.Rows
        End Code
        <tr>
            @Code
                For Each item As Object In fila.ItemArray
            End Code
            <td>@item</td>
            @Code
                Next
            End Code
        </tr>
        @Code
            Next
        End Code
    </tbody>
</table>
@Code
    Else
End Code
<p>No se encontraron datos.</p>
@Code
    End If
End Code
