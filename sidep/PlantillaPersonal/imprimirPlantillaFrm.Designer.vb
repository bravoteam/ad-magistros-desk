<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimirPlantillaFrm
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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.plantillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.plantillas = New sidep.plantillas()
        Me.estadisticas_CCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.plantillaTableAdapter = New sidep.plantillasTableAdapters.plantillaTableAdapter()
        Me.estadisticas_CCTTableAdapter = New sidep.plantillasTableAdapters.estadisticas_CCTTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.plantillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plantillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadisticas_CCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        'estadisticas_CCTBindingSource
        '
        Me.estadisticas_CCTBindingSource.DataMember = "estadisticas_CCT"
        Me.estadisticas_CCTBindingSource.DataSource = Me.plantillas
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.plantillaBindingSource
        ReportDataSource6.Name = "DataSet2"
        ReportDataSource6.Value = Me.estadisticas_CCTBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sidep.plantilla.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1187, 558)
        Me.ReportViewer1.TabIndex = 0
        '
        'plantillaTableAdapter
        '
        Me.plantillaTableAdapter.ClearBeforeFill = True
        '
        'estadisticas_CCTTableAdapter
        '
        Me.estadisticas_CCTTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1187, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'imprimirPlantillaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 582)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "imprimirPlantillaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Plantilla"
        CType(Me.plantillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plantillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadisticas_CCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents plantillaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents plantillas As sidep.plantillas
    Friend WithEvents estadisticas_CCTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents plantillaTableAdapter As sidep.plantillasTableAdapters.plantillaTableAdapter
    Friend WithEvents estadisticas_CCTTableAdapter As sidep.plantillasTableAdapters.estadisticas_CCTTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
