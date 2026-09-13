Public Class frmMenu

    ' Abre el formulario de consulta de libros.
    Private Sub btnLibros_Click(sender As Object, e As EventArgs) Handles btnLibros.Click

        Using formulario As New frmConsultaLibros()
            formulario.ShowDialog(Me)
        End Using

    End Sub


    ' Abre el formulario de consulta de autores.
    Private Sub btnAutores_Click(sender As Object, e As EventArgs) Handles btnAutores.Click

        Using formulario As New frmConsultaAutores()
            formulario.ShowDialog(Me)
        End Using

    End Sub

End Class