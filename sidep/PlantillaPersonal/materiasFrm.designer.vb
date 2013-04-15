<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class materiasFrm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGrado = New System.Windows.Forms.MaskedTextBox()
        Me.txtHoras = New System.Windows.Forms.MaskedTextBox()
        Me.txtAgrupacion = New System.Windows.Forms.TextBox()
        Me.cmbNivelId = New System.Windows.Forms.ComboBox()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtidMateria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.salirCmd = New System.Windows.Forms.Button()
        Me.eliminarCmd = New System.Windows.Forms.Button()
        Me.nuevoCmd = New System.Windows.Forms.Button()
        Me.guardarCmd = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.idmateria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agrupacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idnivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGrado)
        Me.GroupBox1.Controls.Add(Me.txtHoras)
        Me.GroupBox1.Controls.Add(Me.txtAgrupacion)
        Me.GroupBox1.Controls.Add(Me.cmbNivelId)
        Me.GroupBox1.Controls.Add(Me.cmbNivel)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtidMateria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 195)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE LA MATERIA"
        '
        'txtGrado
        '
        Me.txtGrado.Location = New System.Drawing.Point(126, 161)
        Me.txtGrado.Mask = "00"
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Size = New System.Drawing.Size(100, 20)
        Me.txtGrado.TabIndex = 34
        '
        'txtHoras
        '
        Me.txtHoras.Location = New System.Drawing.Point(126, 81)
        Me.txtHoras.Mask = "00"
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(100, 20)
        Me.txtHoras.TabIndex = 33
        '
        'txtAgrupacion
        '
        Me.txtAgrupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgrupacion.Location = New System.Drawing.Point(126, 107)
        Me.txtAgrupacion.Name = "txtAgrupacion"
        Me.txtAgrupacion.Size = New System.Drawing.Size(337, 21)
        Me.txtAgrupacion.TabIndex = 31
        '
        'cmbNivelId
        '
        Me.cmbNivelId.FormattingEnabled = True
        Me.cmbNivelId.Location = New System.Drawing.Point(469, 134)
        Me.cmbNivelId.Name = "cmbNivelId"
        Me.cmbNivelId.Size = New System.Drawing.Size(27, 21)
        Me.cmbNivelId.TabIndex = 25
        Me.cmbNivelId.Visible = False
        '
        'cmbNivel
        '
        Me.cmbNivel.FormattingEnabled = True
        Me.cmbNivel.Location = New System.Drawing.Point(126, 134)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.Size = New System.Drawing.Size(337, 21)
        Me.cmbNivel.TabIndex = 3
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(126, 53)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(337, 21)
        Me.txtnombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID MATERIA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "GRADO:"
        '
        'txtidMateria
        '
        Me.txtidMateria.Enabled = False
        Me.txtidMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidMateria.Location = New System.Drawing.Point(126, 26)
        Me.txtidMateria.Name = "txtidMateria"
        Me.txtidMateria.Size = New System.Drawing.Size(100, 21)
        Me.txtidMateria.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "HORAS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "AGRUPACION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "NIVEL:"
        '
        'salirCmd
        '
        Me.salirCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salirCmd.Location = New System.Drawing.Point(576, 114)
        Me.salirCmd.Name = "salirCmd"
        Me.salirCmd.Size = New System.Drawing.Size(142, 26)
        Me.salirCmd.TabIndex = 10
        Me.salirCmd.Text = "Salir"
        Me.salirCmd.UseVisualStyleBackColor = True
        '
        'eliminarCmd
        '
        Me.eliminarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminarCmd.Location = New System.Drawing.Point(576, 78)
        Me.eliminarCmd.Name = "eliminarCmd"
        Me.eliminarCmd.Size = New System.Drawing.Size(142, 27)
        Me.eliminarCmd.TabIndex = 8
        Me.eliminarCmd.Text = "Eliminar"
        Me.eliminarCmd.UseVisualStyleBackColor = True
        '
        'nuevoCmd
        '
        Me.nuevoCmd.BackColor = System.Drawing.SystemColors.Control
        Me.nuevoCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nuevoCmd.Location = New System.Drawing.Point(576, 12)
        Me.nuevoCmd.Name = "nuevoCmd"
        Me.nuevoCmd.Size = New System.Drawing.Size(142, 27)
        Me.nuevoCmd.TabIndex = 11
        Me.nuevoCmd.Text = "Nuevo"
        Me.nuevoCmd.UseVisualStyleBackColor = False
        '
        'guardarCmd
        '
        Me.guardarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardarCmd.Location = New System.Drawing.Point(576, 45)
        Me.guardarCmd.Name = "guardarCmd"
        Me.guardarCmd.Size = New System.Drawing.Size(142, 27)
        Me.guardarCmd.TabIndex = 7
        Me.guardarCmd.Text = "Guardar"
        Me.guardarCmd.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idmateria, Me.materia, Me.horas, Me.agrupacion, Me.idnivel, Me.nivel, Me.grado})
        Me.Grid.Location = New System.Drawing.Point(12, 227)
        Me.Grid.Margin = New System.Windows.Forms.Padding(2)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(703, 296)
        Me.Grid.TabIndex = 141
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Location = New System.Drawing.Point(11, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(704, 20)
        Me.Panel3.TabIndex = 142
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(148, 13)
        Me.Label28.TabIndex = 121
        Me.Label28.Text = "LISTADO DE MATERIAS"
        '
        'idmateria
        '
        Me.idmateria.HeaderText = "ID MATERIA"
        Me.idmateria.Name = "idmateria"
        Me.idmateria.Visible = False
        Me.idmateria.Width = 94
        '
        'materia
        '
        Me.materia.HeaderText = "MATERIA"
        Me.materia.Name = "materia"
        Me.materia.ReadOnly = True
        Me.materia.Width = 80
        '
        'horas
        '
        Me.horas.HeaderText = "HORAS"
        Me.horas.Name = "horas"
        Me.horas.ReadOnly = True
        Me.horas.Width = 70
        '
        'agrupacion
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.agrupacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.agrupacion.HeaderText = "AGRUPACION"
        Me.agrupacion.Name = "agrupacion"
        Me.agrupacion.ReadOnly = True
        Me.agrupacion.Width = 103
        '
        'idnivel
        '
        Me.idnivel.HeaderText = "idnivel"
        Me.idnivel.Name = "idnivel"
        Me.idnivel.Visible = False
        Me.idnivel.Width = 62
        '
        'nivel
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nivel.DefaultCellStyle = DataGridViewCellStyle4
        Me.nivel.HeaderText = "NIVEL"
        Me.nivel.Name = "nivel"
        Me.nivel.ReadOnly = True
        Me.nivel.Width = 63
        '
        'grado
        '
        Me.grado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.grado.FillWeight = 400.0!
        Me.grado.HeaderText = "GRADO"
        Me.grado.Name = "grado"
        Me.grado.Width = 400
        '
        'materiasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(725, 529)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.salirCmd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.eliminarCmd)
        Me.Controls.Add(Me.nuevoCmd)
        Me.Controls.Add(Me.guardarCmd)
        Me.Name = "materiasFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Materias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents salirCmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtidMateria As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents eliminarCmd As System.Windows.Forms.Button
    Friend WithEvents nuevoCmd As System.Windows.Forms.Button
    Friend WithEvents guardarCmd As System.Windows.Forms.Button
    Friend WithEvents cmbNivel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNivelId As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtAgrupacion As System.Windows.Forms.TextBox
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtHoras As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtGrado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents idmateria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents materia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents horas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents agrupacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idnivel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nivel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
