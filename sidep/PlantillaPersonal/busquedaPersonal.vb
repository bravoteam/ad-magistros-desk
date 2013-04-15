Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports sidep.PlantillaPersonal.PlantillaPersonal
Imports datosCompartidos.Datos

Public Class busquedaPersonal

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

        gridPersonal.Rows.Clear()
        Dim MCP As New modelos.modeloCP
        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            For Each f As DataRow In ds.Tables(0).Rows
                gridPersonal.Rows.Add()
                gridPersonal("IdPersonal1", i).Value = f("id_personal").ToString.ToUpper
                gridPersonal("PATERNO1", i).Value = f("apellido_paterno").ToString.ToUpper
                gridPersonal("MATERNO1", i).Value = f("apellido_materno").ToString.ToUpper
                gridPersonal("NOMBRE1", i).Value = f("nombre").ToString.ToUpper
                gridPersonal("NumeroControl1", i).Value = f("ficha").ToString.ToUpper
                gridPersonal("CALLE", i).Value = f("Domicilio").ToString.ToUpper
                gridPersonal("NUMEXT", i).Value = f("numExt").ToString.ToUpper
                MCP = obtenerColonia(f("Id_Colonia"))
                gridPersonal("COLONIA", i).Value = MCP.nombreColonia.ToString.ToUpper
                i += 1
            Next
        End If

        Grid.Focus()

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim deviceInfo As String
        'Dim lr As New Microsoft.Reporting.WinForms.LocalReport
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim bytes As Byte()

        deviceInfo = "<DeviceInfo>" +
        "<OutputFormat>PDF</OutputFormat>" +
        "  <PageWidth>35.56cm</PageWidth>" +
        "  <PageHeight>21.59cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try


            'bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            'ReportViewer1.LocalReport.ReportPath = "plantilla.rdl"

            'Dim fs As New FileStream("C:\PLANTILLA" & frmPlantillaPersonal.txtNombreCT.Text & ".pdf", FileMode.Create)
            'fs.Write(bytes, 0, bytes.Length)
            'fs.Close()
            'Process.Start("C:\PLANTILLA" & frmPlantillaPersonal.txtNombreCT.Text & ".pdf")
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub


    Private Sub cmdCerrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrar.Click
        panelPersonal.Visible = False
        gridPersonal.ClearSelection()
        txtParametroBusqueda.Focus()
    End Sub

    Private Sub txtParametroBusqueda_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtParametroBusqueda.KeyPress
        If e.KeyChar = Chr(13) And txtParametroBusqueda.TextLength > 0 Then
            BuscarPersonal(txtParametroBusqueda.Text)
            panelPersonal.Visible = True
            gridPersonal.Focus()
        End If
    End Sub

    Private Sub gridPersonal_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridPersonal.CellDoubleClick
        Dim b As New BaseDatos
        Dim ds As DataSet
        Dim sql As String = ""
        Dim i As Integer
        If gridPersonal.RowCount > 0 Then
            Dim _modelo As New modelos.modeloPersonal
            _modelo.Id_Personal = gridPersonal.Rows(e.RowIndex).Cells("IdPersonal1").Value


            sql = "select " & _
                "PP.idPlantilla,pp.idcct, pp.idpersonal, p.Apellido_Materno, p.Apellido_Paterno, p.Nombre, " & _
                "p.ficha,p.domicilio,p.numExt,isnull(Pu.descripcion, '') as puesto, isnull(F.Descripcion, '') as funcion,pp.HG," & _
                "pp.HD,pp.HA,pp.grados as grados,pp.grupos as grupos,ct.cct,ct.nombre as CT " & _
                "from Plantillas pp " & _
                "left join puestos Pu on Pu.idPuesto=pp.idPuesto " & _
                "left join funciones F on F.idFuncion=pp.idFuncion " & _
                "inner join Personal p on p.Id_Personal = pp.idpersonal " & _
                "inner join CicloEscolar c on c.IdCicloEscolar = pp.idcicloescolar " & _
                "inner join CT ct on ct.IdCT = pp.idcct " & _
                "and c.Activo = '1' " & _
                "and pp.idpersonal = '" & _modelo.Id_Personal & "' " & _
                "order by pp.idplantilla;"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            Grid.Rows.Clear()

            If ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("El personal no aparece en plantillas.", _
                                "Plantilla de Personal", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Information)
                Exit Sub
            End If

            If ds.Tables(0).Rows.Count > 0 Then
                i = 0
                For Each f As DataRow In ds.Tables(0).Rows
                    Grid.Rows.Add()
                    Grid("idPlantilla", i).Value = f("idPlantilla").ToString.ToUpper
                    Grid("CCT", i).Value = f("cct").ToString.ToUpper
                    Grid("CT", i).Value = f("CT").ToString.ToUpper
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

        End If
        panelPersonal.Visible = False
    End Sub

    Private Sub gridPersonal_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gridPersonal.KeyDown
        Dim b As New BaseDatos
        Dim ds As DataSet
        Dim sql As String = ""
        Dim i As Integer
        If gridPersonal.RowCount > 0 Then
            If e.KeyCode = Keys.Enter Then
                Dim _modelo As New modelos.modeloPersonal
                _modelo.Id_Personal = gridPersonal.Item("IdPersonal1", gridPersonal.CurrentRow.Index).Value


                sql = "select " & _
                    "PP.idPlantilla,pp.idcct, pp.idpersonal, p.Apellido_Materno, p.Apellido_Paterno, p.Nombre, " & _
                    "p.ficha,p.domicilio,p.numExt,isnull(Pu.descripcion, '') as puesto, isnull(F.Descripcion, '') as funcion,pp.HG," & _
                    "pp.HD,pp.HA,pp.grados as grados,pp.grupos as grupos,ct.cct,ct.nombre as CT " & _
                    "from Plantillas pp " & _
                    "left join puestos Pu on Pu.idPuesto=pp.idPuesto " & _
                    "left join funciones F on F.idFuncion=pp.idFuncion " & _
                    "inner join Personal p on p.Id_Personal = pp.idpersonal " & _
                    "inner join CicloEscolar c on c.IdCicloEscolar = pp.idcicloescolar " & _
                    "inner join CT ct on ct.IdCT = pp.idcct " & _
                    "and c.Activo = '1' " & _
                    "and pp.idpersonal = '" & _modelo.Id_Personal & "' " & _
                    "order by pp.idplantilla;"

                b.abrirConexion()
                ds = b.getDataSet(sql)
                b.cerrarConexion()

                Grid.Rows.Clear()

                If ds.Tables(0).Rows.Count = 0 Then
                    MessageBox.Show("El personal no aparece en plantillas.", _
                                    "Plantilla de Personal", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Information)
                    Exit Sub
                End If

                If ds.Tables(0).Rows.Count > 0 Then
                    i = 0
                    For Each f As DataRow In ds.Tables(0).Rows
                        Grid.Rows.Add()
                        Grid("idPlantilla", i).Value = f("idPlantilla").ToString.ToUpper
                        Grid("CCT", i).Value = f("cct").ToString.ToUpper
                        Grid("CT", i).Value = f("CT").ToString.ToUpper
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
                panelPersonal.Visible = False
            End If

        End If

    End Sub
End Class