<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class horarioIsenco
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMaestro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.cmbGrado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbLicenciatura = New System.Windows.Forms.ComboBox()
        Me.lnkAgregarMateria = New System.Windows.Forms.LinkLabel()
        Me.txtA = New System.Windows.Forms.MaskedTextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtDe = New System.Windows.Forms.MaskedTextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmbMateria = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbDia = New System.Windows.Forms.ComboBox()
        Me.GridHorario = New System.Windows.Forms.DataGridView()
        Me.ID_HORARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LUNES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARTES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIERCOLES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JUEVES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIERNES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarHora = New System.Windows.Forms.Button()
        Me.btnQuitarHora = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(988, 626)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.cmbMaestro)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.cmbEspecialidad)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cmbGrupo)
        Me.TabPage2.Controls.Add(Me.cmbGrado)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.cmbLicenciatura)
        Me.TabPage2.Controls.Add(Me.lnkAgregarMateria)
        Me.TabPage2.Controls.Add(Me.txtA)
        Me.TabPage2.Controls.Add(Me.Label33)
        Me.TabPage2.Controls.Add(Me.Label32)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.txtDe)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.cmbMateria)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.cmbDia)
        Me.TabPage2.Controls.Add(Me.GridHorario)
        Me.TabPage2.Controls.Add(Me.btnAgregarHora)
        Me.TabPage2.Controls.Add(Me.btnQuitarHora)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(980, 600)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Captura de Horario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 332
        Me.Label4.Text = "MAESTRO"
        '
        'cmbMaestro
        '
        Me.cmbMaestro.FormattingEnabled = True
        Me.cmbMaestro.Location = New System.Drawing.Point(284, 113)
        Me.cmbMaestro.Name = "cmbMaestro"
        Me.cmbMaestro.Size = New System.Drawing.Size(479, 21)
        Me.cmbMaestro.TabIndex = 333
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(442, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 330
        Me.Label3.Text = "ESPECIALIDAD"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(445, 19)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(367, 21)
        Me.cmbEspecialidad.TabIndex = 331
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(962, 6)
        Me.Label2.TabIndex = 329
        '
        'cmbGrupo
        '
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(898, 19)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(71, 21)
        Me.cmbGrupo.TabIndex = 328
        '
        'cmbGrado
        '
        Me.cmbGrado.FormattingEnabled = True
        Me.cmbGrado.Location = New System.Drawing.Point(818, 19)
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.Size = New System.Drawing.Size(71, 21)
        Me.cmbGrado.TabIndex = 327
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 325
        Me.Label1.Text = "LICENCIATURA"
        '
        'cmbLicenciatura
        '
        Me.cmbLicenciatura.FormattingEnabled = True
        Me.cmbLicenciatura.Location = New System.Drawing.Point(7, 19)
        Me.cmbLicenciatura.Name = "cmbLicenciatura"
        Me.cmbLicenciatura.Size = New System.Drawing.Size(432, 21)
        Me.cmbLicenciatura.TabIndex = 326
        '
        'lnkAgregarMateria
        '
        Me.lnkAgregarMateria.AutoSize = True
        Me.lnkAgregarMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAgregarMateria.Location = New System.Drawing.Point(499, 57)
        Me.lnkAgregarMateria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkAgregarMateria.Name = "lnkAgregarMateria"
        Me.lnkAgregarMateria.Size = New System.Drawing.Size(126, 13)
        Me.lnkAgregarMateria.TabIndex = 324
        Me.lnkAgregarMateria.TabStop = True
        Me.lnkAgregarMateria.Text = "AGREGAR MATERIA"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(203, 73)
        Me.txtA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtA.Mask = "00:00"
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(76, 20)
        Me.txtA.TabIndex = 318
        Me.txtA.ValidatingType = GetType(Date)
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(200, 57)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(19, 13)
        Me.Label33.TabIndex = 315
        Me.Label33.Text = "A:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(895, 5)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(51, 13)
        Me.Label32.TabIndex = 314
        Me.Label32.Text = "GRUPO"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(815, 5)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 13)
        Me.Label31.TabIndex = 313
        Me.Label31.Text = "GRADO"
        '
        'txtDe
        '
        Me.txtDe.Location = New System.Drawing.Point(123, 73)
        Me.txtDe.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDe.Mask = "00:00"
        Me.txtDe.Name = "txtDe"
        Me.txtDe.Size = New System.Drawing.Size(76, 20)
        Me.txtDe.TabIndex = 317
        Me.txtDe.ValidatingType = GetType(Date)
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(285, 57)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(154, 13)
        Me.Label30.TabIndex = 312
        Me.Label30.Text = "MATERIA (ASIGNATURA)"
        '
        'cmbMateria
        '
        Me.cmbMateria.FormattingEnabled = True
        Me.cmbMateria.Location = New System.Drawing.Point(284, 73)
        Me.cmbMateria.Name = "cmbMateria"
        Me.cmbMateria.Size = New System.Drawing.Size(479, 21)
        Me.cmbMateria.TabIndex = 319
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(121, 57)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(28, 13)
        Me.Label29.TabIndex = 311
        Me.Label29.Text = "DE:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(11, 58)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 13)
        Me.Label23.TabIndex = 310
        Me.Label23.Text = "DIA"
        '
        'cmbDia
        '
        Me.cmbDia.FormattingEnabled = True
        Me.cmbDia.Location = New System.Drawing.Point(10, 73)
        Me.cmbDia.Name = "cmbDia"
        Me.cmbDia.Size = New System.Drawing.Size(109, 21)
        Me.cmbDia.TabIndex = 316
        '
        'GridHorario
        '
        Me.GridHorario.AllowUserToAddRows = False
        Me.GridHorario.AllowUserToDeleteRows = False
        Me.GridHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GridHorario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_HORARIO, Me.HORA, Me.LUNES, Me.MARTES, Me.MIERCOLES, Me.JUEVES, Me.VIERNES})
        Me.GridHorario.Location = New System.Drawing.Point(11, 139)
        Me.GridHorario.Margin = New System.Windows.Forms.Padding(2)
        Me.GridHorario.Name = "GridHorario"
        Me.GridHorario.ReadOnly = True
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridHorario.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GridHorario.RowTemplate.Height = 24
        Me.GridHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridHorario.Size = New System.Drawing.Size(958, 456)
        Me.GridHorario.TabIndex = 309
        '
        'ID_HORARIO
        '
        Me.ID_HORARIO.HeaderText = "ID_HORARIO"
        Me.ID_HORARIO.Name = "ID_HORARIO"
        Me.ID_HORARIO.ReadOnly = True
        Me.ID_HORARIO.Visible = False
        Me.ID_HORARIO.Width = 99
        '
        'HORA
        '
        Me.HORA.HeaderText = "HORA"
        Me.HORA.Name = "HORA"
        Me.HORA.ReadOnly = True
        Me.HORA.Width = 63
        '
        'LUNES
        '
        Me.LUNES.HeaderText = "LUNES"
        Me.LUNES.Name = "LUNES"
        Me.LUNES.ReadOnly = True
        Me.LUNES.Width = 68
        '
        'MARTES
        '
        Me.MARTES.HeaderText = "MARTES"
        Me.MARTES.Name = "MARTES"
        Me.MARTES.ReadOnly = True
        Me.MARTES.Width = 77
        '
        'MIERCOLES
        '
        Me.MIERCOLES.HeaderText = "MIERCOLES"
        Me.MIERCOLES.Name = "MIERCOLES"
        Me.MIERCOLES.ReadOnly = True
        Me.MIERCOLES.Width = 94
        '
        'JUEVES
        '
        Me.JUEVES.HeaderText = "JUEVES"
        Me.JUEVES.Name = "JUEVES"
        Me.JUEVES.ReadOnly = True
        Me.JUEVES.Width = 73
        '
        'VIERNES
        '
        Me.VIERNES.HeaderText = "VIERNES"
        Me.VIERNES.Name = "VIERNES"
        Me.VIERNES.ReadOnly = True
        Me.VIERNES.Width = 79
        '
        'btnAgregarHora
        '
        Me.btnAgregarHora.BackColor = System.Drawing.Color.White
        Me.btnAgregarHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarHora.Image = Global.sidep.My.Resources.Resources.plus
        Me.btnAgregarHora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarHora.Location = New System.Drawing.Point(768, 109)
        Me.btnAgregarHora.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarHora.Name = "btnAgregarHora"
        Me.btnAgregarHora.Size = New System.Drawing.Size(104, 25)
        Me.btnAgregarHora.TabIndex = 322
        Me.btnAgregarHora.Text = "Agregar Hora"
        Me.btnAgregarHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarHora.UseVisualStyleBackColor = False
        '
        'btnQuitarHora
        '
        Me.btnQuitarHora.BackColor = System.Drawing.Color.White
        Me.btnQuitarHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarHora.Image = Global.sidep.My.Resources.Resources.edit_remove
        Me.btnQuitarHora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitarHora.Location = New System.Drawing.Point(876, 109)
        Me.btnQuitarHora.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuitarHora.Name = "btnQuitarHora"
        Me.btnQuitarHora.Size = New System.Drawing.Size(93, 25)
        Me.btnQuitarHora.TabIndex = 323
        Me.btnQuitarHora.Text = "Quitar Hora"
        Me.btnQuitarHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitarHora.UseVisualStyleBackColor = False
        '
        'horarioIsenco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 641)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "horarioIsenco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Horarios Isenco"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GridHorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lnkAgregarMateria As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAgregarHora As System.Windows.Forms.Button
    Friend WithEvents btnQuitarHora As System.Windows.Forms.Button
    Friend WithEvents txtA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtDe As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmbMateria As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbDia As System.Windows.Forms.ComboBox
    Friend WithEvents GridHorario As System.Windows.Forms.DataGridView
    Friend WithEvents ID_HORARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LUNES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARTES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MIERCOLES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JUEVES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VIERNES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbLicenciatura As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGrado As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbMaestro As System.Windows.Forms.ComboBox
End Class
