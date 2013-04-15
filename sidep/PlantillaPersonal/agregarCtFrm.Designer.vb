<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarCtFrm
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
        Me.grupoBusqueda = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFiltra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gridCt = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grupoBusqueda.SuspendLayout()
        CType(Me.gridCt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupoBusqueda
        '
        Me.grupoBusqueda.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.grupoBusqueda.Controls.Add(Me.Label1)
        Me.grupoBusqueda.Controls.Add(Me.Label5)
        Me.grupoBusqueda.Controls.Add(Me.txtFiltra)
        Me.grupoBusqueda.Controls.Add(Me.Label4)
        Me.grupoBusqueda.Controls.Add(Me.gridCt)
        Me.grupoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoBusqueda.Location = New System.Drawing.Point(12, 12)
        Me.grupoBusqueda.Name = "grupoBusqueda"
        Me.grupoBusqueda.Size = New System.Drawing.Size(751, 386)
        Me.grupoBusqueda.TabIndex = 152
        Me.grupoBusqueda.TabStop = False
        Me.grupoBusqueda.Text = "Listado de CT's"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(533, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "ENTER para Buscar"
        '
        'txtFiltra
        '
        Me.txtFiltra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltra.Location = New System.Drawing.Point(195, 24)
        Me.txtFiltra.MaxLength = 10
        Me.txtFiltra.Name = "txtFiltra"
        Me.txtFiltra.Size = New System.Drawing.Size(332, 21)
        Me.txtFiltra.TabIndex = 150
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "FILTRAR X NOMBRE O CCT"
        '
        'gridCt
        '
        Me.gridCt.AllowUserToAddRows = False
        Me.gridCt.AllowUserToDeleteRows = False
        Me.gridCt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridCt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCt.Location = New System.Drawing.Point(9, 49)
        Me.gridCt.Margin = New System.Windows.Forms.Padding(2)
        Me.gridCt.MultiSelect = False
        Me.gridCt.Name = "gridCt"
        Me.gridCt.ReadOnly = True
        Me.gridCt.RowTemplate.Height = 24
        Me.gridCt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridCt.Size = New System.Drawing.Size(724, 307)
        Me.gridCt.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Doble Clic para Agregar"
        '
        'agregarCtFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 397)
        Me.Controls.Add(Me.grupoBusqueda)
        Me.Name = "agregarCtFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregarCtFrm"
        Me.grupoBusqueda.ResumeLayout(False)
        Me.grupoBusqueda.PerformLayout()
        CType(Me.gridCt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFiltra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gridCt As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
