<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlantillaPersonal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreCT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.IdPlantilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroControl = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtTurno = New System.Windows.Forms.TextBox()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.TabPersonal = New System.Windows.Forms.TabPage()
        Me.imprimirCmd = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.btnAgregarPersonal = New System.Windows.Forms.Button()
        Me.btnQuitarPersonal = New System.Windows.Forms.Button()
        Me.TabEstadisticas = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nGruposTxt = New System.Windows.Forms.TextBox()
        Me.txtMujeres = New System.Windows.Forms.TextBox()
        Me.btnAgregarEsta = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHombres = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbGrado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GridEstadisticas = New System.Windows.Forms.DataGridView()
        Me.idestadistica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOMBRES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MUJERES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarEsta = New System.Windows.Forms.Button()
        Me.txtCicloEscolar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIdCT = New System.Windows.Forms.TextBox()
        Me.btnBuscarCT = New System.Windows.Forms.Button()
        Me.lblRegs = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabs.SuspendLayout()
        Me.TabPersonal.SuspendLayout()
        Me.TabEstadisticas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridEstadisticas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CENTRO DE TRABAJO"
        '
        'txtNombreCT
        '
        Me.txtNombreCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCT.Location = New System.Drawing.Point(123, 28)
        Me.txtNombreCT.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreCT.Name = "txtNombreCT"
        Me.txtNombreCT.ReadOnly = True
        Me.txtNombreCT.Size = New System.Drawing.Size(347, 19)
        Me.txtNombreCT.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(471, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TURNO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(355, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LOCALIDAD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DOMICILIO"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(473, 102)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(116, 19)
        Me.txtTelefono.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(471, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "TELÉFONO"
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(10, 28)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(2)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(110, 19)
        Me.txtClave.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 13)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CLAVE"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(12, 102)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.Size = New System.Drawing.Size(458, 19)
        Me.txtDomicilio.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(123, 50)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "MUNICIPIO"
        '
        'txtCP
        '
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(12, 66)
        Me.txtCP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.ReadOnly = True
        Me.txtCP.Size = New System.Drawing.Size(110, 19)
        Me.txtCP.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 50)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "CÓDIGO POSTAL"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPlantilla, Me.NumeroControl, Me.Nombre, Me.Paterno, Me.Materno, Me.PUESTO, Me.FUNCION, Me.HG, Me.HD, Me.HA, Me.idPersonal, Me.GRADO1, Me.GRUPO1})
        Me.Grid.Location = New System.Drawing.Point(4, 35)
        Me.Grid.Margin = New System.Windows.Forms.Padding(2)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(1250, 459)
        Me.Grid.TabIndex = 21
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
        'txtMunicipio
        '
        Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipio.Location = New System.Drawing.Point(125, 66)
        Me.txtMunicipio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.ReadOnly = True
        Me.txtMunicipio.Size = New System.Drawing.Size(228, 19)
        Me.txtMunicipio.TabIndex = 25
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.Location = New System.Drawing.Point(357, 66)
        Me.txtLocalidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.ReadOnly = True
        Me.txtLocalidad.Size = New System.Drawing.Size(231, 19)
        Me.txtLocalidad.TabIndex = 26
        '
        'txtTurno
        '
        Me.txtTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurno.Location = New System.Drawing.Point(473, 28)
        Me.txtTurno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.ReadOnly = True
        Me.txtTurno.Size = New System.Drawing.Size(115, 19)
        Me.txtTurno.TabIndex = 27
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabPersonal)
        Me.Tabs.Controls.Add(Me.TabEstadisticas)
        Me.Tabs.Location = New System.Drawing.Point(11, 192)
        Me.Tabs.Margin = New System.Windows.Forms.Padding(2)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(1276, 547)
        Me.Tabs.TabIndex = 29
        '
        'TabPersonal
        '
        Me.TabPersonal.Controls.Add(Me.imprimirCmd)
        Me.TabPersonal.Controls.Add(Me.cmdModificar)
        Me.TabPersonal.Controls.Add(Me.lblRegs)
        Me.TabPersonal.Controls.Add(Me.Grid)
        Me.TabPersonal.Controls.Add(Me.btnAgregarPersonal)
        Me.TabPersonal.Controls.Add(Me.btnQuitarPersonal)
        Me.TabPersonal.Location = New System.Drawing.Point(4, 22)
        Me.TabPersonal.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPersonal.Name = "TabPersonal"
        Me.TabPersonal.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPersonal.Size = New System.Drawing.Size(1268, 521)
        Me.TabPersonal.TabIndex = 0
        Me.TabPersonal.Text = "Personal"
        Me.TabPersonal.UseVisualStyleBackColor = True
        '
        'imprimirCmd
        '
        Me.imprimirCmd.BackColor = System.Drawing.Color.White
        Me.imprimirCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprimirCmd.Image = Global.sidep.My.Resources.Resources._16__Print_
        Me.imprimirCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.imprimirCmd.Location = New System.Drawing.Point(578, 6)
        Me.imprimirCmd.Margin = New System.Windows.Forms.Padding(2)
        Me.imprimirCmd.Name = "imprimirCmd"
        Me.imprimirCmd.Size = New System.Drawing.Size(132, 25)
        Me.imprimirCmd.TabIndex = 26
        Me.imprimirCmd.Text = "Imprimir Plantilla"
        Me.imprimirCmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.imprimirCmd.UseVisualStyleBackColor = False
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.Color.White
        Me.cmdModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.Image = Global.sidep.My.Resources.Resources._16__Card_edit_
        Me.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdModificar.Location = New System.Drawing.Point(268, 6)
        Me.cmdModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(284, 25)
        Me.cmdModificar.TabIndex = 25
        Me.cmdModificar.Text = "Cambiar Datos del Personal Seleccionado"
        Me.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModificar.UseVisualStyleBackColor = False
        '
        'btnAgregarPersonal
        '
        Me.btnAgregarPersonal.BackColor = System.Drawing.Color.White
        Me.btnAgregarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPersonal.Image = Global.sidep.My.Resources.Resources.plus
        Me.btnAgregarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarPersonal.Location = New System.Drawing.Point(136, 6)
        Me.btnAgregarPersonal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarPersonal.Name = "btnAgregarPersonal"
        Me.btnAgregarPersonal.Size = New System.Drawing.Size(128, 25)
        Me.btnAgregarPersonal.TabIndex = 23
        Me.btnAgregarPersonal.Text = "Agregar Personal"
        Me.btnAgregarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarPersonal.UseVisualStyleBackColor = False
        '
        'btnQuitarPersonal
        '
        Me.btnQuitarPersonal.BackColor = System.Drawing.Color.White
        Me.btnQuitarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarPersonal.Image = Global.sidep.My.Resources.Resources.edit_remove
        Me.btnQuitarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitarPersonal.Location = New System.Drawing.Point(4, 6)
        Me.btnQuitarPersonal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuitarPersonal.Name = "btnQuitarPersonal"
        Me.btnQuitarPersonal.Size = New System.Drawing.Size(128, 25)
        Me.btnQuitarPersonal.TabIndex = 24
        Me.btnQuitarPersonal.Text = "Quitar Personal"
        Me.btnQuitarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitarPersonal.UseVisualStyleBackColor = False
        '
        'TabEstadisticas
        '
        Me.TabEstadisticas.Controls.Add(Me.Label14)
        Me.TabEstadisticas.Controls.Add(Me.Button1)
        Me.TabEstadisticas.Controls.Add(Me.Panel1)
        Me.TabEstadisticas.Controls.Add(Me.GridEstadisticas)
        Me.TabEstadisticas.Controls.Add(Me.btnQuitarEsta)
        Me.TabEstadisticas.Location = New System.Drawing.Point(4, 22)
        Me.TabEstadisticas.Margin = New System.Windows.Forms.Padding(2)
        Me.TabEstadisticas.Name = "TabEstadisticas"
        Me.TabEstadisticas.Padding = New System.Windows.Forms.Padding(2)
        Me.TabEstadisticas.Size = New System.Drawing.Size(1268, 504)
        Me.TabEstadisticas.TabIndex = 1
        Me.TabEstadisticas.Text = "Estadísticas"
        Me.TabEstadisticas.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 285)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(168, 15)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "Doble clic para Modificar"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.sidep.My.Resources.Resources.plus
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(570, 34)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 25)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Agregar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.nGruposTxt)
        Me.Panel1.Controls.Add(Me.txtMujeres)
        Me.Panel1.Controls.Add(Me.btnAgregarEsta)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtHombres)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cmbGrado)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(681, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 281)
        Me.Panel1.TabIndex = 27
        Me.Panel1.Visible = False
        '
        'nGruposTxt
        '
        Me.nGruposTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nGruposTxt.Location = New System.Drawing.Point(23, 75)
        Me.nGruposTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.nGruposTxt.Name = "nGruposTxt"
        Me.nGruposTxt.Size = New System.Drawing.Size(150, 19)
        Me.nGruposTxt.TabIndex = 94
        '
        'txtMujeres
        '
        Me.txtMujeres.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMujeres.Location = New System.Drawing.Point(24, 178)
        Me.txtMujeres.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMujeres.Name = "txtMujeres"
        Me.txtMujeres.Size = New System.Drawing.Size(150, 19)
        Me.txtMujeres.TabIndex = 96
        '
        'btnAgregarEsta
        '
        Me.btnAgregarEsta.BackColor = System.Drawing.Color.White
        Me.btnAgregarEsta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEsta.Image = Global.sidep.My.Resources.Resources._16__Save_
        Me.btnAgregarEsta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarEsta.Location = New System.Drawing.Point(25, 201)
        Me.btnAgregarEsta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarEsta.Name = "btnAgregarEsta"
        Me.btnAgregarEsta.Size = New System.Drawing.Size(149, 25)
        Me.btnAgregarEsta.TabIndex = 97
        Me.btnAgregarEsta.Text = "Guardar Informacion"
        Me.btnAgregarEsta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarEsta.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(22, 162)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "MUJERES"
        '
        'txtHombres
        '
        Me.txtHombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHombres.Location = New System.Drawing.Point(23, 129)
        Me.txtHombres.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHombres.Name = "txtHombres"
        Me.txtHombres.Size = New System.Drawing.Size(150, 19)
        Me.txtHombres.TabIndex = 95
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 113)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "HOMBRES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 13)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "NUMERO DE GRUPOS"
        '
        'cmbGrado
        '
        Me.cmbGrado.FormattingEnabled = True
        Me.cmbGrado.Location = New System.Drawing.Point(23, 26)
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.Size = New System.Drawing.Size(150, 21)
        Me.cmbGrado.TabIndex = 93
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "GRADO"
        '
        'GridEstadisticas
        '
        Me.GridEstadisticas.AllowUserToAddRows = False
        Me.GridEstadisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GridEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridEstadisticas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idestadistica, Me.GRADO, Me.GRUPO, Me.HOMBRES, Me.MUJERES})
        Me.GridEstadisticas.Location = New System.Drawing.Point(4, 5)
        Me.GridEstadisticas.Margin = New System.Windows.Forms.Padding(2)
        Me.GridEstadisticas.MultiSelect = False
        Me.GridEstadisticas.Name = "GridEstadisticas"
        Me.GridEstadisticas.ReadOnly = True
        Me.GridEstadisticas.RowTemplate.Height = 24
        Me.GridEstadisticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridEstadisticas.Size = New System.Drawing.Size(562, 281)
        Me.GridEstadisticas.TabIndex = 22
        '
        'idestadistica
        '
        Me.idestadistica.HeaderText = "IDESTADISTICA"
        Me.idestadistica.Name = "idestadistica"
        Me.idestadistica.ReadOnly = True
        Me.idestadistica.Width = 113
        '
        'GRADO
        '
        Me.GRADO.HeaderText = "GRADO"
        Me.GRADO.Name = "GRADO"
        Me.GRADO.ReadOnly = True
        Me.GRADO.Width = 71
        '
        'GRUPO
        '
        Me.GRUPO.HeaderText = "GRUPOS"
        Me.GRUPO.Name = "GRUPO"
        Me.GRUPO.ReadOnly = True
        Me.GRUPO.Width = 78
        '
        'HOMBRES
        '
        Me.HOMBRES.HeaderText = "HOMBRES"
        Me.HOMBRES.Name = "HOMBRES"
        Me.HOMBRES.ReadOnly = True
        Me.HOMBRES.Width = 86
        '
        'MUJERES
        '
        Me.MUJERES.HeaderText = "MUJERES"
        Me.MUJERES.Name = "MUJERES"
        Me.MUJERES.ReadOnly = True
        Me.MUJERES.Width = 83
        '
        'btnQuitarEsta
        '
        Me.btnQuitarEsta.BackColor = System.Drawing.Color.White
        Me.btnQuitarEsta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarEsta.Image = Global.sidep.My.Resources.Resources.edit_remove
        Me.btnQuitarEsta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitarEsta.Location = New System.Drawing.Point(570, 5)
        Me.btnQuitarEsta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuitarEsta.Name = "btnQuitarEsta"
        Me.btnQuitarEsta.Size = New System.Drawing.Size(76, 25)
        Me.btnQuitarEsta.TabIndex = 26
        Me.btnQuitarEsta.Text = "Quitar"
        Me.btnQuitarEsta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitarEsta.UseVisualStyleBackColor = False
        '
        'txtCicloEscolar
        '
        Me.txtCicloEscolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCicloEscolar.Location = New System.Drawing.Point(700, 28)
        Me.txtCicloEscolar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCicloEscolar.Name = "txtCicloEscolar"
        Me.txtCicloEscolar.ReadOnly = True
        Me.txtCicloEscolar.Size = New System.Drawing.Size(324, 49)
        Me.txtCicloEscolar.TabIndex = 31
        Me.txtCicloEscolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(592, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "CICLO ESCOLAR"
        '
        'txtIdCT
        '
        Me.txtIdCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCT.Location = New System.Drawing.Point(547, 7)
        Me.txtIdCT.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdCT.Name = "txtIdCT"
        Me.txtIdCT.ReadOnly = True
        Me.txtIdCT.Size = New System.Drawing.Size(42, 19)
        Me.txtIdCT.TabIndex = 32
        Me.txtIdCT.Visible = False
        '
        'btnBuscarCT
        '
        Me.btnBuscarCT.BackColor = System.Drawing.Color.White
        Me.btnBuscarCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCT.Image = Global.sidep.My.Resources.Resources._001_37
        Me.btnBuscarCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCT.Location = New System.Drawing.Point(1028, 7)
        Me.btnBuscarCT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarCT.Name = "btnBuscarCT"
        Me.btnBuscarCT.Size = New System.Drawing.Size(259, 70)
        Me.btnBuscarCT.TabIndex = 0
        Me.btnBuscarCT.Text = "Buscar Centro de Trabajo"
        Me.btnBuscarCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarCT.UseVisualStyleBackColor = False
        '
        'lblRegs
        '
        Me.lblRegs.AutoSize = True
        Me.lblRegs.Location = New System.Drawing.Point(1061, 499)
        Me.lblRegs.Name = "lblRegs"
        Me.lblRegs.Size = New System.Drawing.Size(0, 13)
        Me.lblRegs.TabIndex = 33
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.sidep.My.Resources.Resources._16__Print_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1028, 135)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(259, 25)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Imprimir Carga Horaria"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.sidep.My.Resources.Resources._16__Print_
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(1028, 108)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(259, 28)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Imprimir Desgloce del Horario"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.sidep.My.Resources.Resources._16__Print_
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(1028, 81)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(259, 25)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Imprimir Horario"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'frmPlantillaPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1298, 741)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtIdCT)
        Me.Controls.Add(Me.txtCicloEscolar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.txtTurno)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.btnBuscarCT)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreCT)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmPlantillaPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plantilla de Personal"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabs.ResumeLayout(False)
        Me.TabPersonal.ResumeLayout(False)
        Me.TabPersonal.PerformLayout()
        Me.TabEstadisticas.ResumeLayout(False)
        Me.TabEstadisticas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridEstadisticas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtTurno As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarPersonal As System.Windows.Forms.Button
    Friend WithEvents btnQuitarPersonal As System.Windows.Forms.Button
    Friend WithEvents btnBuscarCT As System.Windows.Forms.Button
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents TabPersonal As System.Windows.Forms.TabPage
    Friend WithEvents TabEstadisticas As System.Windows.Forms.TabPage
    Friend WithEvents txtCicloEscolar As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIdCT As System.Windows.Forms.TextBox
    Friend WithEvents GridEstadisticas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregarEsta As System.Windows.Forms.Button
    Friend WithEvents btnQuitarEsta As System.Windows.Forms.Button
    Friend WithEvents txtMujeres As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtHombres As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbGrado As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nGruposTxt As System.Windows.Forms.TextBox
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents imprimirCmd As System.Windows.Forms.Button
    Friend WithEvents IdPlantilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroControl As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents lblRegs As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents idestadistica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GRADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GRUPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOMBRES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MUJERES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
