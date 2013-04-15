Imports datosCompartidos.Datos
Public Class frmBuscarCT

#Region " ********** MyCode ********** "

    Private Sub BuscarCT(ByVal Parametro As String)

        Dim b As New BaseDatos
        Dim ds As DataSet
        Dim sql As String = ""
        Dim i As Integer

        Parametro = SafeSqlLiteral(Parametro)

        If opNombreCT.Checked = True Then
            sql = "SELECT IDCT, CCT, NOMBRE,calle,numExt,numInt,IdColonia,IdLocalidad FROM CT WHERE NOMBRE LIKE '%" & Parametro & "%' ORDER BY NOMBRE;"
        ElseIf opClaveCT.Checked = True Then
            sql = "SELECT IDCT, CCT, NOMBRE,calle,numExt,numInt,IdColonia,IdLocalidad FROM CT WHERE CCT LIKE '%" & Parametro & "%' ORDER BY NOMBRE;"
        End If

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        'Grid.Columns.Clear()
        Grid.Rows.Clear()

        If ds.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("No se han encontrado Centros de Trabajo", _
                            "Buscar Centro de Trabajo", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim MCP As New modelos.modeloCP
        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            For Each f As DataRow In ds.Tables(0).Rows
                Grid.Rows.Add()
                Grid("IdCT", i).Value = f("idct").ToString.ToUpper
                Grid("CLAVE", i).Value = f("cct").ToString.ToUpper
                Grid("NOMBRE", i).Value = f("nombre").ToString.ToUpper
                Grid("DOMICILIO", i).Value = f("calle").ToString.ToUpper & f("numExt").ToString.ToUpper & " " & f("numInt").ToString.ToUpper
                MCP = obtenerColonia(f("IdColonia"))
                Grid("COLONIA", i).Value = MCP.nombreColonia.ToString.ToUpper
                Grid("MUNICIPIO", i).Value = obtenerLocalidad(f("IdLocalidad")).ToString.ToUpper
                i += 1
            Next
        End If

        Grid.Focus()

    End Sub
    Private Sub traerCTS()

        Dim b As New BaseDatos
        Dim ds As DataSet
        Dim sql As String = ""
        Dim i, valor As Integer
        Dim cadena As String = ""

        For Each valor In variables.array
            cadena = cadena & valor & ","
        Next
        cadena = cadena.Substring(0, cadena.Length - 1)

        sql = "SELECT IDCT, CCT, NOMBRE,calle,numExt,numInt,IdColonia,IdLocalidad FROM CT WHERE IDCT IN (" & cadena & ") ORDER BY NOMBRE;"
        

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        'Grid.Columns.Clear()
        Grid.Rows.Clear()

        If ds.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("No se han encontrado Centros de Trabajo", _
                            "Buscar Centro de Trabajo", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim MCP As New modelos.modeloCP
        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            For Each f As DataRow In ds.Tables(0).Rows
                Grid.Rows.Add()
                Grid("IdCT", i).Value = f("idct").ToString.ToUpper
                Grid("CLAVE", i).Value = f("cct").ToString.ToUpper
                Grid("NOMBRE", i).Value = f("nombre").ToString.ToUpper
                Grid("DOMICILIO", i).Value = f("calle").ToString.ToUpper & f("numExt").ToString.ToUpper & " " & f("numInt").ToString.ToUpper
                MCP = obtenerColonia(f("IdColonia"))
                Grid("COLONIA", i).Value = MCP.nombreColonia.ToString.ToUpper
                Grid("MUNICIPIO", i).Value = obtenerLocalidad(f("IdLocalidad")).ToString.ToUpper
                i += 1
            Next
        End If

        Grid.Focus()

    End Sub

    Private Sub cargarCT(ByVal IdCT As String)
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim ds2 As New DataSet
        Dim ds3 As New DataSet
        Dim sql As String = ""
        variables.idPlantilla = 0

        'b.abrirConexion()
        'sql = "select idCicloEscolar from cicloescolar where activo = 1;"
        'ds = b.getDataSet(sql)
        variables.idCicloEscolar = cmbCiclo.SelectedValue
        variables.CicloEscolar = cmbCiclo.Text
        'b.cerrarConexion()
        ' ds = Nothing

        'b.abrirConexion()
        'sql = "select descripcion from cicloescolar where activo = 1;"
        'ds2 = b.getDataSet(sql)
        'CicloEscolar = b.getValor(sql, 0)
        'b.cerrarConexion()
        'ds = Nothing

        b.abrirConexion()
        sql = "select * from CT where idct = '" & IdCT & "';"
        ds3 = b.getDataSet(sql)
        b.cerrarConexion()

        With frmPlantillaPersonal



            For Each f As DataRow In ds3.Tables(0).Rows
                .txtIdCT.Text = f("idct").ToString.ToUpper
                .txtClave.Text = f("cct").ToString.ToUpper
                .txtNombreCT.Text = f("nombre").ToString.ToUpper
                .txtTurno.Text = ObtenerTurno(f("idTurno"))
                .txtCP.Text = obtenerCPBC(f("idColonia"))
                .txtMunicipio.Text = obtenerLocalidad(f("idLocalidad"))
                .txtLocalidad.Text = obtenerLocalidad(f("idlocalidad"))
                .txtDomicilio.Text = f("calle").ToString.ToUpper & " " & f("numExt").ToString.ToUpper & " " & f("numInt").ToString.ToUpper
                .txtTelefono.Text = f("telefono").ToString.ToUpper
                .txtCicloEscolar.Text = Trim(variables.CicloEscolar)
                variables.IdNivel = Integer.Parse(f("idnivel").ToString)
            Next

        End With
        ds = Nothing

        frmPlantillaPersonal.cargarPersonal(IdCT, variables.idCicloEscolar)
        frmPlantillaPersonal.cargarEstadisticas(IdCT, variables.idCicloEscolar)

    End Sub

#End Region
    Private Sub frmBuscarCT_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        opNombreCT.Select()
        txtParametroBusqueda.Focus()
    End Sub

    Private Sub txtParametroBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParametroBusqueda.KeyPress

        If e.KeyChar = Chr(13) And txtParametroBusqueda.TextLength > 0 Then
            BuscarCT(txtParametroBusqueda.Text)
        End If

    End Sub

    Private Sub btnBuscarCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCT.Click

        If txtParametroBusqueda.TextLength > 0 Then
            BuscarCT(txtParametroBusqueda.Text)
        End If

    End Sub

    Private Sub Grid_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentDoubleClick
        Dim mensaje As String
        Dim Fila As DataGridViewRow
        Dim IdCT As String

        If Grid.Rows.Count > 0 Then
            mensaje = MsgBox("Deseas Continuar-Ciclo Escolar: " & cmbCiclo.Text, vbYesNo)
            If mensaje = vbYes Then
                Fila = Grid.CurrentRow
                IdCT = Grid.Rows(Fila.Index).Cells("IdCT").Value.ToString
                variables.idCCT = Val(IdCT)
                variables.idEstadistica = 0
                cargarCT(IdCT)

                Me.Dispose()
                frmPlantillaPersonal.Show()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        Dim mensaje As String
        Dim Fila As DataGridViewRow
        Dim IdCT As String


        If Grid.Rows.Count > 0 And e.KeyCode = Keys.Enter Then
            mensaje = MsgBox("Deseas Continuar-Ciclo Escolar: " & cmbCiclo.Text, vbYesNo)
            If mensaje = vbYes Then
                Fila = Grid.CurrentRow
                IdCT = Grid.Rows(Fila.Index).Cells("IdCT").Value.ToString
                variables.idCCT = Val(IdCT)
                variables.idEstadistica = 0
                cargarCT(IdCT)

                'e.Handled = Trues
                Me.Dispose()
                frmPlantillaPersonal.Show()
            Else
                Exit Sub
            End If
        End If

    End Sub


    Private Sub frmBuscarCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        variables.idPlantilla = 0
        Dim ds As New DataSet

        If variables.array(0) = 0 Then
            txtParametroBusqueda.Enabled = True
            btnBuscarCT.Enabled = True
            ds = funciones.getCiclos
            loadComboBox(ds, cmbCiclo, "idCicloEscolar", "descripcion")
        Else
            txtParametroBusqueda.Enabled = False
            btnBuscarCT.Enabled = False
            traerCTS()
            ds = funciones.getCiclos
            loadComboBox(ds, cmbCiclo, "idCicloEscolar", "descripcion")
        End If
    End Sub

End Class