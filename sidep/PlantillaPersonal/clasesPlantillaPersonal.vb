Imports datosCompartidos.Datos.BaseDatos
Imports datosCompartidos.Datos

Namespace PlantillaPersonal

    Public Class CentroTrabajo

        Public IdCT As Integer
        Public Nombre As String
        Public IdTurno As String
        Public Telefono As String
        Public IdMunicipio As String
        Public IdLocalidad As String
        Public Domicilio As String
        Public IdCodigoPostal As String

        Public Sub New(ByVal idct As Integer, _
                       ByVal nombre As String, _
                       ByVal idturno As Integer, _
                       ByVal telefono As String, _
                       ByVal idmunicipio As Integer, _
                       ByVal idlocalidad As String, _
                       ByVal domicilio As String, _
                       ByVal idcodigopostal As Integer)

            Me.IdCT = idct
            Me.Nombre = nombre
            Me.IdTurno = idturno
            Me.Telefono = telefono
            Me.IdMunicipio = idlocalidad
            Me.Domicilio = domicilio
            Me.IdCodigoPostal = idcodigopostal

        End Sub

    End Class

    Public Class PlantillaPersonal

        Public Function getMunicipios() As DataSet

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "select id_municipio, nombre from municipio where ID_ESTADO = 6"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            Return ds

        End Function

        Public Shared Sub loadDiasSemana(ByRef Combo As ComboBox)

            Dim dt As New DataTable
            dt.Columns.Add("key", GetType(Integer))
            dt.Columns.Add("display", GetType(String))

            dt.Rows.Add("1", "LUNES")
            dt.Rows.Add("2", "MARTES")
            dt.Rows.Add("3", "MIERCOLES")
            dt.Rows.Add("4", "JUEVES")
            dt.Rows.Add("5", "VIERNES")

            'Combo.Items.Clear()
            Combo.DataSource = dt
            Combo.ValueMember = "key"
            Combo.DisplayMember = "display"

            dt = Nothing

        End Sub

        Public Shared Function getMaterias(ByVal IdNivel As String) As DataSet

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "select id_materia, upper(materia) + ' - A: ' + upper(isnull(agrupacion,'')) + ' - G: ' + isnull(cast (id_grado as varchar(20)),'0') as materia " & _
                "from materias " & _
                "where id_nivel = '" & IdNivel & "' " & _
                "order by materia;"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            Return ds

        End Function
        Public Shared Function getLicenciaturas() As DataSet

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "select idLicenciatura, upper(nombre) as licenciatura " & _
                "from licenciaturas; "

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            Return ds

        End Function
        Public Shared Function getEspecialidades() As DataSet

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "select idEspecialidad, upper(nombre) as especialidad " & _
                "from especialidades; "

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            Return ds

        End Function
        Public Shared Function getGrados() As DataSet

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "select idGrado, upper(descripcion) as grado " & _
                "from grados; "

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            Return ds

        End Function
        Public Shared Function getGrupos(ByVal idGrado As Integer) As DataSet

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "select idGrupo, upper(descripcion) as grupo " & _
                "from grupos where idGrado= " & idGrado & "; "

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            Return ds

        End Function
        Public Shared Function getMaestros(ByVal idCT As Integer) As DataSet

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "select p.Id_Personal, (rtrim(ltrim(p.Nombre)) + ' ' + p.Apellido_Paterno + ' ' + p.Apellido_Paterno) as nombre " & _
                "from plantillas PL inner join Personal P on PL.idPersonal=P.Id_Personal where PL.idCCT=" & idCT & " " & _
                "order by p.Nombre,p.Apellido_Paterno,P.Apellido_Materno"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            Return ds

        End Function
        Public Shared Function getCT(ByVal IdNivel As String) As DataSet

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "select * " & _
                "from CT " & _
                "where idNivel = '" & IdNivel & "' " & _
                "order by nombre;"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            Return ds

        End Function
        Public Shared Sub addMateria(ByVal IdNivel As String, ByVal NuevaMateria As String)

            Dim b As New BaseDatos
            Dim sql As String

            NuevaMateria = b.SafeSqlLiteral(NuevaMateria)

            sql = "insert into materias(materia, horas, agrupacion, id_nivel, id_grado) " & _
                "values('" & NuevaMateria & "', '0', NULL, '" & IdNivel & "', NULL);"

            b.abrirConexion()
            b.ejecutarComando(sql)
            b.cerrarConexion()

            b = Nothing

        End Sub
        Public Shared Sub addFuncion(ByVal nuevaFuncion As String)

            Dim b As New BaseDatos
            Dim sql As String

            nuevaFuncion = b.SafeSqlLiteral(nuevaFuncion)

            sql = "insert into funciones(Descripcion) " & _
                "values('" & nuevaFuncion & "');"

            b.abrirConexion()
            b.ejecutarComando(sql)
            b.cerrarConexion()

            b = Nothing

        End Sub

        Public Shared Sub addHorario(ByVal IdPlantilla As String, _
                                     ByVal idMateria As String, _
                                     ByVal Grado As String, _
                                     ByVal Grupo As String, _
                                     ByVal HoraInicio As String, _
                                     ByVal HoraFin As String, _
                                     ByVal Dia As String)

            Dim b As New BaseDatos
            Dim sql As String = ""

            sql = "insert into horarios(idPlantilla, idMateria, Grado, Grupo, horaInicio, horaFin, dia) " & _
                "values('" & b.SafeSqlLiteral(IdPlantilla) & "', " & _
                "'" & b.SafeSqlLiteral(idMateria) & "', " & _
                "'" & b.SafeSqlLiteral(Grado) & "', " & _
                "'" & b.SafeSqlLiteral(Grupo) & "', " & _
                "'" & b.SafeSqlLiteral(HoraInicio) & "', " & _
                "'" & b.SafeSqlLiteral(HoraFin) & "', " & _
                "'" & b.SafeSqlLiteral(Dia) & "');"

            b.abrirConexion()
            b.ejecutarComando(sql)
            b.cerrarConexion()

            b = Nothing

        End Sub

        Public Shared Function getHorario(ByVal IdPlantilla As String) As DataSet

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String = ""

            sql = "select " & _
                    "h.idHorario, h.idPlantilla, h.idMateria, m.materia, h.Grado, h.Grupo, " & _
                    "h.horaInicio, h.horaFin, h.dia " & _
                    "from horarios h " & _
                    "inner join materias m on m.id_materia = h.idMateria " & _
                    "and h.idPlantilla = '" & IdPlantilla & "' " & _
                    "order by horaInicio,dia;"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            b = Nothing

            Return ds

        End Function

        Public Shared Sub quitarHora(ByVal IdHorario As String)

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String = ""

            sql = "delete from horarios where idHorario = '" & IdHorario & "';"

            b.abrirConexion()
            b.ejecutarComando(sql)
            b.cerrarConexion()

            b = Nothing

        End Sub

        Public Shared Function existeHorario(ByVal HoraInicio As String, ByVal Dia As String, ByVal idplantilla As String) As Boolean

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String = ""

            sql = "select idHorario from horarios " & _
                "where horaInicio = '" & HoraInicio & "' " & _
                "and dia = '" & Dia & "' and idplantilla=" & idplantilla & ";"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            b = Nothing

            If ds.Tables(0).Rows.Count = 0 Then
                Return False
            End If

            Return True
        End Function

    End Class

End Namespace
