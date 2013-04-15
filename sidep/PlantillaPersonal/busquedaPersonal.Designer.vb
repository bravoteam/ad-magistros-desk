<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class busquedaPersonal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.plantillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.plantillas = New sidep.plantillas()
        Me.horarioCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.estadisticas_CCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.plantillaTableAdapter = New sidep.plantillasTableAdapters.plantillaTableAdapter()
        Me.estadisticas_CCTTableAdapter = New sidep.plantillasTableAdapters.estadisticas_CCTTableAdapter()
        Me.horarioCTTableAdapter = New sidep.plantillasTableAdapters.horarioCTTableAdapter()
        Me.opNombre = New System.Windows.Forms.RadioButton()
        Me.btnBuscarCT = New System.Windows.Forms.Button()
        Me.txtParametroBusqueda = New System.Windows.Forms.TextBox()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.panelPersonal = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.gridPersonal = New System.Windows.Forms.DataGridView()
        Me.IdPersonal1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroControl1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paterno1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materno1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEXT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLONIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPlantilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroControl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUESTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUNCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRADO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRUPO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.plantillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plantillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horarioCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadisticas_CCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPersonal.SuspendLayout()
        CType(Me.gridPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'plantillaBindingSource
        '
        Me.plantillaBindingSource.DataMember = "plantilla"
        Me.plantillaBindingSource.DataSource = Me.plantillas
        '
        'plantillas
        '
        Me.plantillas.DataSetName = "plantillas"
        Me.plantillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'horarioCTBindingSource
        '
        Me.horarioCTBindingSource.DataMember = "horarioCT"
        Me.horarioCTBindingSource.DataSource = Me.plantillas
        '
        'estadisticas_CCTBindingSource
        '
        Me.estadisticas_CCTBindingSource.DataMember = "estadisticas_CCT"
        Me.estadisticas_CCTBindingSource.DataSource = Me.plantillas
        '
        'plantillaTableAdapter
        '
        Me.plantillaTableAdapter.ClearBeforeFill = True
        '
        'estadisticas_CCTTableAdapter
        '
        Me.estadisticas_CCTTableAdapter.ClearBeforeFill = True
        '
        'horarioCTTableAdapter
        '
        Me.horarioCTTableAdapter.ClearBeforeFill = True
        '
        'opNombre
        '
        Me.opNombre.AutoSize = True
        Me.opNombre.Checked = True
        Me.opNombre.Location = New System.Drawing.Point(11, 11)
        Me.opNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.opNombre.Name = "opNombre"
        Me.opNombre.Size = New System.Drawing.Size(62, 17)
        Me.opNombre.TabIndex = 20
        Me.opNombre.TabStop = True
        Me.opNombre.Text = "Nombre"
        Me.opNombre.UseVisualStyleBackColor = True
        '
        'btnBuscarCT
        '
        Me.btnBuscarCT.BackColor = System.Drawing.Color.White
        Me.btnBuscarCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCT.Image = Global.sidep.My.Resources.Resources._001_37
        Me.btnBuscarCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCT.Location = New System.Drawing.Point(478, 33)
        Me.btnBuscarCT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarCT.Name = "btnBuscarCT"
        Me.btnBuscarCT.Size = New System.Drawing.Size(86, 28)
        Me.btnBuscarCT.TabIndex = 1
        Me.btnBuscarCT.Text = "Buscar"
        Me.btnBuscarCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarCT.UseVisualStyleBackColor = False
        '
        'txtParametroBusqueda
        '
        Me.txtParametroBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametroBusqueda.Location = New System.Drawing.Point(11, 32)
        Me.txtParametroBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.txtParametroBusqueda.Name = "txtParametroBusqueda"
        Me.txtParametroBusqueda.Size = New System.Drawing.Size(463, 28)
        Me.txtParametroBusqueda.TabIndex = 0
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPlantilla, Me.NumeroControl, Me.CCT, Me.CT, Me.Nombre, Me.Paterno, Me.Materno, Me.PUESTO, Me.FUNCION, Me.HG, Me.HD, Me.HA, Me.idPersonal, Me.GRADO1, Me.GRUPO1})
        Me.Grid.Location = New System.Drawing.Point(11, 96)
        Me.Grid.Margin = New System.Windows.Forms.Padding(2)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(1226, 367)
        Me.Grid.TabIndex = 22
        '
        'panelPersonal
        '
        Me.panelPersonal.Controls.Add(Me.Label1)
        Me.panelPersonal.Controls.Add(Me.cmdCerrar)
        Me.panelPersonal.Controls.Add(Me.gridPersonal)
        Me.panelPersonal.Location = New System.Drawing.Point(11, 84)
        Me.panelPersonal.Name = "panelPersonal"
        Me.panelPersonal.Size = New System.Drawing.Size(968, 230)
        Me.panelPersonal.TabIndex = 23
        Me.panelPersonal.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(4, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Doble Clic o Enter para Seleccionar Personal"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Image = Global.sidep.My.Resources.Resources.salir
        Me.cmdCerrar.Location = New System.Drawing.Point(939, 1)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(28, 29)
        Me.cmdCerrar.TabIndex = 2
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'gridPersonal
        '
        Me.gridPersonal.AllowUserToAddRows = False
        Me.gridPersonal.AllowUserToDeleteRows = False
        Me.gridPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPersonal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPersonal1, Me.NumeroControl1, Me.nombre1, Me.paterno1, Me.materno1, Me.CALLE, Me.NUMEXT, Me.COLONIA})
        Me.gridPersonal.Location = New System.Drawing.Point(0, 30)
        Me.gridPersonal.Margin = New System.Windows.Forms.Padding(2)
        Me.gridPersonal.MultiSelect = False
        Me.gridPersonal.Name = "gridPersonal"
        Me.gridPersonal.ReadOnly = True
        Me.gridPersonal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gridPersonal.RowTemplate.Height = 24
        Me.gridPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridPersonal.Size = New System.Drawing.Size(961, 161)
        Me.gridPersonal.TabIndex = 1
        '
        'IdPersonal1
        '
        Me.IdPersonal1.HeaderText = "IdPersonal"
        Me.IdPersonal1.Name = "IdPersonal1"
        Me.IdPersonal1.ReadOnly = True
        Me.IdPersonal1.Visible = False
        Me.IdPersonal1.Width = 82
        '
        'NumeroControl1
        '
        Me.NumeroControl1.HeaderText = "NO. CONTROL"
        Me.NumeroControl1.Name = "NumeroControl1"
        Me.NumeroControl1.ReadOnly = True
        Me.NumeroControl1.Width = 97
        '
        'nombre1
        '
        Me.nombre1.HeaderText = "NOMBRE"
        Me.nombre1.Name = "nombre1"
        Me.nombre1.ReadOnly = True
        Me.nombre1.Width = 79
        '
        'paterno1
        '
        Me.paterno1.HeaderText = "APELLIDO PATERNO"
        Me.paterno1.Name = "paterno1"
        Me.paterno1.ReadOnly = True
        Me.paterno1.Width = 127
        '
        'materno1
        '
        Me.materno1.HeaderText = "APELLIDO MATERNO"
        Me.materno1.Name = "materno1"
        Me.materno1.ReadOnly = True
        Me.materno1.Width = 129
        '
        'CALLE
        '
        Me.CALLE.HeaderText = "CALLE"
        Me.CALLE.Name = "CALLE"
        Me.CALLE.ReadOnly = True
        Me.CALLE.Width = 65
        '
        'NUMEXT
        '
        Me.NUMEXT.HeaderText = "NUMEXT"
        Me.NUMEXT.Name = "NUMEXT"
        Me.NUMEXT.ReadOnly = True
        Me.NUMEXT.Width = 78
        '
        'COLONIA
        '
        Me.COLONIA.HeaderText = "COLONIA"
        Me.COLONIA.Name = "COLONIA"
        Me.COLONIA.ReadOnly = True
        Me.COLONIA.Width = 79
        '
        'IdPlantilla
        '
        Me.IdPlantilla.HeaderText = "IdPlantilla"
        Me.IdPlantilla.Name = "IdPlantilla"
        Me.IdPlantilla.ReadOnly = True
        Me.IdPlantilla.Visible = False
        Me.IdPlantilla.Width = 77
        '
        'NumeroControl
        '
        Me.NumeroControl.HeaderText = "NO. CONTROL"
        Me.NumeroControl.Name = "NumeroControl"
        Me.NumeroControl.ReadOnly = True
        Me.NumeroControl.Width = 97
        '
        'CCT
        '
        Me.CCT.HeaderText = "CCT"
        Me.CCT.Name = "CCT"
        Me.CCT.ReadOnly = True
        Me.CCT.Width = 53
        '
        'CT
        '
        Me.CT.FillWeight = 300.0!
        Me.CT.HeaderText = "CT"
        Me.CT.Name = "CT"
        Me.CT.ReadOnly = True
        Me.CT.Width = 46
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "NOMBRE"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 79
        '
        'Paterno
        '
        Me.Paterno.HeaderText = "APELLIDO PATERNO"
        Me.Paterno.Name = "Paterno"
        Me.Paterno.ReadOnly = True
        Me.Paterno.Width = 127
        '
        'Materno
        '
        Me.Materno.HeaderText = "APELLIDO MATERNO"
        Me.Materno.Name = "Materno"
        Me.Materno.ReadOnly = True
        Me.Materno.Width = 129
        '
        'PUESTO
        '
        Me.PUESTO.HeaderText = "PUESTO"
        Me.PUESTO.Name = "PUESTO"
        Me.PUESTO.ReadOnly = True
        Me.PUESTO.Width = 76
        '
        'FUNCION
        '
        Me.FUNCION.HeaderText = "FUNCION"
        Me.FUNCION.Name = "FUNCION"
        Me.FUNCION.ReadOnly = True
        Me.FUNCION.Width = 80
        '
        'HG
        '
        Me.HG.HeaderText = "HG"
        Me.HG.Name = "HG"
        Me.HG.ReadOnly = True
        Me.HG.Width = 48
        '
        'HD
        '
        Me.HD.HeaderText = "HD"
        Me.HD.Name = "HD"
        Me.HD.ReadOnly = True
        Me.HD.Width = 48
        '
        'HA
        '
        Me.HA.HeaderText = "HA"
        Me.HA.Name = "HA"
        Me.HA.ReadOnly = True
        Me.HA.Width = 47
        '
        'idPersonal
        '
        Me.idPersonal.HeaderText = "idPersonal"
        Me.idPersonal.Name = "idPersonal"
        Me.idPersonal.ReadOnly = True
        Me.idPersonal.Visible = False
        Me.idPersonal.Width = 81
        '
        'GRADO1
        '
        Me.GRADO1.HeaderText = "GRADO"
        Me.GRADO1.Name = "GRADO1"
        Me.GRADO1.ReadOnly = True
        Me.GRADO1.Width = 71
        '
        'GRUPO1
        '
        Me.GRUPO1.HeaderText = "GRUPO"
        Me.GRUPO1.Name = "GRUPO1"
        Me.GRUPO1.ReadOnly = True
        Me.GRUPO1.Width = 71
        '
        'busquedaPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1244, 482)
        Me.Controls.Add(Me.panelPersonal)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.opNombre)
        Me.Controls.Add(Me.btnBuscarCT)
        Me.Controls.Add(Me.txtParametroBusqueda)
        Me.Name = "busquedaPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Plantillas de Personal - Ubicacion"
        CType(Me.plantillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plantillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horarioCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadisticas_CCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPersonal.ResumeLayout(False)
        Me.panelPersonal.PerformLayout()
        CType(Me.gridPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents plantillaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents plantillas As sidep.plantillas
    Friend WithEvents plantillaTableAdapter As sidep.plantillasTableAdapters.plantillaTableAdapter
    Friend WithEvents estadisticas_CCTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents estadisticas_CCTTableAdapter As sidep.plantillasTableAdapters.estadisticas_CCTTableAdapter
    Friend WithEvents horarioCTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents horarioCTTableAdapter As sidep.plantillasTableAdapters.horarioCTTableAdapter
    Friend WithEvents opNombre As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscarCT As System.Windows.Forms.Button
    Friend WithEvents txtParametroBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents panelPersonal As System.Windows.Forms.Panel
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents gridPersonal As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdPersonal1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroControl1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paterno1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents materno1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMEXT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLONIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPlantilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroControl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Materno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUESTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUNCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPersonal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GRADO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GRUPO1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
