Imports datosCompartidos.Datos

Public Class agregarCtFrm

    Private Sub txtFiltra_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltra.KeyPress
        If e.KeyChar = Chr(13) And txtFiltra.TextLength > 0 Then
            buscarCt(txtFiltra.Text)
        End If
    End Sub
    Private Sub buscarCt(parametro As String)
        Dim b As New BaseDatos
        Dim ds As DataSet
        Dim sql As String = ""
        Dim i As Integer

        parametro = SafeSqlLiteral(parametro)

        sql = "select " & _
                "IdCT, CCT, nombre, calle " & _
                "from CT " & _
                "WHERE (CCT LIKE '%" & parametro & "%') or (nombre LIKE '%" & parametro & "%')  " & _
                "order by nombre;"

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        If ds.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("No se han encontrado registros.", _
                            "Buscar Personal", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        'gridCt.Rows.Clear()
        If ds.Tables(0).Rows.Count > 0 Then
            gridCt.DataSource = ds.Tables(0)
        End If
        gridCt.Focus()
    End Sub

    Private Sub gridCt_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridCt.CellContentDoubleClick
        Dim b As New BaseDatos
        Dim sql As String = ""
        If gridCt.RowCount > 0 Then
            usuariosFrm.Grid.Rows.Add(gridCt.Rows(e.RowIndex).Cells("IdCT").Value, gridCt.Rows(e.RowIndex).Cells("CCT").Value, gridCt.Rows(e.RowIndex).Cells("NOMBRE").Value)
            usuariosFrm.txtUsuario.Text = gridCt.Rows(e.RowIndex).Cells("CCT").Value
            usuariosFrm.txtPassword.Text = gridCt.Rows(e.RowIndex).Cells("CCT").Value
        End If
        Me.Hide()
        usuariosFrm.Show()
    End Sub

    Private Sub gridCt_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gridCt.KeyDown
        Dim b As New BaseDatos
        Dim sql As String = ""
        If gridCt.RowCount > 0 Then
            If e.KeyCode = Keys.Enter Then
                usuariosFrm.Grid.Rows.Add(gridCt.Item("IdCT", gridCt.CurrentRow.Index).Value, gridCt.Item("CCT", gridCt.CurrentRow.Index).Value, gridCt.Item("NOMBRE", gridCt.CurrentRow.Index).Value)
                usuariosFrm.txtUsuario.Text = gridCt.Item("CCT", gridCt.CurrentRow.Index).Value
                usuariosFrm.txtPassword.Text = gridCt.Item("CCT", gridCt.CurrentRow.Index).Value
            End If
            Me.Hide()
            usuariosFrm.Show()
        End If
    End Sub
End Class