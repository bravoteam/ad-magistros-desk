Imports datosCompartidos.Datos
Imports datosCompartidos.funciones
Imports System.Data.SqlClient

Public Class materiasFrm
    Private Sub cargarMaterias()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from materias order by id_materia"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                Dim M As New modelos.modeloAuxiliar
                M.nivel = obtenerNivel(variables.SQLdr("id_nivel"))
                Grid.Rows.Add(variables.SQLdr("id_materia"),
                                          variables.SQLdr("materia"),
                                          variables.SQLdr("horas"),
                                          variables.SQLdr("agrupacion"),
                                          variables.SQLdr("id_nivel"),
                                          M.nivel,
                                          variables.SQLdr("id_grado"))
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub semestreCombo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNivel.DropDown
        cmbNivel.Items.Clear()
        cmbNivelId.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from niveles order by descripcion"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbNivel.Items.Add(variables.SQLdr("descripcion").ToString)
                cmbNivelId.Items.Add(variables.SQLdr("idNivel").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub semestreCombo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNivel.TextChanged
        If cmbNivel.SelectedIndex >= 0 Then
            cmbNivelId.Text = cmbNivelId.Items.Item(cmbNivel.SelectedIndex)
        End If
    End Sub

    Private Sub salirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirCmd.Click
        Me.Close()
        menuPrincipalFrm.Show()
    End Sub

    Private Sub nuevoCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevoCmd.Click
        limpiar_campos(GroupBox1)
        txtHoras.Clear()
        txtGrado.Clear()
        txtnombre.Focus()
    End Sub

    Private Sub guardarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarCmd.Click
        Dim _modeloMaterias As New modelos.modeloMateria
        _modeloMaterias.id_materia = Val(txtidMateria.Text)
        _modeloMaterias.id_grado = Val(txtGrado.Text)
        _modeloMaterias.id_nivel = Val(cmbNivelId.Text)
        _modeloMaterias.materia = txtnombre.Text
        _modeloMaterias.horas = Val(txtHoras.Text)
        _modeloMaterias.agrupacion = txtAgrupacion.Text

        If funcionesLocales.validarReceptor(GroupBox1) = True Then
            If _modeloMaterias.id_materia > 0 Then
                funcionesLocales.actualizarMaterias(_modeloMaterias)
            Else
                funcionesLocales.guardarMaterias(_modeloMaterias)
                Dim _m As New modelos.modeloMateria
                _m = funcionesLocales.traerUltimaMateria()
                txtnombre.Text = _m.materia
                cmbNivel.Text = obtenerNivel(_m.id_nivel)
                cmbNivelId.Text = _m.id_nivel
                txtAgrupacion.Text = _m.agrupacion
                txtGrado.Text = _m.id_grado
                txtHoras.Text = _m.horas
                txtidMateria.Text = _m.id_materia
            End If
        End If
        cargarMaterias()
    End Sub

    Private Sub materiasFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarMaterias()
    End Sub
    Private Function buscarCarrera(ByVal valor As String) As String
        Dim retorno As String = ""
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from licenciaturas WHERE idlicenciatura=" & Val(valor) & " "
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                retorno = variables.SQLdr("NOMBRE").ToString
            End While
            variables.conexion.cerrarConexion()
            Return retorno
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Private Function buscarEspecialidad(ByVal valor As String) As String
        Dim retorno As String = ""
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from especialidades WHERE IDESPECIALIDAD=" & Val(valor) & " "
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                retorno = variables.SQLdr("DESCRIPCION").ToString
            End While
            variables.conexion.cerrarConexion()
            Return retorno
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Private Function buscarSemestre(ByVal valor As String) As String
        Dim retorno As String = ""
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from semestres WHERE IDSEMESTRE=" & Val(valor) & " "
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                retorno = variables.SQLdr("NUMERO").ToString
            End While
            variables.conexion.cerrarConexion()
            Return retorno
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Private Function buscarMaestro(ByVal valor As String) As String
        Dim retorno As String = ""
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from maestro WHERE IDMAESTRO=" & Val(valor) & " "
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                retorno = variables.SQLdr("NOMBRE").ToString & " " & variables.SQLdr("APELLIDO_PATERNO").ToString & " " & variables.SQLdr("APELLIDO_MATERNO").ToString
            End While
            variables.conexion.cerrarConexion()
            Return retorno
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function

    Private Sub eliminarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarCmd.Click
        Dim _modeloCampus As New modelos.modeloMateria
        _modeloCampus.id_materia = Val(txtidMateria.Text)
        _modeloCampus.horas = txtHoras.Text
        _modeloCampus.id_grado = Val(txtGrado.Text)
        _modeloCampus.id_nivel = Val(cmbNivelId.Text)
        Dim seguro = MsgBox("¿Estas Seguro Que Deseas Eliminar El Registro?", vbYesNo)
        If seguro = vbYes Then
            funcionesLocales.eliminarMaterias(_modeloCampus)
            limpiar_campos(GroupBox1)
            cargarMaterias()
        End If
    End Sub


    Private Sub Grid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellClick
        txtidMateria.Text = Grid.Item("idmateria", Grid.CurrentRow.Index).Value
        txtnombre.Text = Grid.Item("materia", Grid.CurrentRow.Index).Value.ToString
        txtHoras.Text = Grid.Item("horas", Grid.CurrentRow.Index).Value.ToString
        txtAgrupacion.Text = Grid.Item("agrupacion", Grid.CurrentRow.Index).Value.ToString
        txtGrado.Text = Grid.Item("grado", Grid.CurrentRow.Index).Value.ToString
        cmbNivel.Text = Grid.Item("nivel", Grid.CurrentRow.Index).Value.ToString
        cmbNivelId.Text = Grid.Item("idnivel", Grid.CurrentRow.Index).Value.ToString
    End Sub
End Class