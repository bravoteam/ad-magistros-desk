Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class imprimirPlantillaFrm

    Private Sub imprimirPlantillaFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'plantillas.estadisticasMaestros' table. You can move, or remove it, as needed.
        Me.estadisticasMaestrosTableAdapter.Fill(Me.plantillas.estadisticasMaestros, variables.idCCT)
        'TODO: This line of code loads data into the 'plantillas.plantilla' table. You can move, or remove it, as needed.
        Me.plantillaTableAdapter.Fill(Me.plantillas.plantilla, variables.idCCT)
        'TODO: This line of code loads data into the 'plantillas.estadisticas_CCT' table. You can move, or remove it, as needed.
        Me.estadisticas_CCTTableAdapter.Fill(Me.plantillas.estadisticas_CCT, variables.idCCT)
        Dim parameters As New ReportParameter
        parameters = New ReportParameter("cicloEscolar", Trim(variables.CicloEscolar))
        Me.ReportViewer1.LocalReport.SetParameters(parameters)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        pdf()
    End Sub
    Private Sub pdf()
        Dim deviceInfo As String
        'Dim lr As New Microsoft.Reporting.WinForms.LocalReport
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim bytes As Byte()
        deviceInfo = "<DeviceInfo>" +
        "<OutputFormat>PDF</OutputFormat>" +
        "  <PageWidth>35.56cm</PageWidth>" +
        "  <PageHeight>21.59cm</PageHeight>" +
        "  <MarginTop>1cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>1.5cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "plantilla.rdlc"
            Dim fs As New FileStream("C:\" & "plantilla" & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            Process.Start("C:\" & "plantilla" & ".pdf")

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
End Class