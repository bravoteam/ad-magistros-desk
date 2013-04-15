<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuariosFrm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.salirCmd = New System.Windows.Forms.Button()
        Me.eliminarCmd = New System.Windows.Forms.Button()
        Me.nuevoCmd = New System.Windows.Forms.Button()
        Me.guardarCmd = New System.Windows.Forms.Button()
        Me.buscarCmd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAddCt = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IDCT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL USUARIO"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(126, 53)
        Me.txtUsuario.MaxLength = 10
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(151, 21)
        Me.txtUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID USUARIO:"
        '
        'txtidUsuario
        '
        Me.txtidUsuario.Enabled = False
        Me.txtidUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidUsuario.Location = New System.Drawing.Point(126, 26)
        Me.txtidUsuario.Name = "txtidUsuario"
        Me.txtidUsuario.Size = New System.Drawing.Size(73, 21)
        Me.txtidUsuario.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "USUARIO:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(126, 80)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(151, 21)
        Me.txtPassword.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PASSWORD:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Location = New System.Drawing.Point(0, 134)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(704, 20)
        Me.Panel3.TabIndex = 148
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(248, 13)
        Me.Label28.TabIndex = 121
        Me.Label28.Text = "LISTADO DE CT´S CORRESPONDIENTES"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCT, Me.CCT, Me.NOMBRE})
        Me.Grid.Location = New System.Drawing.Point(1, 153)
        Me.Grid.Margin = New System.Windows.Forms.Padding(2)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(703, 296)
        Me.Grid.TabIndex = 147
        '
        'salirCmd
        '
        Me.salirCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salirCmd.Location = New System.Drawing.Point(731, 87)
        Me.salirCmd.Name = "salirCmd"
        Me.salirCmd.Size = New System.Drawing.Size(142, 26)
        Me.salirCmd.TabIndex = 145
        Me.salirCmd.Text = "Salir"
        Me.salirCmd.UseVisualStyleBackColor = True
        '
        'eliminarCmd
        '
        Me.eliminarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminarCmd.Location = New System.Drawing.Point(732, 239)
        Me.eliminarCmd.Name = "eliminarCmd"
        Me.eliminarCmd.Size = New System.Drawing.Size(142, 27)
        Me.eliminarCmd.TabIndex = 144
        Me.eliminarCmd.Text = "Eliminar"
        Me.eliminarCmd.UseVisualStyleBackColor = True
        Me.eliminarCmd.Visible = False
        '
        'nuevoCmd
        '
        Me.nuevoCmd.BackColor = System.Drawing.SystemColors.Control
        Me.nuevoCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nuevoCmd.Location = New System.Drawing.Point(731, 17)
        Me.nuevoCmd.Name = "nuevoCmd"
        Me.nuevoCmd.Size = New System.Drawing.Size(142, 27)
        Me.nuevoCmd.TabIndex = 146
        Me.nuevoCmd.Text = "Limpiar"
        Me.nuevoCmd.UseVisualStyleBackColor = False
        '
        'guardarCmd
        '
        Me.guardarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardarCmd.Location = New System.Drawing.Point(731, 50)
        Me.guardarCmd.Name = "guardarCmd"
        Me.guardarCmd.Size = New System.Drawing.Size(142, 27)
        Me.guardarCmd.TabIndex = 143
        Me.guardarCmd.Text = "Guardar"
        Me.guardarCmd.UseVisualStyleBackColor = True
        '
        'buscarCmd
        '
        Me.buscarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buscarCmd.Location = New System.Drawing.Point(732, 257)
        Me.buscarCmd.Name = "buscarCmd"
        Me.buscarCmd.Size = New System.Drawing.Size(142, 27)
        Me.buscarCmd.TabIndex = 149
        Me.buscarCmd.Text = "Buscar"
        Me.buscarCmd.UseVisualStyleBackColor = True
        Me.buscarCmd.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.cmdAddCt)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Grid)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(720, 487)
        Me.GroupBox2.TabIndex = 150
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'cmdAddCt
        '
        Me.cmdAddCt.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddCt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddCt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAddCt.Location = New System.Drawing.Point(562, 454)
        Me.cmdAddCt.Name = "cmdAddCt"
        Me.cmdAddCt.Size = New System.Drawing.Size(142, 27)
        Me.cmdAddCt.TabIndex = 149
        Me.cmdAddCt.Text = "Agregar CT"
        Me.cmdAddCt.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(414, 454)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 27)
        Me.Button2.TabIndex = 150
        Me.Button2.Text = "Eliminar CT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'IDCT
        '
        Me.IDCT.HeaderText = "IDCT"
        Me.IDCT.Name = "IDCT"
        Me.IDCT.ReadOnly = True
        Me.IDCT.Width = 57
        '
        'CCT
        '
        Me.CCT.HeaderText = "CCT"
        Me.CCT.Name = "CCT"
        Me.CCT.ReadOnly = True
        Me.CCT.Width = 53
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 79
        '
        'usuariosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 504)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.buscarCmd)
        Me.Controls.Add(Me.salirCmd)
        Me.Controls.Add(Me.eliminarCmd)
        Me.Controls.Add(Me.nuevoCmd)
        Me.Controls.Add(Me.guardarCmd)
        Me.Name = "usuariosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents salirCmd As System.Windows.Forms.Button
    Friend WithEvents eliminarCmd As System.Windows.Forms.Button
    Friend WithEvents nuevoCmd As System.Windows.Forms.Button
    Friend WithEvents guardarCmd As System.Windows.Forms.Button
    Friend WithEvents buscarCmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdAddCt As System.Windows.Forms.Button
    Friend WithEvents IDCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
