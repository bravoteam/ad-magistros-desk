Public Class ImpresionCargaHoraria

    Private Sub ImpresionCargaHoraria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'plantillas.plantilla' table. You can move, or remove it, as needed.
        Me.plantillaTableAdapter.Fill(Me.plantillas.plantilla, variables.idCCT)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class