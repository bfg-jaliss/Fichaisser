@Code
    ViewData("Title") = "fichaje"
End Code

<h2>fichaje</h2>


@Code
    If ViewData("estado").ToString() <> "dentro" Then
End Code
    <button>@Html.ActionLink("Entrada", "Entrada", "FichajeSection")</button>
@Code
    Else
End Code
    <p>Entrada</p>
@Code
    End If
End Code



<button>@Html.ActionLink("Salida", "Salida", "FichajeSection")</button>
