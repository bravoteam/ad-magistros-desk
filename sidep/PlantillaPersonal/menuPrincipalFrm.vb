Public Class menuPrincipalFrm

    Private Sub IniciarCapturaDePlantillaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarCapturaDePlantillaToolStripMenuItem.Click
        frmBuscarCT.Show()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        variables.usuario = ""
        LoginForm1.Show()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
        addPersonal.cctTxt.Text = variables.idCCT
        addPersonal.ShowDialog()
    End Sub

    Private Sub MateriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MateriasToolStripMenuItem.Click
        materiasFrm.Show()
    End Sub

    Private Sub menuPrincipalFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        variables.usuario = ""
        LoginForm1.Show()
    End Sub

    Private Sub InformesDePlantillasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformesDePlantillasToolStripMenuItem.Click
        busquedaPersonal.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        usuariosFrm.Show()
    End Sub
End Class