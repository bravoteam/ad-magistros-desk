Imports System.Data.SqlClient
Imports sidep.PlantillaPersonal.PlantillaPersonal

Public Class addPersonal
    Public Sub limpiarCampos()
        Me.Controls.Clear()
        InitializeComponent()
    End Sub

    Public Sub cargarPersonal(ByVal modelo As modelos.modeloPersonal)
        txtGrado.Text = ""
        txtGrupo.Text = ""
        txtHAP.Text = ""
        txtHD.Text = ""
        txtFG.Text = ""
        cmbPuesto.Items.Clear()
        cmbPuestoID.Items.Clear()
        cmbFuncion.Items.Clear()
        cmbFuncionID.Items.Clear()
        Dim MCP As New modelos.modeloCP
        MCP.idCP = 0
        MCP.nombreColonia = ""
        txtId.Text = modelo.Id_Personal
        txtNombre.Text = modelo.Nombre
        txtApellidoPaterno.Text = modelo.Apellido_Paterno
        txtApellidoMaterno.Text = modelo.Apellido_Materno
        txtCalle.Text = modelo.Domicilio
        txtNumExt.Text = modelo.numExt
        txtNumInt.Text = modelo.numInt
        If modelo.Id_estado = 0 Then
            cmbEstado.Text = ""
        Else
            cmbEstado.Text = obtenerEstado(modelo.Id_estado)
            cmbEstadoId.Text = modelo.Id_estado
        End If
        If modelo.Id_Localidad = 0 Then
            cmbMunicipio.Text = ""
        Else
            cmbMunicipio.Text = obtenerMunicipio(modelo.Id_Localidad)
            cmbMunicipioId.Text = modelo.Id_Localidad
        End If
        If modelo.Id_Colonia = 0 Then
            cmbColonia.Text = ""
        Else
            MCP = obtenerColonia(modelo.Id_Colonia)
            cmbColonia.Text = MCP.nombreColonia
            cmbColoniaId.Text = modelo.Id_Colonia
        End If
        If modelo.Id_Colonia = 0 Then
            txtCp.Text = ""
        Else
            txtCp.Text = obtenerCP(MCP.idCP)
        End If
        txtCURP.Text = modelo.CURP
        txtTelefono.Text = modelo.Telefono
        txtCelular.Text = modelo.Celular
        txtFicha.Text = modelo.Ficha
        cmbNivel.Text = modelo.nivelMaximo
        txtPreparacion.Text = modelo.preparacion

        txtGrado.Text = ""
        txtGrupo.Text = ""
        txtHAP.Text = ""
        txtHD.Text = ""
        txtFG.Text = ""
        cmbPuesto.Items.Clear()
        cmbPuestoID.Items.Clear()
        cmbFuncion.Items.Clear()
        cmbFuncionID.Items.Clear()
        cmbFuncion.Text = ""
        cmbPuesto.Text = ""
        cmbPuestoID.Text = "0"
        cmbFuncionID.Text = "0"
        Grid.Rows.Clear()


        'Horarios - cargar materias
        Dim ds As New DataSet
        ds = getMaterias(variables.IdNivel)
        loadComboBox(ds, cmbMateria, "id_materia", "materia")
        ds = Nothing
        GridHorario.Rows.Clear()
        cargarHorario(variables.idPlantilla)
        variables.IdHorario = 0
    End Sub
    Public Sub cargarHorario(ByVal IdPlantilla As String)

        Dim ds As New DataSet
        Dim Horas As New List(Of String)
        Dim hora_ As String = ""
        Dim aux As String = ""
        Dim Contenido As String = ""
        Dim IdHorario As String = ""

        GridHorario.Rows.Clear()

        ds = getHorario(variables.idPlantilla)

        'obtener horas
        For Each f As DataRow In ds.Tables(0).Rows
            hora_ = f("horaInicio").ToString & "-" & f("horaFin").ToString
            If aux <> hora_ And Horas.Contains(hora_) = False Then
                Horas.Add(hora_)
            End If
        Next

        'mostrar horas en el grid
        For Each h As String In Horas
            GridHorario.Rows.Add("", h, "", "", "", "", "")
        Next

        'mostrar materias y grupos
        For Each f As DataRow In ds.Tables(0).Rows

            IdHorario = f("idHorario").ToString
            hora_ = f("horaInicio").ToString & "-" & f("horaFin").ToString
            Contenido = Trim(f("materia").ToString) & ", " & Trim(f("grado").ToString) & " " & Trim(f("grupo").ToString)

            For Each r As DataGridViewRow In GridHorario.Rows
                Select Case f("dia").ToString
                    Case "1"
                        If hora_ = GridHorario("HORA", r.Index).Value.ToString Then
                            GridHorario("LUNES", r.Index).Value = Contenido
                            GridHorario("LUNES", r.Index).Tag = IdHorario
                        End If

                    Case "2"
                        If hora_ = GridHorario("HORA", r.Index).Value.ToString Then
                            GridHorario("MARTES", r.Index).Value = Contenido
                            GridHorario("MARTES", r.Index).Tag = IdHorario
                        End If

                    Case "3"
                        If hora_ = GridHorario("HORA", r.Index).Value.ToString Then
                            GridHorario("MIERCOLES", r.Index).Value = Contenido
                            GridHorario("MIERCOLES", r.Index).Tag = IdHorario
                        End If

                    Case "4"
                        If hora_ = GridHorario("HORA", r.Index).Value.ToString Then
                            GridHorario("JUEVES", r.Index).Value = Contenido
                            GridHorario("JUEVES", r.Index).Tag = IdHorario
                        End If

                    Case "5"
                        If hora_ = GridHorario("HORA", r.Index).Value.ToString Then
                            GridHorario("VIERNES", r.Index).Value = Contenido
                            GridHorario("VIERNES", r.Index).Tag = IdHorario
                        End If

                End Select
            Next
        Next

    End Sub
    Public Sub limpiarCamposOtros()
        txtGrado.Text = ""
        txtGrupo.Text = ""
        txtHAP.Text = ""
        txtHD.Text = ""
        txtFG.Text = ""
        cmbPuesto.Text = ""
        cmbPuestoID.Text = ""
        cmbFuncion.Text = ""
        cmbFuncionID.Text = ""
        Grid.Rows.Clear()
    End Sub
    Public Sub cargarPlantilla(ByVal modelo As modelos.modeloPlantilla)
        txtHAP.Text = modelo.HA
        txtHD.Text = modelo.HD
        txtFG.Text = modelo.HG
        txtGrado.Text = modelo.grados
        txtGrupo.Text = modelo.grupos
        If modelo.idPuesto = 0 Then
            cmbPuesto.Text = ""
        Else
            cmbPuesto.Text = obtenerPuesto(modelo.idPuesto)
            cmbPuestoID.Text = modelo.idPuesto
        End If
        If modelo.idFuncion = 0 Then
            cmbFuncion.Text = ""
        Else
            cmbFuncion.Text = obtenerFuncion(modelo.idFuncion)
            cmbFuncionID.Text = modelo.idFuncion
        End If

    End Sub
    Public Sub cargarSustituye(ByVal id As Integer)

        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from pesonalSustituye where idPlantilla = " & id & " order by idPersonalSustituye"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                Dim M As New modelos.modeloPersonal
                M = obtenerPersonal(variables.SQLdr("idPersonalS"))
                Grid.Rows.Add(variables.SQLdr("idPersonalSustituye"),
                                          variables.SQLdr("idPersonal"),
                                          variables.SQLdr("idPersonalS"),
                                          M.Ficha,
                        M.Nombre + " " +
                        M.Apellido_Paterno + " " +
                        M.Apellido_Materno, variables.SQLdr("observaciones"))
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub llenarColonias(ByVal idCP As Integer)
        cmbColonia.Items.Clear()
        cmbColoniaId.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from colonia where id_codigo_postal = " & idCP & " order by nombre"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbColonia.Items.Add(variables.SQLdr("nombre").ToString)
                cmbColoniaId.Items.Add(variables.SQLdr("id_colonia"))
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub btnBuscar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar2.Click
        frmBuscar.limpiarCampos()
        variables.banderaAccion = "personalS"
        frmBuscar.ShowDialog()
    End Sub
    Private Sub cmbPuesto_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPuesto.DropDown
        cmbPuesto.Items.Clear()
        cmbPuestoID.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from puestos order by Descripcion"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbPuesto.Items.Add(variables.SQLdr("Descripcion").ToString)
                cmbPuestoID.Items.Add(variables.SQLdr("idPuesto").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub cmbFuncion_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFuncion.DropDown
        cmbFuncion.Items.Clear()
        cmbFuncionID.Items.Clear()

        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from funciones order by Descripcion"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbFuncion.Items.Add(variables.SQLdr("Descripcion").ToString)
                cmbFuncionID.Items.Add(variables.SQLdr("idFuncion").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub salirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirCmd.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        guardarDatos(True)
    End Sub
    Private Sub guardarDatos(ByVal valor As Boolean)
        Dim __mP As New modelos.modeloPersonal
        __mP.Apellido_Materno = txtApellidoMaterno.Text
        __mP.Apellido_Paterno = txtApellidoPaterno.Text
        __mP.Celular = txtCelular.Text
        __mP.CURP = txtCURP.Text
        __mP.Domicilio = txtCalle.Text
        __mP.Ficha = txtFicha.Text
        __mP.Id_Colonia = Val(cmbColoniaId.Text)
        __mP.Id_estado = Val(cmbEstadoId.Text)
        __mP.Id_Localidad = Val(cmbMunicipioId.Text)
        __mP.Id_Personal = Val(txtId.Text)
        __mP.Nombre = txtNombre.Text
        __mP.numExt = txtNumExt.Text
        __mP.numInt = txtNumInt.Text
        __mP.Telefono = txtTelefono.Text
        __mP.nivelMaximo = cmbNivel.Text
        If txtPreparacion.Text = "" Then
            txtPreparacion.Text = " "
        End If
        __mP.preparacion = txtPreparacion.Text
        If funcionesLocales.validarReceptorTabs(TabPage1) = True Then
            If __mP.Id_Personal > 0 Then
                funcionesLocales.actualizarPersonal(__mP)
            Else
                If txtFicha.Text <> "" Then
                    If funcionesLocales.validarFicha(Val(txtFicha.Text)) = False Then
                        MsgBox("Ficha Existentente, verifique porfavor")
                        Exit Sub
                    End If
                End If
                funcionesLocales.guardarPersonal(__mP)
                Dim _m As New modelos.modeloPersonal
                _m = funcionesLocales.traerUltimoPersonal()

                Dim MCP As New modelos.modeloCP
                MCP.idCP = 0
                MCP.nombreColonia = ""
                txtId.Text = _m.Id_Personal
                txtNombre.Text = _m.Nombre
                txtApellidoPaterno.Text = _m.Apellido_Paterno
                txtApellidoMaterno.Text = _m.Apellido_Materno
                txtCalle.Text = _m.Domicilio
                txtNumExt.Text = _m.numExt
                txtNumInt.Text = _m.numInt
                If _m.Id_estado = 0 Then
                    cmbEstado.Text = ""
                Else
                    cmbEstado.Text = obtenerEstado(_m.Id_estado)
                    cmbEstadoId.Text = _m.Id_estado
                End If
                If _m.Id_Localidad = 0 Then
                    cmbMunicipio.Text = ""
                Else
                    cmbMunicipio.Text = obtenerMunicipio(_m.Id_Localidad)
                    cmbMunicipioId.Text = _m.Id_Personal
                End If
                If _m.Id_Colonia = 0 Then
                    cmbColonia.Text = ""
                Else
                    MCP = obtenerColonia(_m.Id_Colonia)
                    cmbColonia.Text = MCP.nombreColonia
                    cmbColoniaId.Text = _m.Id_Colonia
                End If
                If _m.Id_Colonia = 0 Then
                    txtCp.Text = ""
                Else
                    txtCp.Text = obtenerCP(MCP.idCP)
                End If
                txtCURP.Text = _m.CURP
                txtTelefono.Text = _m.Telefono
                txtCelular.Text = _m.Celular
                txtFicha.Text = _m.Ficha
            End If
        End If


        If txtHAP.Text = "" Then
            txtHAP.Text = 0
        End If
        If txtHD.Text = "" Then
            txtHD.Text = 0
        End If
        If txtFG.Text = "" Then
            txtFG.Text = 0
        End If
        Dim __mPlantilla As New modelos.modeloPlantilla
        __mPlantilla.idPlantilla = variables.idPlantilla
        __mPlantilla.captura = ""
        __mPlantilla.fechaCaptura = "2012-01-01"
        __mPlantilla.fechaRevision = Now.Date
        __mPlantilla.HA = txtHAP.Text
        __mPlantilla.HD = txtHD.Text
        __mPlantilla.HG = txtFG.Text
        __mPlantilla.idCCT = Val(cctTxt.Text)
        __mPlantilla.idCicloEscolar = variables.idCicloEscolar
        __mPlantilla.idFuncion = Val(cmbFuncionID.Text)
        __mPlantilla.grados = txtGrado.Text
        __mPlantilla.grupos = txtGrupo.Text
        __mPlantilla.idPersonal = Val(txtId.Text)
        __mPlantilla.idPuesto = Val(cmbPuestoID.Text)
        __mPlantilla.revisa = ""

        If funcionesLocales.validarReceptorTabs(TabPage1) = True Then
            If __mPlantilla.idPersonal > 0 Then
                If __mPlantilla.idPlantilla > 0 And variables.banderaAccion2 = "MODIFICACION" Then
                    funcionesLocales.actualizarPlantilla(__mPlantilla)
                    For Each row As DataGridViewRow In Grid.Rows
                        Dim MM As New modelos.modelosSustituye
                        MM.idPersonal = row.Cells("idPersonal").Value
                        MM.idPersonalS = row.Cells("idPersonalS").Value
                        MM.idPlantilla = variables.idPlantilla
                        MM.observaciones = row.Cells("observaciones").Value.ToString
                        If row.Cells("idPersonalSustituye").Value = 0 Then
                            funcionesLocales.guardarSustituye(MM)
                        Else
                            funcionesLocales.actualizarSustituye(MM)
                        End If
                    Next
                Else
                    If valor = True Then
                        If funcionesLocales.validarPersonalEnPlantilla(Val(txtId.Text), Val(cctTxt.Text), variables.idCicloEscolar) = False Then
                            MsgBox("Personal Existente en Plantilla, verifique porfavor")
                            Exit Sub
                        End If
                    End If
                    funcionesLocales.guardarPlantilla(__mPlantilla)
                    variables.idPlantilla = traerUltimaPlantilla()
                    For Each row As DataGridViewRow In Grid.Rows
                        Dim MM As New modelos.modelosSustituye
                        MM.idPersonal = row.Cells("idPersonal").Value
                        MM.idPersonalS = row.Cells("idPersonalS").Value
                        MM.idPlantilla = variables.idPlantilla
                        MM.observaciones = row.Cells("observaciones").Value.ToString
                        If row.Cells("idPersonalSustituye").Value = 0 Then
                            funcionesLocales.guardarSustituye(MM)
                        Else
                            funcionesLocales.actualizarSustituye(MM)
                        End If
                    Next
                End If
                If valor = True Then
                    frmPlantillaPersonal.cargarPersonal(Val(cctTxt.Text), variables.idCicloEscolar)
                    Me.Hide()
                    frmPlantillaPersonal.Show()
                End If
            End If
        End If
    End Sub

    Private Sub cmbFuncion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFuncion.SelectedValueChanged
        cmbFuncionID.SelectedIndex = cmbFuncion.SelectedIndex
    End Sub

    Private Sub cmbPuesto_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPuesto.SelectedValueChanged
        cmbPuestoID.SelectedIndex = cmbPuesto.SelectedIndex
    End Sub

    Private Sub cmbNivel_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNivel.DropDown
        cmbNivel.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from niveles order by Descripcion"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbNivel.Items.Add(variables.SQLdr("Descripcion").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub obtenerCpCmd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim modeloD As New modelos.modeloDireccion
        modeloD = obtenerDireccion(txtCP3.Text)
        llenarColonias(modeloD.idCP)
    End Sub

    Private Sub txtCP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCP3.GotFocus
        lblEnter.Visible = True
    End Sub

    Private Sub txtCP_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP3.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim modeloD As New modelos.modeloDireccion
            modeloD = obtenerDireccion(txtCP3.Text)
            cmbEstado.Text = modeloD.nombreEstado
            cmbMunicipio.Text = modeloD.nombreMunicipio
            cmbMunicipioId.Text = modeloD.idLocalidad
            cmbEstadoId.Text = modeloD.idEstado
            llenarColonias(modeloD.idCP)
        End If
    End Sub

    Private Sub cmbColonia_DropDown_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbColonia.DropDown
        Dim modeloD As New modelos.modeloDireccion
        modeloD = obtenerDireccion(txtCp.Text)
        llenarColonias(modeloD.idCP)
    End Sub

    Private Sub cmbColonia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbColonia.SelectedValueChanged
        cmbColoniaId.SelectedIndex = cmbColonia.SelectedIndex
    End Sub

    Private Sub txtCP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCP3.LostFocus
        lblEnter.Visible = False
        Dim modeloD As New modelos.modeloDireccion
        modeloD = obtenerDireccion(txtCP3.Text)
        cmbEstado.Text = modeloD.nombreEstado
        cmbMunicipio.Text = modeloD.nombreMunicipio
        cmbMunicipioId.Text = modeloD.idLocalidad
        cmbEstadoId.Text = modeloD.idEstado
        llenarColonias(modeloD.idCP)
    End Sub


    Private Sub txtCp1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCp.GotFocus
        cmbColonia.Text = ""
        cmbColoniaId.Text = ""
        lblEnter.Visible = True
    End Sub

    Private Sub txtCp1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCp.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim modeloD As New modelos.modeloDireccion
            modeloD = obtenerDireccion(txtCp.Text)
            cmbEstado.Text = modeloD.nombreEstado
            cmbMunicipio.Text = modeloD.nombreMunicipio
            cmbMunicipioId.Text = modeloD.idLocalidad
            cmbEstadoId.Text = modeloD.idEstado
            llenarColonias(modeloD.idCP)
        End If
    End Sub

    Private Sub txtCp1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCp.LostFocus
        lblEnter.Visible = False
        Dim modeloD As New modelos.modeloDireccion
        modeloD = obtenerDireccion(txtCp.Text)
        cmbEstado.Text = modeloD.nombreEstado
        cmbMunicipio.Text = modeloD.nombreMunicipio
        cmbMunicipioId.Text = modeloD.idLocalidad
        cmbEstadoId.Text = modeloD.idEstado
        llenarColonias(modeloD.idCP)
    End Sub


    Private Sub lblEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnter.Click
        Dim modeloD As New modelos.modeloDireccion
        modeloD = obtenerDireccion(txtCp.Text)
        cmbEstado.Text = modeloD.nombreEstado
        cmbMunicipio.Text = modeloD.nombreMunicipio
        cmbMunicipioId.Text = modeloD.idLocalidad
        cmbEstadoId.Text = modeloD.idEstado
        llenarColonias(modeloD.idCP)
    End Sub

    Private Sub btnBuscarCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCP.Click
        buscarDireccion.ShowDialog()
    End Sub
    Private Sub lnkAgregarMateria_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAgregarMateria.LinkClicked

        Dim MateriaNueva As String = ""

        MateriaNueva = InputBox("Proporcione la nueva materia:", "Agregar materia", "")

        If MateriaNueva.Length = 0 Or MateriaNueva = "" Then
            Exit Sub
        ElseIf MateriaNueva.Length > 0 Then
            addMateria(variables.IdNivel.ToString, UCase(MateriaNueva))
        End If

        'Horarios - cargar materias
        Dim ds As New DataSet
        ds = getMaterias(variables.IdNivel)
        loadComboBox(ds, cmbMateria, "id_materia", "materia")

        cmbMateria.SelectedItem = MateriaNueva.ToUpper

    End Sub

    Private Sub btnAgregarHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarHora.Click

        Dim error_ As String = ""

        Dim IdPlantilla As String = ""
        Dim IdMateria As String = ""
        Dim Grado As String = ""
        Dim Grupo As String = ""
        Dim HoraInicio As String = ""
        Dim HoraFin As String = ""
        Dim Dia As String = ""

        guardarDatos(False)
        If variables.idPlantilla = 0 Then Exit Sub

        variables.banderaAccion2 = "MODIFICACION"
        'validar datos
        If cmbDia.Text.Length = 0 Then error_ = error_ & "- Falta proporcionar el día." & vbCrLf
        If Val(txtDe.Text) > Val(txtA.Text) Then error_ = error_ & "- Error No son Validas las HORAS" & vbCrLf
        If cmbHoras.Text = "" Then
            If txtDe.MaskFull = False Or txtDe.Text = "" Then error_ = error_ & "- Falta proporcionar de forma correcta la Hora DE." & vbCrLf
            If txtA.MaskFull = False Or txtA.Text = "" Then error_ = error_ & "- Falta proporcionar de forma correcta la Hora A." & vbCrLf
        Else
            If cmbHoras.Text = "" Then error_ = error_ & "- Falta proporcionar de forma correcta la Hora " & vbCrLf
        End If
        If cmbMateria.Text.Length = 0 Then error_ = error_ & "- Falta proporcionar la materia (asignatura)." & vbCrLf
        If txtGradoH.MaskFull = False Or txtGradoH.Text = "" Then error_ = error_ & "- Falta proporcionar el grado" & vbCrLf
        If txtGrupoH.MaskFull = False Or txtGrupoH.Text = "" Then error_ = error_ & "- Falta proporcionar el grupo" & vbCrLf

        If error_.Length > 0 Then
            MessageBox.Show("No se puede agregar la hora debido a lo siguiente: " & vbCrLf & error_,
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        IdPlantilla = variables.idPlantilla
        IdMateria = cmbMateria.SelectedValue
        Grado = txtGradoH.Text.ToUpper
        Grupo = txtGrupoH.Text.ToUpper
        If cmbHoras.Text = "" Then
            HoraInicio = txtDe.Text.Replace(":", "")
            HoraFin = txtA.Text.Replace(":", "")
        Else
            HoraInicio = Mid(cmbHoras.Text, 1, 5).Replace(":", "")
            HoraFin = Mid(cmbHoras.Text, 7, 5).Replace(":", "")
        End If

        Dia = cmbDia.SelectedValue

        If existeHorario(HoraInicio, Dia, variables.idPlantilla) = True Then
            error_ = "- No se puede agregar una hora duplicada."
            MessageBox.Show("No se puede agregar la hora debido a lo siguiente: " & vbCrLf & error_,
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        addHorario(IdPlantilla, IdMateria, Grado, Grupo, HoraInicio, HoraFin, Dia)

        insertaBitacora("HORA AGREGADA", variables.usuario, variables.idUsuario, variables.idCCT, frmPlantillaPersonal.txtNombreCT.Text, _
                        Val(txtId.Text), txtNombre.Text & " " & txtApellidoPaterno.Text & " " & txtApellidoMaterno.Text, _
                        variables.idPlantilla, 0, 0, "MATERIA: " & cmbMateria.Text & " - GRADO: " & Grado & " - GRUPO " & _
                        Grupo & " - HORA INICIO: " & HoraInicio & " - HORA FIN: " & HoraFin & " - DIA: " & Dia)

        'txtDe.Text = ""
        'txtA.Text = ""
        'txtGradoH.Text = ""
        'txtGrupoH.Clear()
        cmbDia.Focus()

        cargarHorario(variables.idPlantilla)

    End Sub

    Private Sub btnQuitarHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarHora.Click

        If GridHorario.Rows.Count > 0 And variables.IdHorario > 0 Then
            If MessageBox.Show("¿Desea quitar esa hora?", "Pregunta", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            quitarHora(variables.IdHorario)
            insertaBitacora("HORA ELIMINADA", variables.usuario, variables.idUsuario, variables.idCCT, frmPlantillaPersonal.txtNombreCT.Text, _
                       Val(txtId.Text), txtNombre.Text & " " & txtApellidoPaterno.Text & " " & txtApellidoMaterno.Text, _
                       variables.idPlantilla, 0, variables.IdHorario, variables.horarioDescripcion)

            cargarHorario(variables.idPlantilla)
            variables.IdHorario = 0
        End If

    End Sub

    Private Sub GridHorario_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridHorario.CellContentClick
        Dim celda As DataGridViewCell
        celda = GridHorario.CurrentCell
        If GridHorario.Rows.Count > 0 And celda.ColumnIndex <> 1 Then
            variables.IdHorario = Integer.Parse(celda.Tag)
            variables.horarioDescripcion = celda.Value
        End If
    End Sub

    Private Sub txtGrupoH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrupoH.KeyPress
        If e.KeyChar = Chr(13) Then
            btnAgregarHora_Click(sender, Nothing)
        End If
    End Sub

    Private Sub addPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDiasSemana(cmbDia)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim nuevaFuncion As String = ""

        nuevaFuncion = InputBox("Proporcione la nueva Funcion:", "Agregar Funcion", "")

        If nuevaFuncion.Length = 0 Or nuevaFuncion = "" Then
            Exit Sub
        ElseIf nuevaFuncion.Length > 0 Then
            addFuncion(UCase(nuevaFuncion))
        End If
    End Sub

    Private Sub btnQuitarEsta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarEsta.Click
        If Grid.RowCount > 0 Then
            Dim mensaje As String = MsgBox("Deseas Eliminar el Personal a: " & Grid.CurrentRow.Cells("nombre").Value.ToString, vbYesNo)
            If mensaje = vbYes Then
                If Not Grid.CurrentRow.IsNewRow Then
                    insertaBitacora("ELIMINACION DE PERSONAL SUSTITUYE", variables.usuario, variables.idUsuario, variables.idCCT, frmPlantillaPersonal.txtNombreCT.Text, Grid.CurrentRow.Cells("idPersonalS").Value, _
                                    Grid.CurrentRow.Cells("nombre").Value, variables.idPlantilla, _
                                       0, 0, "SE ELIMINÓ EL PERSONAL QUE SUSTITUYE A " & txtNombre.Text & " " & txtApellidoPaterno.Text & " " & txtApellidoMaterno.Text)
                    eliminarPersonalS(Grid.CurrentRow.Cells("idPersonalSustituye").Value)
                    Grid.Rows.Remove(Grid.CurrentRow)
                End If
            End If
        End If
    End Sub

    Private Sub cmbHoras_Click(sender As Object, e As System.EventArgs) Handles cmbHoras.Click
        txtDe.Text = ""
        txtA.Text = ""
    End Sub

    Private Sub cmbHoras_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbHoras.DropDown
        cmbHoras.Items.Clear()
        If tmRadio.Checked = True Then
            cmbHoras.Items.Add("07:00-07:50")
            cmbHoras.Items.Add("07:50-08:40")
            cmbHoras.Items.Add("08:40-09:30")
            cmbHoras.Items.Add("09:30-09:50")
            cmbHoras.Items.Add("09:50-10:40")
            cmbHoras.Items.Add("10:40-11:30")
            cmbHoras.Items.Add("11:30-12:20")
            cmbHoras.Items.Add("12:20-13:10")
        End If
        If tvRadio.Checked = True Then
            cmbHoras.Items.Add("13:20-14:10")
            cmbHoras.Items.Add("14:10-15:00")
            cmbHoras.Items.Add("15:00-15:50")
            cmbHoras.Items.Add("15:50-16:10")
            cmbHoras.Items.Add("16:10-17:00")
            cmbHoras.Items.Add("17:00-17:50")
            cmbHoras.Items.Add("17:50-18:40")
            cmbHoras.Items.Add("18:40-19:30")
        End If
        'If tnRadio.Checked = True Then
        '    cmbHoras.Items.Add("13:20-14:10")
        '    cmbHoras.Items.Add("14:10-15:00")
        '    cmbHoras.Items.Add("15:00-15:50")
        '    cmbHoras.Items.Add("15:50-16:10")
        '    cmbHoras.Items.Add("16:10-17:00")
        '    cmbHoras.Items.Add("17:00-17:50")
        '    cmbHoras.Items.Add("17:50-18:40")
        '    cmbHoras.Items.Add("18:40-19:30")
        'End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If txtCp.Text = "" Then
            MsgBox("Debes Escribir un Codigo Postal", vbCritical)
            Exit Sub
        End If
        Dim modeloD As New modelos.modeloDireccion
        modeloD = obtenerDireccion(txtCp.Text)
        cmbEstado.Text = modeloD.nombreEstado
        cmbMunicipio.Text = modeloD.nombreMunicipio
        cmbMunicipioId.Text = modeloD.idLocalidad
        cmbEstadoId.Text = modeloD.idEstado
        Dim colonia As String = ""
        colonia = UCase(InputBox("Introduce la Colonia Nueva", "Agregar Colonia"))
        If Len(colonia) <= 0 Then
            MsgBox("Debes Escribir una Colonia", vbCritical)
            Exit Sub
        End If
        agregarColonia(modeloD.idCP, colonia)
        llenarColonias(modeloD.idCP)
        cmbColonia.Focus()
    End Sub
    Private Sub agregarColonia(ByVal id_codigo_postal As Integer, ByVal nombre As String)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into colonia(nombre,id_codigo_postal)" & _
                         "values (@nombre,@id_codigo_postal)"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@nombre", nombre)
                .Parameters.AddWithValue("@id_codigo_postal", id_codigo_postal)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
End Class