Public Class ImpresionCT_Desgloce

    Private Sub ImpresionCT_Desgloce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'plantillas.horarioCT' table. You can move, or remove it, as needed.
        Me.horarioCTTableAdapter.Fill(Me.plantillas.horarioCT, variables.idCCT)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class