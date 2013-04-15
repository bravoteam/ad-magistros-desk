Imports System.Data.SqlClient

Public Class buscarDireccion

    Private Sub obtenerCpCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles obtenerCpCmd.Click
        addPersonal.txtCp.Text = txtCp.Text
        addPersonal.cmbColonia.Text = cmbColonia.Text
        addPersonal.cmbColoniaId.Text = cmbColoniaId.Text
        addPersonal.cmbEstado.Text = cmbEstado.Text
        addPersonal.cmbEstadoId.Text = cmbEstadoId.Text
        addPersonal.cmbMunicipio.Text = cmbMunicipio.Text
        addPersonal.cmbMunicipioId.Text = cmbMunicipioId.Text
        Me.Hide()
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

    Private Sub cmbEstado_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.DropDown
        cmbEstado.Items.Clear()
        cmbEstadoId.Items.Clear()
        cmbMunicipio.Items.Clear()
        cmbMunicipioId.Items.Clear()
        cmbColonia.Items.Clear()
        cmbColoniaId.Items.Clear()
        txtCp.Text = ""
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from estados order by NOMBRE"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbEstado.Items.Add(variables.SQLdr("NOMBRE").ToString)
                cmbEstadoId.Items.Add(variables.SQLdr("Id"))
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub cmbEstado_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedValueChanged
        cmbEstadoId.SelectedIndex = cmbEstado.SelectedIndex
    End Sub

    Private Sub cmbMunicipio_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMunicipio.DropDown
        If cmbEstadoId.Text <> "" And cmbEstado.Text <> "" Then
            cmbMunicipio.Items.Clear()
            cmbMunicipioId.Items.Clear()
            cmbColonia.Items.Clear()
            cmbColoniaId.Items.Clear()
            txtCp.Text = ""
            Try
                variables.conexion.abrirConexion()
                variables.sql = "select * from municipio where ID_ESTADO = " & cmbEstadoId.Text & " order by NOMBRE"
                Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
                variables.SQLdr = cmd.ExecuteReader()
                While (variables.SQLdr.Read())
                    cmbMunicipio.Items.Add(variables.SQLdr("NOMBRE").ToString)
                    cmbMunicipioId.Items.Add(variables.SQLdr("ID_MUNICIPIO"))
                End While
                variables.conexion.cerrarConexion()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                variables.conexion.cerrarConexion()
            End Try
        End If
    End Sub

    Private Sub cmbMunicipio_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMunicipio.SelectedValueChanged
        cmbMunicipioId.SelectedIndex = cmbMunicipio.SelectedIndex
    End Sub

    Private Sub txtCP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCp.KeyPress
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

    Private Sub cmbColonia_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbColonia.SelectedValueChanged
        cmbColoniaId.SelectedIndex = cmbColonia.SelectedIndex
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select id_cp from codigo_postal CP " & _
                            "inner join colonia C on c.id_codigo_postal=CP.id_codigo_postal " & _
                            "where C.id_colonia=" & Val(cmbColoniaId.Text) & ""
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                txtCp.Text = variables.SQLdr("id_cp").ToString
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try

    End Sub

    Private Sub cmbColonia_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbColonia.DropDown
        txtCp.Text = ""
        If txtCp.Text <> "" Then
            Dim modeloD As New modelos.modeloDireccion
            modeloD = obtenerDireccion(txtCp.Text)
            llenarColonias(modeloD.idCP)
        Else
            If cmbMunicipio.Text <> "" And cmbMunicipioId.Text <> "" Then
                cmbColonia.Items.Clear()
                cmbColoniaId.Items.Clear()
                Try
                    variables.conexion.abrirConexion()
                    variables.sql = "select * from colonia CO " & _
                                    "inner join codigo_postal CP on CP.id_codigo_postal=CO.id_codigo_postal " & _
                                    "where CP.id_municipio=" & Val(cmbMunicipioId.Text) & " order by CO.nombre"
                    Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
                    variables.SQLdr = cmd.ExecuteReader()
                    While (variables.SQLdr.Read())
                        cmbColonia.Items.Add(variables.SQLdr("NOMBRE").ToString)
                        cmbColoniaId.Items.Add(variables.SQLdr("ID_COLONIA"))
                    End While
                    variables.conexion.cerrarConexion()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    variables.conexion.cerrarConexion()
                End Try
            End If

        End If
    End Sub
End Class