Imports System.Data.SqlClient
Imports datosCompartidos.Datos

Public Class frmPlantillaPersonal

#Region " ********** MyCode ********** "

    Public Sub cargarEstadisticas(ByVal IdCT As Integer, ByVal idCiclo As Integer)

        Dim b As New BaseDatos
        Dim ds As DataSet
        Dim sql As String = ""
        Dim i As Integer

        sql = "select * from estadisticas_CCT where idCt=" & IdCT & " and idCicloEscolar= " & idCiclo & " order by idGrado"

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        GridEstadisticas.Rows.Clear()

        If ds.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            For Each f As DataRow In ds.Tables(0).Rows
                GridEstadisticas.Rows.Add()
                GridEstadisticas("idestadistica", i).Value = f("idEstadisticas").ToString.ToUpper
                GridEstadisticas("GRADO", i).Value = f("idGrado").ToString.ToUpper
                GridEstadisticas("GRUPO", i).Value = f("nGrupos").ToString.ToUpper
                GridEstadisticas("HOMBRES", i).Value = f("numHombres").ToString.ToUpper
                GridEstadisticas("MUJERES", i).Value = f("numMujeres").ToString.ToUpper

                i += 1
            Next
        End If

    End Sub

#End Region
    Public Sub cargarPersonal(ByVal IdCT As String, ByVal idCiclo As String)

        Dim b As New BaseDatos
        Dim ds As DataSet
        Dim sql As String = ""
        Dim i As Integer

        'sql = "select " & _
        '        "PP.idPlantilla,pp.idcct, pp.idpersonal, p.Apellido_Materno, p.Apellido_Paterno, p.Nombre, " & _
        '        "p.ficha,p.domicilio,p.numExt,isnull(Pu.descripcion, '') as puesto, isnull(F.Descripcion, '') as funcion,pp.HG,pp.HD,pp.HA,pp.grados as grados,pp.grupos as grupos " & _
        '        "from Plantillas pp " & _
        '        "left join puestos Pu on Pu.idPuesto=pp.idPuesto " & _
        '        "left join funciones F on F.idFuncion=pp.idFuncion " & _
        '        "inner join Personal p on p.Id_Personal = pp.idpersonal " & _
        '        "inner join CicloEscolar c on c.IdCicloEscolar = pp.idcicloescolar " & _
        '        "and c.Activo = '1' " & _
        '        "and pp.idcct = '" & IdCT & "' " & _
        '        "order by pp.idplantilla;"

        sql = "select " & _
                "PP.idPlantilla,pp.idcct, pp.idpersonal, p.Apellido_Materno, p.Apellido_Paterno, p.Nombre, " & _
                "p.ficha,p.domicilio,p.numExt,isnull(Pu.descripcion, '') as puesto, isnull(F.Descripcion, '') as funcion,pp.HG,pp.HD,pp.HA,pp.grados as grados,pp.grupos as grupos " & _
                "from Plantillas pp " & _
                "left join puestos Pu on Pu.idPuesto=pp.idPuesto " & _
                "left join funciones F on F.idFuncion=pp.idFuncion " & _
                "inner join Personal p on p.Id_Personal = pp.idpersonal " & _
                "where pp.idCicloEscolar='" & idCiclo & "' " & _
                "and pp.idcct = '" & IdCT & "' " & _
                "order by pp.idplantilla;"
        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Grid.Rows.Clear()

        If ds.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            For Each f As DataRow In ds.Tables(0).Rows
                Grid.Rows.Add()
                Grid("idPlantilla", i).Value = f("idPlantilla").ToString.ToUpper
                Grid("NumeroControl", i).Value = f("ficha").ToString.ToUpper
                Grid("Nombre", i).Value = f("nombre").ToString.ToUpper
                Grid("Paterno", i).Value = f("apellido_paterno").ToString.ToUpper
                Grid("Materno", i).Value = f("apellido_materno").ToString.ToUpper
                Grid("puesto", i).Value = f("puesto").ToString.ToUpper
                Grid("funcion", i).Value = f("funcion").ToString.ToUpper
                Grid("hg", i).Value = f("hg").ToString.ToUpper
                Grid("hd", i).Value = f("hd").ToString.ToUpper
                Grid("ha", i).Value = f("ha").ToString.ToUpper
                Grid("idPersonal", i).Value = f("idPersonal").ToString.ToUpper
                Grid("GRADO1", i).Value = f("grados").ToString.ToUpper
                Grid("GRUPO1", i).Value = f("grupos").ToString.ToUpper
                i += 1
            Next
        End If
        lblRegs.Text = "Total de Personal: " & Grid.Rows.Count
    End Sub

    Private Sub btnBuscarCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCT.Click
        frmBuscarCT.ShowDialog()
    End Sub

    Private Sub btnAgregarPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPersonal.Click
        'Dim f As New frmBuscar
        frmBuscar.limpiarCampos()
        frmBuscar.Text = "Busqueda X Personal"
        variables.banderaAccion = "buscarPersonalAdd"
        variables.banderaAccion2 = "AGREGAR"
        frmBuscar.Show()
        'frmBuscarPersonal.Show()
    End Sub

    Private Sub frmPlantillaPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tabs.Enabled = False
        ' frmBuscarCT.ShowDialog()
    End Sub

    Private Sub txtIdCT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdCT.TextChanged

        If txtIdCT.TextLength > 0 Then
            Tabs.Enabled = True
        End If

    End Sub

    Private Sub btnQuitarPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarPersonal.Click
        If Grid.RowCount > 0 Then
            Dim mensaje As String = MsgBox("Deseas Eliminar de la Plantilla a: " & Grid.CurrentRow.Cells("nombre").Value.ToString & " " & Grid.CurrentRow.Cells("paterno").Value.ToString & " " & Grid.CurrentRow.Cells("materno").Value.ToString, vbYesNo)
            If mensaje = vbYes Then
                If Not Grid.CurrentRow.IsNewRow Then
                    insertaEliminacion(Grid.CurrentRow.Cells("idPlantilla").Value, Grid.CurrentRow.Cells("idPersonal").Value, "CT: " & txtNombreCT.Text & " - FUNCION: " & _
                                       Grid.CurrentRow.Cells("funcion").Value, variables.idUsuario, variables.usuario, Grid.CurrentRow.Cells("nombre").Value & _
                                       " " & Grid.CurrentRow.Cells("paterno").Value & " " & Grid.CurrentRow.Cells("materno").Value)
                    insertaBitacora("ELIMINACION DE PLANTILLA", variables.usuario, variables.idUsuario, variables.idCCT, txtNombreCT.Text, Grid.CurrentRow.Cells("idPersonal").Value, _
                                    Grid.CurrentRow.Cells("nombre").Value & _
                                       " " & Grid.CurrentRow.Cells("paterno").Value & " " & Grid.CurrentRow.Cells("materno").Value, Grid.CurrentRow.Cells("idPlantilla").Value, _
                                       0, 0, "SE ELIMINÓ EL PERSONAL DEL CT")
                    eliminarPlantilla(Grid.CurrentRow.Cells("idPlantilla").Value)
                    Grid.Rows.Remove(Grid.CurrentRow)
                End If
            End If
        End If
    End Sub

    Private Sub cmbGrado_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrado.DropDown
        cmbGrado.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from grados order by descripcion"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbGrado.Items.Add(variables.SQLdr("descripcion").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub btnAgregarEsta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarEsta.Click
        If Val(cmbGrado.Text) < 0 Then
            MsgBox("Falta Elegir Grado", vbCritical)
            cmbGrado.Focus()
            Exit Sub
        End If
        If Val(nGruposTxt.Text) < 0 Then
            MsgBox("Falta Escribir Grupos", vbCritical)
            nGruposTxt.Focus()
            Exit Sub
        End If
        If Val(txtHombres.Text) < 0 Then
            MsgBox("Falta Escribir Numero de hombres", vbCritical)
            txtHombres.Focus()
            Exit Sub
        End If
        If Val(txtMujeres.Text) < 0 Then
            MsgBox("Falta Escribir Numero de mujeres", vbCritical)
            txtMujeres.Focus()
            Exit Sub
        End If
        Dim modelo As New modelos.modeloEstadistica
        modelo.idEstadisticas = variables.idEstadistica
        modelo.idCt = variables.idCCT
        modelo.idCicloEscolar = variables.idCicloEscolar
        modelo.idGrado = Val(cmbGrado.Text)
        modelo.nGrupos = Val(nGruposTxt.Text)
        modelo.numHombres = Val(txtHombres.Text)
        modelo.numMujeres = Val(txtMujeres.Text)
        If variables.idEstadistica > 0 Then
            actualizarEstadistica(modelo)
        Else
            guardarEstadistica(modelo)
        End If
        cargarEstadisticas(modelo.idCt, variables.idCicloEscolar)
        cmbGrado.Text = ""
        txtHombres.Text = ""
        txtMujeres.Text = ""
        nGruposTxt.Text = ""
        Panel1.Visible = False
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        modificarDatosPlantillas()
    End Sub
    Private Sub modificarDatosPlantillas()
        Dim _M As New modelos.modeloPersonal
        Dim _P As New modelos.modeloPlantilla
        If Grid.RowCount > 0 Then
            If Not Grid.CurrentRow.IsNewRow Then
                _M = traerPersonal(Grid.CurrentRow.Cells("IdPersonal").Value)
                variables.banderaAccion2 = "MODIFICACION"
                variables.idPlantilla = Grid.CurrentRow.Cells("idPlantilla").Value
                _P = traerPlantilla(variables.idPlantilla)
                addPersonal.limpiarCampos()
                addPersonal.cctTxt.Text = variables.idCCT
                addPersonal.cargarPersonal(_M)
                addPersonal.cargarPlantilla(_P)
                addPersonal.cargarSustituye(variables.idPlantilla)
                variables.IdHorario = 0

                addPersonal.ShowDialog()
            End If
        End If
    End Sub
    Private Sub btnQuitarEsta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarEsta.Click
        If GridEstadisticas.RowCount > 0 Then
            Dim mensaje As String = MsgBox("Deseas Eliminar la Estadistica?", vbYesNo)
            If mensaje = vbYes Then
                If Not GridEstadisticas.CurrentRow.IsNewRow Then
                    eliminarEstadistica(GridEstadisticas.CurrentRow.Cells("idEstadistica").Value)
                    GridEstadisticas.Rows.Remove(GridEstadisticas.CurrentRow)
                    cargarEstadisticas(variables.idCCT, variables.idCicloEscolar)
                End If
            End If
        End If
    End Sub

    Private Sub imprimirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprimirCmd.Click
        imprimirPlantillaFrm.Show()
    End Sub

    Private Sub Grid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        modificarDatosPlantillas()
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = True
        variables.idEstadistica = 0
        cmbGrado.Text = ""
        nGruposTxt.Text = ""
        txtHombres.Text = ""
        txtMujeres.Text = ""
        cmbGrado.Focus()
    End Sub

    Private Sub GridEstadisticas_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridEstadisticas.CellDoubleClick
        Panel1.Visible = True
        variables.idEstadistica = GridEstadisticas.Rows(e.RowIndex).Cells("idEstadistica").Value
        cmbGrado.Text = GridEstadisticas.Rows(e.RowIndex).Cells("grado").Value
        nGruposTxt.Text = GridEstadisticas.Rows(e.RowIndex).Cells("grupo").Value
        txtHombres.Text = GridEstadisticas.Rows(e.RowIndex).Cells("hombres").Value
        txtMujeres.Text = GridEstadisticas.Rows(e.RowIndex).Cells("mujeres").Value
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim forma As New ImpresionHorarioCT
        forma.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim forma As New ImpresionCT_Desgloce
        forma.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim forma As New ImpresionCargaHoraria
        forma.ShowDialog()
    End Sub
End Class
