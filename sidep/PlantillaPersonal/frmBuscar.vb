Imports datosCompartidos.Datos

Public Class frmBuscar
    Private BD As New BaseDatos
    Public Sub limpiarCampos()
        Me.Controls.Clear()
        InitializeComponent()
    End Sub
    Private Sub filtrarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Grid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellDoubleClick, Grid.CellContentClick
        If Grid.RowCount > 0 Then
            If variables.banderaAccion = "buscarPersonalAdd" Then
                Dim _modelo As New modelos.modeloPersonal
                Me.Hide()
                _modelo.Id_Personal = Grid.Rows(e.RowIndex).Cells("Id_Personal").Value
                _modelo.Apellido_Paterno = Grid.Rows(e.RowIndex).Cells("Apellido_Paterno").Value.ToString
                _modelo.Apellido_Materno = Grid.Rows(e.RowIndex).Cells("Apellido_Materno").Value.ToString
                _modelo.Nombre = Grid.Rows(e.RowIndex).Cells("Nombre").Value.ToString
                _modelo.Celular = Grid.Rows(e.RowIndex).Cells("Celular").Value.ToString
                _modelo.CURP = Grid.Rows(e.RowIndex).Cells("CURP").Value.ToString
                _modelo.Domicilio = Grid.Rows(e.RowIndex).Cells("Domicilio").Value.ToString
                _modelo.Ficha = Grid.Rows(e.RowIndex).Cells("Ficha").Value.ToString
                _modelo.Id_Colonia = Grid.Rows(e.RowIndex).Cells("Id_Colonia").Value
                _modelo.Id_estado = Grid.Rows(e.RowIndex).Cells("Id_estado").Value
                _modelo.Id_Localidad = Grid.Rows(e.RowIndex).Cells("Id_Localidad").Value
                _modelo.numExt = Grid.Rows(e.RowIndex).Cells("numExt").Value
                _modelo.numInt = Grid.Rows(e.RowIndex).Cells("numInt").Value
                _modelo.Telefono = Trim(Grid.Rows(e.RowIndex).Cells("Telefono").Value.ToString)
                _modelo.nivelMaximo = Grid.Rows(e.RowIndex).Cells("nivelMaximo").Value
                _modelo.preparacion = Grid.Rows(e.RowIndex).Cells("preparacion").Value
                variables.banderaAccion2 = "AGREGAR"
                variables.idPlantilla = 0

                addPersonal.cargarPersonal(_modelo)
                addPersonal.cctTxt.Text = variables.idCCT
                addPersonal.ShowDialog()
            End If
            If variables.banderaAccion = "personalS" Then
                Dim M As New modelos.modeloPersonal
                M = obtenerPersonal(Grid.Rows(e.RowIndex).Cells("Id_Personal").Value)
                addPersonal.Grid.Rows.Add(0, addPersonal.txtId.Text,
                                          Grid.Rows(e.RowIndex).Cells("Id_Personal").Value,
                                          M.Ficha,
                        M.Nombre + " " +
                        M.Apellido_Paterno + " " +
                        M.Apellido_Materno, " ")
                Me.Close()
            End If
        End If
    End Sub
    Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        If Grid.RowCount > 0 Then
            If e.KeyCode = Keys.Enter Then
                If variables.banderaAccion = "buscarPersonalAdd" Then
                    Dim _modelo As New modelos.modeloPersonal
                    Me.Hide()
                    _modelo.Id_Personal = Grid.Item("Id_Personal", Grid.CurrentRow.Index).Value
                    _modelo.Apellido_Paterno = Grid.Item("Apellido_Paterno", Grid.CurrentRow.Index).Value.ToString
                    _modelo.Apellido_Materno = Grid.Item("Apellido_Materno", Grid.CurrentRow.Index).Value.ToString
                    _modelo.Nombre = Grid.Item("Nombre", Grid.CurrentRow.Index).Value.ToString
                    _modelo.Celular = Grid.Item("Celular", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CURP = Grid.Item("CURP", Grid.CurrentRow.Index).Value.ToString
                    _modelo.Domicilio = Grid.Item("Domicilio", Grid.CurrentRow.Index).Value.ToString
                    _modelo.Ficha = Grid.Item("Ficha", Grid.CurrentRow.Index).Value.ToString.ToString
                    _modelo.Id_Colonia = Grid.Item("Id_Colonia", Grid.CurrentRow.Index).Value
                    _modelo.Id_estado = Grid.Item("Id_estado", Grid.CurrentRow.Index).Value
                    _modelo.Id_Localidad = Grid.Item("Id_Localidad", Grid.CurrentRow.Index).Value
                    _modelo.numExt = Grid.Item("numExt", Grid.CurrentRow.Index).Value.ToString
                    _modelo.numInt = Grid.Item("numInt", Grid.CurrentRow.Index).Value.ToString
                    _modelo.Telefono = Trim(Grid.Item("Telefono", Grid.CurrentRow.Index).Value.ToString)
                    _modelo.nivelMaximo = Grid.Item("nivelMaximo", Grid.CurrentRow.Index).Value.ToString
                    _modelo.preparacion = Grid.Item("preparacion", Grid.CurrentRow.Index).Value.ToString
                    variables.banderaAccion2 = "AGREGAR"
                    variables.idPlantilla = 0
                    addPersonal.cargarPersonal(_modelo)
                    addPersonal.cctTxt.Text = variables.idCCT
                    addPersonal.ShowDialog()
                End If
                If variables.banderaAccion = "personalS" Then
                    Dim M As New modelos.modeloPersonal
                    M = obtenerPersonal(Grid.Item("Id_Personal", Grid.CurrentRow.Index).Value)
                    addPersonal.Grid.Rows.Add(0, addPersonal.txtId.Text,
                                              Grid.Item("Id_Personal", Grid.CurrentRow.Index).Value,
                                              M.Ficha,
                                              M.Nombre + " " +
                                              M.Apellido_Paterno + " " +
                                              M.Apellido_Materno, " ")
                    Me.Close()
                End If
            End If
        End If
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            buscarXDescripcion(txtBuscar.Text)
            Grid.DataSource = variables.dt.Tables(0)
            Grid.Update()
            Grid.Focus()
        End If

    End Sub
    Private Sub btnBuscarCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCT.Click
        buscarXDescripcion(txtBuscar.Text)
        Grid.DataSource = variables.dt.Tables(0)
        Grid.Update()
        Grid.Focus()
    End Sub
    Private Sub txtParametroBusqueda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            buscarXDescripcion(txtBuscar.Text)
            Grid.DataSource = variables.dt.Tables(0)
            Grid.Update()
            Grid.Focus()
        End If
    End Sub
    Private Sub btnAgregarPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPersonal.Click
        Me.Hide()
        addPersonal.limpiarCampos()
        addPersonal.cctTxt.Text = variables.idCCT
        addPersonal.Show()
    End Sub
    Private Sub frmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'InitializeComponent()
    End Sub
End Class