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
End Class