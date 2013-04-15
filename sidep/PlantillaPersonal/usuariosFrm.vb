Imports datosCompartidos.Datos
Imports System.Data.SqlClient

Public Class usuariosFrm

    Private Sub buscarCmd_Click(sender As System.Object, e As System.EventArgs) Handles buscarCmd.Click

    End Sub


    Private Sub cmdAddCt_Click(sender As System.Object, e As System.EventArgs) Handles cmdAddCt.Click
        agregarCtFrm.Show()
        agregarCtFrm.txtFiltra.Focus()
    End Sub

    Private Sub salirCmd_Click(sender As System.Object, e As System.EventArgs) Handles salirCmd.Click
        Close()
        menuPrincipalFrm.Show()
    End Sub

    Private Sub nuevoCmd_Click(sender As System.Object, e As System.EventArgs) Handles nuevoCmd.Click
        txtidUsuario.Text = ""
        txtUsuario.Text = ""
        txtPassword.Text = ""
        Grid.Rows.Clear()
    End Sub

    Private Sub guardarCmd_Click(sender As System.Object, e As System.EventArgs) Handles guardarCmd.Click
        Dim M As New modelos.modeloUsuario
        Dim MP As New modelos.modeloPerfilesCt
        M.usuario = txtUsuario.Text
        M.password = txtPassword.Text
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into usuarios(usuario,password)" & _
                         "values (@usuario,@password) SELECT SCOPE_IDENTITY()"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@usuario", M.usuario)
                .Parameters.AddWithValue("@password", M.password)
            End With
            Dim idRegistro As Integer = 0
            idRegistro = Convert.ToInt32(cmd.ExecuteScalar())
            'cmd.ExecuteNonQuery()
            variables.conexion.cerrarConexion()

            variables.conexion.abrirConexion()
            For i = 0 To Grid.RowCount - 1
                sql = "INSERT INTO perfilesCt(idCCt,idUsuario)VALUES(" & Grid.Item(0, i).Value & "," & idRegistro & ") "
                cmd = New SqlCommand(sql, variables.conexion.Conexion)
                cmd.ExecuteNonQuery()
            Next
            variables.conexion.cerrarConexion()

            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Me.Grid.Rows.Remove(Me.Grid.CurrentRow)
        Catch
        End Try
    End Sub
End Class