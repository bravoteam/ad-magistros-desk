Imports datosCompartidos.Datos
Imports System.Data.SqlClient

Module procedimientos
    Public Function NEncontrados(ByVal DondeBuscar As String, ByVal Buscado As String) As Integer
        Dim Encon As Integer
        Dim Busq As Integer
        Dim DondeHay As Integer
        Encon = 0
        For Busq = 1 To Len(DondeBuscar)
            DondeHay = InStr(Busq, DondeBuscar, Buscado)
            If Not DondeHay = 0 Then
                Encon = Encon + 1
                Busq = DondeHay
            End If
        Next
        NEncontrados = Encon
    End Function
    Public Function obtenerEstado(ByVal id As Integer) As String
        Dim estado As String = ""
        variables.conexion.abrirConexion()
        variables.sql = "SELECT * from estados where Id=" & id & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            estado = variables.SQLdr2("NOMBRE").ToString
        End While
        variables.conexion.cerrarConexion()
        Return estado
    End Function
    Public Function obtenerPuesto(ByVal id As Integer) As String
        Dim puesto As String = ""
        variables.conexion.abrirConexion()
        variables.sql = "SELECT * from puestos where idPuesto=" & id & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            puesto = variables.SQLdr2("Descripcion").ToString
        End While
        variables.conexion.cerrarConexion()
        Return puesto
    End Function
    Public Function obtenerFuncion(ByVal id As Integer) As String
        Dim funcion As String = ""
        variables.conexion.abrirConexion()
        variables.sql = "SELECT * from funciones where idFuncion=" & id & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            funcion = variables.SQLdr2("Descripcion").ToString
        End While
        variables.conexion.cerrarConexion()
        Return funcion
    End Function
    Public Function obtenerMunicipio(ByVal id As Integer) As String
        Dim municipio As String = ""
        variables.conexion.abrirConexion()
        'variables.sql = "SELECT m.nombre as NOMBRE from municipio M INNER JOIN localidad L ON L.id_municipio=M.id_municipio  where L.id_localidad=" & id & ""
        variables.sql = "SELECT m.nombre as NOMBRE from municipio M  where M.id_municipio=" & id & ""

        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            municipio = variables.SQLdr2("NOMBRE").ToString
        End While
        variables.conexion.cerrarConexion()
        Return municipio
    End Function
    Public Function obtenerLocalidad(ByVal id As Integer) As String
        Dim municipio As String = ""
        variables.conexion.abrirConexion()
        variables.sql = "SELECT M.nombre as NOMBRE from municipio M inner join localidad L ON " & _
            "L.id_municipio=M.id_municipio where L.id_localidad=" & id & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            municipio = variables.SQLdr2("NOMBRE").ToString
        End While
        variables.conexion.cerrarConexion()
        Return municipio
    End Function
    Public Function obtenerColonia(ByVal id As Integer) As modelos.modeloCP
        Dim _m As New modelos.modeloCP
        variables.conexion.abrirConexion()
        variables.sql = "SELECT * from colonia where id_colonia=" & id & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        _m.idCP = 0
        _m.nombreColonia = ""
        While (variables.SQLdr2.Read())
            _m.nombreColonia = variables.SQLdr2("NOMBRE").ToString
            _m.idCP = variables.SQLdr2("id_codigo_postal")
        End While
        variables.conexion.cerrarConexion()
        Return _m
    End Function
    Public Function obtenerCP(ByVal id As Integer) As String
        Dim cp As String = ""
        variables.conexion.abrirConexion()
        variables.sql = "SELECT * from codigo_postal where id_codigo_postal=" & id & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            cp = variables.SQLdr2("id_cp").ToString
        End While
        variables.conexion.cerrarConexion()
        Return cp
    End Function
    Public Function obtenerCPBC(ByVal id As Integer) As String
        Dim cp As String = ""
        variables.conexion.abrirConexion()
        variables.sql = "select * from colonia C inner join " & _
                        "codigo_postal CP on CP.id_codigo_postal=C.id_codigo_postal " & _
                        "where C.id_colonia=" & id & ""

        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            cp = variables.SQLdr2("id_cp").ToString
        End While
        variables.conexion.cerrarConexion()
        Return cp
    End Function
    Public Function obtenerDireccion(ByVal cp As String) As modelos.modeloDireccion
        Dim _m As New modelos.modeloDireccion
        variables.conexion.abrirConexion()
        variables.sql = "select top 1 cp.id_codigo_postal, " & _
            "cp.id_cp as 'cp', cp.id_municipio, " & _
            "c.id_colonia, c.nombre, m.NOMBRE, e.ID_ESTADO, e.NOMBRE from codigo_postal cp " & _
            "inner join colonia c on c.id_codigo_postal = cp.id_codigo_postal " & _
            "inner join municipio m on m.ID_MUNICIPIO = cp.id_municipio " & _
            "inner join estados e on e.ID_ESTADO = m.ID_ESTADO where cp.id_cp = '" & cp & "'"
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            _m.idColonia = variables.SQLdr2(3)
            _m.idCP = variables.SQLdr2(0)
            _m.idEstado = variables.SQLdr2(6)
            _m.idLocalidad = variables.SQLdr2(2)
            _m.nombreColonia = variables.SQLdr2(4).ToString
            _m.nombreCP = variables.SQLdr2("cp").ToString
            _m.nombreEstado = variables.SQLdr2(7).ToString
            _m.nombreMunicipio = variables.SQLdr2(5).ToString
        End While
        variables.conexion.cerrarConexion()
        Return _m
    End Function
    Public Function obtenerPersonal(ByVal idPersonal As Integer) As modelos.modeloPersonal
        Dim _m As New modelos.modeloPersonal
        variables.conexion.abrirConexion()
        variables.sql = "select Ficha,Nombre,apellido_paterno,apellido_materno " & _
                        "from personal where Id_Personal= " & idPersonal & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            _m.Ficha = variables.SQLdr2(0).ToString
            _m.Nombre = variables.SQLdr2(1).ToString
            _m.Apellido_Paterno = variables.SQLdr2(2).ToString
            _m.Apellido_Materno = variables.SQLdr2(3).ToString
            
        End While
        variables.conexion.cerrarConexion()
        Return _m
    End Function
    
    Public Function ObtenerTurno(ByVal idT As Integer) As String
        Dim turno As String = ""
        variables.conexion.abrirConexion()
        variables.sql = "SELECT descripcion from turnos where idTurno=" & idT & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        turno = cmd.ExecuteScalar
        variables.conexion.cerrarConexion()
        Return turno
    End Function
    Public Function validarUsuario(ByVal user As String, ByVal pass As String) As Boolean
        Dim res As Boolean = False
        variables.conexion.abrirConexion()
        variables.sql = "SELECT * from usuarios where usuario='" & user & "' and password='" & pass & "'"
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            variables.usuario = variables.SQLdr2("usuario").ToString
            variables.idUsuario = variables.SQLdr2("idUsuario")
            res = True
        End While
        variables.conexion.cerrarConexion()
        Return res
    End Function
    Public Sub obtenerListadoCts()
        Dim i As Integer = 0
        variables.conexion.abrirConexion()
        variables.sql = "SELECT * from perfilesCt where idUsuario=" & variables.idUsuario & " "
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        ReDim variables.array(variables.SQLdr2.FieldCount)

        While (variables.SQLdr2.Read())
            variables.array(i) = variables.SQLdr2("idCCt")
            i = i + 1
        End While
        variables.conexion.cerrarConexion()
    End Sub
    Public Function obtenerNivel(ByVal id As Integer) As String
        Dim valor As String = ""
        variables.conexion.abrirConexion()
        variables.sql = "select * " & _
                        "from niveles where idNivel= " & id & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            valor = variables.SQLdr2(1).ToString
        End While
        variables.conexion.cerrarConexion()
        Return valor
    End Function
End Module
