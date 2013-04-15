<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarDireccion
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
        Me.txtCp = New System.Windows.Forms.MaskedTextBox()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbColoniaId = New System.Windows.Forms.ComboBox()
        Me.cmbMunicipioId = New System.Windows.Forms.ComboBox()
        Me.cmbColonia = New System.Windows.Forms.ComboBox()
        Me.cmbEstadoId = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.obtenerCpCmd = New System.Windows.Forms.Button()
        Me.cmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtCp
        '
        Me.txtCp.Location = New System.Drawing.Point(12, 32)
        Me.txtCp.Mask = "00000"
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(141, 20)
        Me.txtCp.TabIndex = 135
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnter.ForeColor = System.Drawing.Color.Red
        Me.lblEnter.Location = New System.Drawing.Point(153, 35)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(91, 15)
        Me.lblEnter.TabIndex = 137
        Me.lblEnter.Text = "Obtener Datos"
        Me.lblEnter.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "CODIGO POSTAL"
        '
        'cmbColoniaId
        '
        Me.cmbColoniaId.FormattingEnabled = True
        Me.cmbColoniaId.Location = New System.Drawing.Point(368, 159)
        Me.cmbColoniaId.Name = "cmbColoniaId"
        Me.cmbColoniaId.Size = New System.Drawing.Size(74, 21)
        Me.cmbColoniaId.TabIndex = 144
        Me.cmbColoniaId.Visible = False
        '
        'cmbMunicipioId
        '
        Me.cmbMunicipioId.FormattingEnabled = True
        Me.cmbMunicipioId.Location = New System.Drawing.Point(368, 107)
        Me.cmbMunicipioId.Name = "cmbMunicipioId"
        Me.cmbMunicipioId.Size = New System.Drawing.Size(74, 21)
        Me.cmbMunicipioId.TabIndex = 143
        Me.cmbMunicipioId.Visible = False
        '
        'cmbColonia
        '
        Me.cmbColonia.FormattingEnabled = True
        Me.cmbColonia.Location = New System.Drawing.Point(12, 134)
        Me.cmbColonia.Name = "cmbColonia"
        Me.cmbColonia.Size = New System.Drawing.Size(430, 21)
        Me.cmbColonia.TabIndex = 138
        '
        'cmbEstadoId
        '
        Me.cmbEstadoId.FormattingEnabled = True
        Me.cmbEstadoId.Location = New System.Drawing.Point(141, 107)
        Me.cmbEstadoId.Name = "cmbEstadoId"
        Me.cmbEstadoId.Size = New System.Drawing.Size(74, 21)
        Me.cmbEstadoId.TabIndex = 142
        Me.cmbEstadoId.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(234, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "MUNICIPIO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "ESTADO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "COLONIA"
        '
        'obtenerCpCmd
        '
        Me.obtenerCpCmd.BackColor = System.Drawing.SystemColors.Control
        Me.obtenerCpCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.obtenerCpCmd.Image = Global.sidep.My.Resources.Resources._16__Spelling_
        Me.obtenerCpCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.obtenerCpCmd.Location = New System.Drawing.Point(12, 161)
        Me.obtenerCpCmd.Name = "obtenerCpCmd"
        Me.obtenerCpCmd.Size = New System.Drawing.Size(203, 27)
        Me.obtenerCpCmd.TabIndex = 147
        Me.obtenerCpCmd.Text = "Obtener Datos"
        Me.obtenerCpCmd.UseVisualStyleBackColor = False
        '
        'cmbMunicipio
        '
        Me.cmbMunicipio.FormattingEnabled = True
        Me.cmbMunicipio.Location = New System.Drawing.Point(237, 86)
        Me.cmbMunicipio.Name = "cmbMunicipio"
        Me.cmbMunicipio.Size = New System.Drawing.Size(205, 21)
        Me.cmbMunicipio.TabIndex = 149
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(12, 85)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(203, 21)
        Me.cmbEstado.TabIndex = 148
        '
        'buscarDireccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(446, 192)
        Me.Controls.Add(Me.cmbMunicipio)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.obtenerCpCmd)
        Me.Controls.Add(Me.cmbColoniaId)
        Me.Controls.Add(Me.cmbMunicipioId)
        Me.Controls.Add(Me.cmbColonia)
        Me.Controls.Add(Me.cmbEstadoId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCp)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.Label11)
        Me.Name = "buscarDireccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Direccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCp As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbColoniaId As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMunicipioId As System.Windows.Forms.ComboBox
    Friend WithEvents cmbColonia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstadoId As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents obtenerCpCmd As System.Windows.Forms.Button
    Friend WithEvents cmbMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
End Class
