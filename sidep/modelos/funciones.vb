Imports datosCompartidos.Datos

Public Class funciones
    Public Shared Sub loadComboBox(ByRef ds As DataSet, _
                           ByRef combo As ComboBox, _
                           ByRef campoValor As String, _
                           ByRef campoDisplay As String)
        combo.DataSource = ds.Tables(0)
        combo.ValueMember = campoValor
        combo.DisplayMember = campoDisplay
    End Sub
    Public Shared Function getCiclos() As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        sql = "select idCicloEscolar, descripcion " & _
            "from cicloescolar; "

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds

    End Function
End Class
