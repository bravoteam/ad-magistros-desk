<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCT
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
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.IdCT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOMICILIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLONIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MUNICIPIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtParametroBusqueda = New System.Windows.Forms.TextBox()
        Me.opNombreCT = New System.Windows.Forms.RadioButton()
        Me.opClaveCT = New System.Windows.Forms.RadioButton()
        Me.btnBuscarCT = New System.Windows.Forms.Button()
        Me.cmbCiclo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCT, Me.Clave, Me.Nombre, Me.DOMICILIO, Me.COLONIA, Me.MUNICIPIO})
        Me.Grid.Location = New System.Drawing.Point(8, 128)
        Me.Grid.Margin = New System.Windows.Forms.Padding(2)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(986, 415)
        Me.Grid.TabIndex = 0
        '
        'IdCT
        '
        Me.IdCT.HeaderText = "IdCT"
        Me.IdCT.Name = "IdCT"
        Me.IdCT.ReadOnly = True
        Me.IdCT.Visible = False
        Me.IdCT.Width = 55
        '
        'Clave
        '
        Me.Clave.HeaderText = "CLAVE"
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        Me.Clave.Width = 66
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "NOMBRE"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 79
        '
        'DOMICILIO
        '
        Me.DOMICILIO.HeaderText = "DOMICILIO"
        Me.DOMICILIO.Name = "DOMICILIO"
        Me.DOMICILIO.ReadOnly = True
        Me.DOMICILIO.Width = 87
        '
        'COLONIA
        '
        Me.COLONIA.HeaderText = "COLONIA"
        Me.COLONIA.Name = "COLONIA"
        Me.COLONIA.ReadOnly = True
        Me.COLONIA.Width = 79
        '
        'MUNICIPIO
        '
        Me.MUNICIPIO.HeaderText = "MUNICIPIO"
        Me.MUNICIPIO.Name = "MUNICIPIO"
        Me.MUNICIPIO.ReadOnly = True
        Me.MUNICIPIO.Width = 88
        '
        'txtParametroBusqueda
        '
        Me.txtParametroBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametroBusqueda.Location = New System.Drawing.Point(11, 91)
        Me.txtParametroBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.txtParametroBusqueda.Name = "txtParametroBusqueda"
        Me.txtParametroBusqueda.Size = New System.Drawing.Size(516, 28)
        Me.txtParametroBusqueda.TabIndex = 11
        '
        'opNombreCT
        '
        Me.opNombreCT.AutoSize = True
        Me.opNombreCT.Location = New System.Drawing.Point(11, 73)
        Me.opNombreCT.Margin = New System.Windows.Forms.Padding(2)
        Me.opNombreCT.Name = "opNombreCT"
        Me.opNombreCT.Size = New System.Drawing.Size(62, 17)
        Me.opNombreCT.TabIndex = 15
        Me.opNombreCT.TabStop = True
        Me.opNombreCT.Text = "Nombre"
        Me.opNombreCT.UseVisualStyleBackColor = True
        '
        'opClaveCT
        '
        Me.opClaveCT.AutoSize = True
        Me.opClaveCT.Location = New System.Drawing.Point(75, 73)
        Me.opClaveCT.Margin = New System.Windows.Forms.Padding(2)
        Me.opClaveCT.Name = "opClaveCT"
        Me.opClaveCT.Size = New System.Drawing.Size(52, 17)
        Me.opClaveCT.TabIndex = 16
        Me.opClaveCT.TabStop = True
        Me.opClaveCT.Text = "Clave"
        Me.opClaveCT.UseVisualStyleBackColor = True
        '
        'btnBuscarCT
        '
        Me.btnBuscarCT.BackColor = System.Drawing.Color.White
        Me.btnBuscarCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCT.Image = Global.sidep.My.Resources.Resources._001_37
        Me.btnBuscarCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCT.Location = New System.Drawing.Point(545, 93)
        Me.btnBuscarCT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarCT.Name = "btnBuscarCT"
        Me.btnBuscarCT.Size = New System.Drawing.Size(86, 26)
        Me.btnBuscarCT.TabIndex = 14
        Me.btnBuscarCT.Text = "Buscar"
        Me.btnBuscarCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarCT.UseVisualStyleBackColor = False
        '
        'cmbCiclo
        '
        Me.cmbCiclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCiclo.FormattingEnabled = True
        Me.cmbCiclo.Location = New System.Drawing.Point(200, 15)
        Me.cmbCiclo.Name = "cmbCiclo"
        Me.cmbCiclo.Size = New System.Drawing.Size(327, 45)
        Me.cmbCiclo.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 31)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Ciclo Escolar"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(981, 8)
        Me.Label2.TabIndex = 19
        '
        'frmBuscarCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1006, 554)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCiclo)
        Me.Controls.Add(Me.opClaveCT)
        Me.Controls.Add(Me.opNombreCT)
        Me.Controls.Add(Me.btnBuscarCT)
        Me.Controls.Add(Me.txtParametroBusqueda)
        Me.Controls.Add(Me.Grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBuscarCT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Centro de Trabajo"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents txtParametroBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents opNombreCT As System.Windows.Forms.RadioButton
    Friend WithEvents opClaveCT As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscarCT As System.Windows.Forms.Button
    Friend WithEvents IdCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOMICILIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLONIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MUNICIPIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
