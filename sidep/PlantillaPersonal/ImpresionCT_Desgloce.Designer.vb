<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpresionCT_Desgloce
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.horarioCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.plantillas = New sidep.plantillas()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.horarioCTTableAdapter = New sidep.plantillasTableAdapters.horarioCTTableAdapter()
        CType(Me.horarioCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plantillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'horarioCTBindingSource
        '
        Me.horarioCTBindingSource.DataMember = "horarioCT"
        Me.horarioCTBindingSource.DataSource = Me.plantillas
        '
        'plantillas
        '
        Me.plantillas.DataSetName = "plantillas"
        Me.plantillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.horarioCTBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sidep.HORARIOCT_DESGLOCE.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(982, 588)
        Me.ReportViewer1.TabIndex = 0
        '
        'horarioCTTableAdapter
        '
        Me.horarioCTTableAdapter.ClearBeforeFill = True
        '
        'ImpresionCT_Desgloce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 588)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ImpresionCT_Desgloce"
        Me.Text = "ImpresionCT_Desgloce"
        CType(Me.horarioCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plantillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents horarioCTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents plantillas As sidep.plantillas
    Friend WithEvents horarioCTTableAdapter As sidep.plantillasTableAdapters.horarioCTTableAdapter
End Class
