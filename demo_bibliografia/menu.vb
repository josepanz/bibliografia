Public Class menu
    Private Sub tsmMateria_Click(sender As Object, e As EventArgs) Handles tsmMateria.Click
        Dim form As New frmMateria

        form.Show()
    End Sub

    Private Sub tsmFacultad_Click(sender As Object, e As EventArgs) Handles tsmFacultad.Click
        Dim form As New frmFacultad

        form.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TsmLibro_Click(sender As Object, e As EventArgs) Handles tsmLibro.Click
        Dim form As New libro

        form.Show()
    End Sub

    Private Sub TsmAutor_Click(sender As Object, e As EventArgs) Handles tsmAutor.Click
        Dim form As New autor

        form.Show()
    End Sub

    Private Sub TsmEdicion_Click(sender As Object, e As EventArgs) Handles tsmEdicion.Click
        Dim form As New edicion

        form.Show()
    End Sub

    Private Sub TsmEditorial_Click(sender As Object, e As EventArgs) Handles tsmEditorial.Click
        Dim form As New editorial
        form.Show()
    End Sub
End Class