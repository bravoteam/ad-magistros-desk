'Imports datosCompartidos.Datos.BaseDatos
Imports datosCompartidos.Datos

Public Class frmBuscarPersonal

#Region " ********** MyCode ********** "

    Private Sub BuscarPersonal(ByVal Parametro As String)

        Dim b As New BaseDatos
        Dim ds As DataSet
        Dim sql As String = ""
        Dim i As Integer

        Parametro = SafeSqlLiteral(Parametro)

        sql = "select " & _
                "p.id_personal, p.Apellido_Materno, p.Apellido_Paterno, p.Nombre, p.Ficha,p.Domicilio,p.numExt,p.Id_Colonia " & _
                "from Personal p " & _
                "WHERE (p.Nombre + ' ' + p.Apellido_Paterno + ' ' + p.Apellido_Materno) LIKE '%" & Parametro & "%' " & _
                "order by p.apellido_paterno, p.apellido_materno;"

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

        'Grid.Columns.Clear()
        Grid.Rows.Clear()
        Dim MCP As New modelos.modeloCP
        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            For Each f As DataRow In ds.Tables(0).Rows
                Grid.Rows.Add()
                Grid("IdPersonal", i).Value = f("id_personal").ToString.ToUpper
                Grid("PATERNO", i).Value = f("apellido_paterno").ToString.ToUpper
                Grid("MATERNO", i).Value = f("apellido_materno").ToString.ToUpper
                Grid("NOMBRE", i).Value = f("nombre").ToString.ToUpper
                Grid("NumeroControl", i).Value = f("ficha").ToString.ToUpper
                Grid("CALLE", i).Value = f("Domicilio").ToString.ToUpper
                Grid("NUMEXT", i).Value = f("numExt").ToString.ToUpper
                MCP = obtenerColonia(f("Id_Colonia"))
                Grid("COLONIA", i).Value = MCP.nombreColonia.ToString.ToUpper
                i += 1
            Next
        End If

        Grid.Focus()

    End Sub

    Private Sub cargarPersonal(ByVal IdPersonal As String)
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String = ""
        Dim Fila As Integer = 0
        sql = "select " & _
                "p.id_personal, p.Apellido_Materno, p.Apellido_Paterno, p.Nombre, p.Ficha,p.Domicilio,p.numExt,p.Id_Colonia " & _
                "from Personal p " & _
                "WHERE p.id_personal = '" & IdPersonal & "';"

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        frmPlantillaPersonal.Grid.Rows.Add()
        Fila = frmPlantillaPersonal.Grid.RowCount - 1
        Dim MCP As New modelos.modeloCP
        For Each f As DataRow In ds.Tables(0).Rows
            frmPlantillaPersonal.Grid("IdPersonal", Fila).Value = f("id_personal").ToString.ToUpper
            frmPlantillaPersonal.Grid("NOMBRE", Fila).Value = f("nombre").ToString.ToUpper
            frmPlantillaPersonal.Grid("PATERNO", Fila).Value = f("apellido_paterno").ToString.ToUpper
            frmPlantillaPersonal.Grid("MATERNO", Fila).Value = f("apellido_materno").ToString.ToUpper
            frmPlantillaPersonal.Grid("NumeroControl", Fila).Value = f("ficha").ToString.ToUpper
            frmPlantillaPersonal.Grid("CALLE", Fila).Value = f("Domicilio").ToString.ToUpper
            frmPlantillaPersonal.Grid("NUMEXT", Fila).Value = f("numExt").ToString.ToUpper
            MCP = obtenerColonia(f("Id_Colonia"))
            frmPlantillaPersonal.Grid("COLONIA", Fila).Value = MCP.nombreColonia.ToString.ToUpper
        Next

        frmPlantillaPersonal.Grid.FirstDisplayedScrollingRowIndex = frmPlantillaPersonal.Grid.RowCount - 1
        frmPlantillaPersonal.Grid.Rows(frmPlantillaPersonal.Grid.RowCount - 1).Selected = True
        frmPlantillaPersonal.Grid.Focus()

    End Sub

#End Region

    Private Sub txtParametroBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParametroBusqueda.KeyPress

        If e.KeyChar = Chr(13) And txtParametroBusqueda.TextLength > 0 Then
            BuscarPersonal(txtParametroBusqueda.Text)
        End If

    End Sub

    Private Sub btnBuscarCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCT.Click

        If txtParametroBusqueda.TextLength > 0 Then
            BuscarPersonal(txtParametroBusqueda.Text)
        End If

    End Sub

    Private Sub frmBuscarPersonal_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtParametroBusqueda.Focus()
    End Sub

    Private Sub Grid_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentDoubleClick

        Dim Fila As DataGridViewRow
        Dim IdPersonal As String

        If Grid.Rows.Count > 0 Then
            Fila = Grid.CurrentRow
            IdPersonal = Grid.Rows(Fila.Index).Cells("IdPersonal").Value.ToString
            cargarPersonal(IdPersonal)
            Me.Dispose()
        End If

    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown

        Dim Fila As DataGridViewRow
        Dim IdPersonal As String

        If Grid.Rows.Count > 0 And e.KeyCode = Keys.Enter Then
            Fila = Grid.CurrentRow
            IdPersonal = Grid.Rows(Fila.Index).Cells("IdPersonal").Value.ToString
            cargarPersonal(IdPersonal)
            e.Handled = True
            Me.Dispose()
        End If

    End Sub

End Class