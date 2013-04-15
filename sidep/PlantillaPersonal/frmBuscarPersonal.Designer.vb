<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPersonal
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
        Me.IdPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroControl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEXT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLONIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtParametroBusqueda = New System.Windows.Forms.TextBox()
        Me.btnBuscarCT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarPersonal = New System.Windows.Forms.Button()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPersonal, Me.NumeroControl, Me.Nombre, Me.PATERNO, Me.MATERNO, Me.CALLE, Me.NUMEXT, Me.COLONIA})
        Me.Grid.Location = New System.Drawing.Point(9, 51)
        Me.Grid.Margin = New System.Windows.Forms.Padding(2)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(972, 333)
        Me.Grid.TabIndex = 0
        '
        'IdPersonal
        '
        Me.IdPersonal.HeaderText = "IdPersonal"
        Me.IdPersonal.Name = "IdPersonal"
        Me.IdPersonal.ReadOnly = True
        Me.IdPersonal.Visible = False
        Me.IdPersonal.Width = 82
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
        'PATERNO
        '
        Me.PATERNO.HeaderText = "APELLIDO PATERNO"
        Me.PATERNO.Name = "PATERNO"
        Me.PATERNO.ReadOnly = True
        Me.PATERNO.Width = 127
        '
        'MATERNO
        '
        Me.MATERNO.HeaderText = "APELLIDO MATERNO"
        Me.MATERNO.Name = "MATERNO"
        Me.MATERNO.ReadOnly = True
        Me.MATERNO.Width = 129
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
        'txtParametroBusqueda
        '
        Me.txtParametroBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametroBusqueda.Location = New System.Drawing.Point(9, 19)
        Me.txtParametroBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.txtParametroBusqueda.Name = "txtParametroBusqueda"
        Me.txtParametroBusqueda.Size = New System.Drawing.Size(551, 28)
        Me.txtParametroBusqueda.TabIndex = 11
        '
        'btnBuscarCT
        '
        Me.btnBuscarCT.BackColor = System.Drawing.Color.White
        Me.btnBuscarCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCT.Image = Global.sidep.My.Resources.Resources._001_37
        Me.btnBuscarCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCT.Location = New System.Drawing.Point(564, 19)
        Me.btnBuscarCT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarCT.Name = "btnBuscarCT"
        Me.btnBuscarCT.Size = New System.Drawing.Size(86, 26)
        Me.btnBuscarCT.TabIndex = 14
        Me.btnBuscarCT.Text = "Buscar"
        Me.btnBuscarCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarCT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombre del Personal"
        '
        'btnAgregarPersonal
        '
        Me.btnAgregarPersonal.BackColor = System.Drawing.Color.White
        Me.btnAgregarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPersonal.Image = Global.sidep.My.Resources.Resources.plus
        Me.btnAgregarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarPersonal.Location = New System.Drawing.Point(654, 18)
        Me.btnAgregarPersonal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarPersonal.Name = "btnAgregarPersonal"
        Me.btnAgregarPersonal.Size = New System.Drawing.Size(86, 28)
        Me.btnAgregarPersonal.TabIndex = 25
        Me.btnAgregarPersonal.Text = "Agregar"
        Me.btnAgregarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarPersonal.UseVisualStyleBackColor = False
        '
        'frmBuscarPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 395)
        Me.Controls.Add(Me.btnAgregarPersonal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscarCT)
        Me.Controls.Add(Me.txtParametroBusqueda)
        Me.Controls.Add(Me.Grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBuscarPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Personal"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents txtParametroBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarCT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdPersonal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroControl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MATERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMEXT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLONIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAgregarPersonal As System.Windows.Forms.Button
End Class
