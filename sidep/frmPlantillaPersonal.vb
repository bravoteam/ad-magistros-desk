Public Class frmPlantillaPersonal

    Private Sub btnBuscarCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCT.Click

        Try
            Dim FrmB As New FrmBuscar
            FrmB.vpCual = "CTGrales"
            FrmB.vpOrdenarPor = "Nombre"
            FrmB.ShowDialog()
            If ResultadoBusqueda <> "" Then
                MessageBox.Show(ResultadoBusqueda.Split("|").GetValue(0) & " " & ResultadoBusqueda.Split("|").GetValue(1) & " " & ResultadoBusqueda.Split("|").GetValue(2))
                'inIdCT = ResultadoBusqueda.Split("|").GetValue(0)
                'TxtCveEscuela.Text = ResultadoBusqueda.Split("|").GetValue(1)
                'TxtEscuela.Text = ResultadoBusqueda.Split("|").GetValue(2)
                'TxtCvePue.Focus()
            Else
                MessageBox.Show("La información buscada no existe, verifique la información.", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Se presentó el siguiente error: " & vbCrLf & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        End Try

    End Sub

End Class
