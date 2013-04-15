Imports System.Data.SqlClient
Imports System.Linq
Imports datosCompartidos.Datos
Imports System.IO

Module funcionesLocales
    Public Function traerUltimoPersonal() As modelos.modeloPersonal
        Dim modelo As New modelos.modeloPersonal
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from Personal order by Id_Personal DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.Apellido_Materno = variables.SQLdr("Apellido_Materno").ToString
                modelo.Apellido_Paterno = variables.SQLdr("Apellido_Paterno").ToString
                modelo.Celular = variables.SQLdr("Celular").ToString
                modelo.CURP = variables.SQLdr("CURP").ToString
                modelo.Domicilio = variables.SQLdr("Domicilio").ToString
                modelo.Ficha = variables.SQLdr("Ficha").ToString
                modelo.Id_Colonia = variables.SQLdr("Id_Colonia")
                modelo.Id_estado = variables.SQLdr("Id_estado")
                modelo.Id_Localidad = variables.SQLdr("Id_Localidad")
                modelo.Id_Personal = variables.SQLdr("Id_Personal")
                modelo.Nombre = variables.SQLdr("Nombre").ToString
                modelo.numExt = variables.SQLdr("numExt").ToString
                modelo.numInt = variables.SQLdr("numInt").ToString
                modelo.Telefono = variables.SQLdr("Telefono").ToString
                modelo.nivelMaximo = variables.SQLdr("nivelMaximo").ToString
                modelo.preparacion = variables.SQLdr("preparacion").ToString

                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Function traerPersonal(ByVal id As Integer) As modelos.modeloPersonal
        Dim modelo As New modelos.modeloPersonal
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from Personal where  Id_Personal =" & id & ""
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.Apellido_Materno = variables.SQLdr("Apellido_Materno").ToString
                modelo.Apellido_Paterno = variables.SQLdr("Apellido_Paterno").ToString
                modelo.Celular = variables.SQLdr("Celular").ToString
                modelo.CURP = variables.SQLdr("CURP").ToString
                modelo.Domicilio = variables.SQLdr("Domicilio").ToString
                modelo.Ficha = variables.SQLdr("Ficha").ToString
                modelo.Id_Colonia = variables.SQLdr("Id_Colonia")
                modelo.Id_estado = variables.SQLdr("Id_estado")
                modelo.Id_Localidad = variables.SQLdr("Id_Localidad")
                modelo.Id_Personal = variables.SQLdr("Id_Personal")
                modelo.Nombre = variables.SQLdr("Nombre").ToString
                modelo.numExt = variables.SQLdr("numExt").ToString
                modelo.numInt = variables.SQLdr("numInt").ToString
                modelo.Telefono = variables.SQLdr("Telefono").ToString
                modelo.nivelMaximo = variables.SQLdr("nivelMaximo").ToString
                modelo.preparacion = variables.SQLdr("preparacion").ToString
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Function traerPlantilla(ByVal id As Integer) As modelos.modeloPlantilla
        Dim modelo As New modelos.modeloPlantilla
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from plantillas where  idPlantilla =" & id & ""
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.idFuncion = variables.SQLdr("idFuncion")
                modelo.idPuesto = variables.SQLdr("idPuesto")
                modelo.HA = variables.SQLdr("HA").ToString
                modelo.HD = variables.SQLdr("HD").ToString
                modelo.HG = variables.SQLdr("HG").ToString
                modelo.grados = variables.SQLdr("grados").ToString
                modelo.grupos = variables.SQLdr("grupos").ToString
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function

    Public Sub guardarPersonal(ByVal modelo As modelos.modeloPersonal)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into Personal(Apellido_Paterno,Apellido_Materno,Nombre,Id_estado," & _
                "CURP,Domicilio,numInt,numExt,Id_Colonia,Id_Localidad,Telefono,Celular,Ficha,nivelMaximo,preparacion)" & _
                         "values (@Apellido_Paterno,@Apellido_Materno,@Nombre,@Id_estado," & _
                "@CURP,@Domicilio,@numInt,@numExt,@Id_Colonia,@Id_Localidad,@Telefono,@Celular,@Ficha,@nivelMaximo,@preparacion) SELECT SCOPE_IDENTITY()"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@Apellido_Paterno", modelo.Apellido_Paterno)
                .Parameters.AddWithValue("@Apellido_Materno", modelo.Apellido_Materno)
                .Parameters.AddWithValue("@Nombre", modelo.Nombre)
                .Parameters.AddWithValue("@Id_estado", modelo.Id_estado)
                .Parameters.AddWithValue("@CURP", modelo.CURP)
                .Parameters.AddWithValue("@Domicilio", modelo.Domicilio)
                .Parameters.AddWithValue("@numInt", modelo.numInt)
                .Parameters.AddWithValue("@numExt", modelo.numExt)
                .Parameters.AddWithValue("@Id_Colonia", modelo.Id_Colonia)
                .Parameters.AddWithValue("@Id_Localidad", modelo.Id_Localidad)
                .Parameters.AddWithValue("@Telefono", modelo.Telefono)
                .Parameters.AddWithValue("@Celular", modelo.Celular)
                .Parameters.AddWithValue("@Ficha", modelo.Ficha)
                .Parameters.AddWithValue("@nivelMaximo", modelo.nivelMaximo)
                .Parameters.AddWithValue("@preparacion", modelo.preparacion)
            End With
            Dim idRegistro As Integer = 0
            idRegistro = Convert.ToInt32(cmd.ExecuteScalar())
            ' cmd.ExecuteNonQuery()
            insertaBitacora("GUARDA PERSONAL", variables.usuario, variables.idUsuario, 0, frmPlantillaPersonal.txtNombreCT.Text, _
                            idRegistro, modelo.Nombre & " " & modelo.Apellido_Paterno & " " & modelo.Apellido_Materno, _
                            0, 0, 0, "NIVEL: " & modelo.nivelMaximo & " - PREPARACION: " & modelo.preparacion)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarPersonal(ByVal modelo As modelos.modeloPersonal)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE Personal SET Apellido_Paterno=@Apellido_Paterno,Apellido_Materno=@Apellido_Materno,Nombre=@Nombre," & _
                "Id_estado=@Id_estado,CURP=@CURP,Domicilio=@Domicilio,numInt=@numInt,numExt=@numExt,Id_Colonia=@Id_Colonia,Id_Localidad=@Id_Localidad," & _
                "Telefono=@Telefono,Celular=@Celular,Ficha=@Ficha,nivelMaximo=@nivelMaximo,preparacion=@preparacion WHERE Id_Personal = @Id_Personal"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@Apellido_Paterno", modelo.Apellido_Paterno)
                .Parameters.AddWithValue("@Apellido_Materno", modelo.Apellido_Materno)
                .Parameters.AddWithValue("@Nombre", modelo.Nombre)
                .Parameters.AddWithValue("@Id_estado", modelo.Id_estado)
                .Parameters.AddWithValue("@CURP", modelo.CURP)
                .Parameters.AddWithValue("@Domicilio", modelo.Domicilio)
                .Parameters.AddWithValue("@numInt", modelo.numInt)
                .Parameters.AddWithValue("@numExt", modelo.numExt)
                .Parameters.AddWithValue("@Id_Colonia", modelo.Id_Colonia)
                .Parameters.AddWithValue("@Id_Localidad", modelo.Id_Localidad)
                .Parameters.AddWithValue("@Telefono", modelo.Telefono)
                .Parameters.AddWithValue("@Celular", modelo.Celular)
                .Parameters.AddWithValue("@Ficha", modelo.Ficha)
                .Parameters.AddWithValue("@Id_Personal", modelo.Id_Personal)
                .Parameters.AddWithValue("@nivelMaximo", modelo.nivelMaximo)
                .Parameters.AddWithValue("@preparacion", modelo.preparacion)
            End With
            cmd.ExecuteNonQuery()
            insertaBitacora("ACTUALIZA PERSONAL", variables.usuario, variables.idUsuario, 0, frmPlantillaPersonal.txtNombreCT.Text, _
                            modelo.Id_Personal, modelo.Nombre & " " & modelo.Apellido_Paterno & " " & modelo.Apellido_Materno, _
                            0, 0, 0, "NIVEL: " & modelo.nivelMaximo & " - PREPARACION: " & modelo.preparacion)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub guardarPlantilla(ByVal modelo As modelos.modeloPlantilla)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into plantillas(idPersonal,idCCT,idCicloEscolar,idPuesto," & _
                "idFuncion,HG,HD,HA,GradoS,Grupos,captura,revisa,fechaCaptura,fechaRevision,usuario)" & _
                         "values (@idPersonal,@idCCT,@idCicloEscolar,@idPuesto," & _
                "@idFuncion,@HG,@HD,@HA,@idGrado,@idGrupo,@captura,@revisa,@fechaCaptura,@fechaRevision,@usuario)"


            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idPersonal", modelo.idPersonal)
                .Parameters.AddWithValue("@idCCT", modelo.idCCT)
                .Parameters.AddWithValue("@idCicloEscolar", modelo.idCicloEscolar)
                .Parameters.AddWithValue("@idPuesto", modelo.idPuesto)
                .Parameters.AddWithValue("@idFuncion", modelo.idFuncion)
                .Parameters.AddWithValue("@HG", modelo.HG)
                .Parameters.AddWithValue("@HD", modelo.HD)
                .Parameters.AddWithValue("@HA", modelo.HA)
                .Parameters.AddWithValue("@idGrado", modelo.grados)
                .Parameters.AddWithValue("@idGrupo", modelo.grupos)
                .Parameters.AddWithValue("@captura", modelo.captura)
                .Parameters.AddWithValue("@revisa", modelo.revisa)
                .Parameters.AddWithValue("@fechaCaptura", modelo.fechaCaptura)
                .Parameters.AddWithValue("@fechaRevision", modelo.fechaRevision)
                .Parameters.AddWithValue("@usuario", variables.usuario)
            End With

            cmd.ExecuteNonQuery()
            'MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
            insertaBitacora("INSERTA PLANTILLA", variables.usuario, variables.idUsuario, modelo.idCCT, frmPlantillaPersonal.txtNombreCT.Text, _
                            modelo.idPersonal, addPersonal.txtNombre.Text & " " & addPersonal.txtApellidoPaterno.Text & " " & addPersonal.txtApellidoMaterno.Text, _
                            modelo.idPlantilla, 0, 0, "CICLO ESCOLAR: " & modelo.idCicloEscolar & " - Funcion: " & addPersonal.cmbFuncion.Text & " - Puesto: " & addPersonal.cmbFuncion.Text)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarPlantilla(ByVal modelo As modelos.modeloPlantilla)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE plantillas SET idPersonal=@idPersonal,idCCT=@idCCT,idCicloEscolar=@idCicloEscolar," & _
                "idPuesto=@idPuesto,idFuncion=@idFuncion,HG=@HG,HD=@HD,HA=@HA,Grados=@idGrado,Grupos=@idGrupo," & _
                "captura=@captura,revisa=@revisa,fechaCaptura=@fechaCaptura," & _
                "fechaRevision=@fechaRevision WHERE idPlantilla=@idPlantilla"


            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idPersonal", modelo.idPersonal)
                .Parameters.AddWithValue("@idCCT", modelo.idCCT)
                .Parameters.AddWithValue("@idCicloEscolar", modelo.idCicloEscolar)
                .Parameters.AddWithValue("@idPuesto", modelo.idPuesto)
                .Parameters.AddWithValue("@idFuncion", modelo.idFuncion)
                .Parameters.AddWithValue("@HG", modelo.HG)
                .Parameters.AddWithValue("@HD", modelo.HD)
                .Parameters.AddWithValue("@HA", modelo.HA)
                .Parameters.AddWithValue("@idGrado", modelo.grados)
                .Parameters.AddWithValue("@idGrupo", modelo.grupos)
                .Parameters.AddWithValue("@captura", modelo.captura)
                .Parameters.AddWithValue("@revisa", modelo.revisa)
                .Parameters.AddWithValue("@fechaCaptura", modelo.fechaCaptura)
                .Parameters.AddWithValue("@fechaRevision", modelo.fechaRevision)
                .Parameters.AddWithValue("@idPlantilla", modelo.idPlantilla)

            End With

            cmd.ExecuteNonQuery()
            insertaBitacora("ACTUALIZA PLANTILLA", variables.usuario, variables.idUsuario, modelo.idCCT, frmPlantillaPersonal.txtNombreCT.Text, _
                            modelo.idPersonal, addPersonal.txtNombre.Text & " " & addPersonal.txtApellidoPaterno.Text & " " & addPersonal.txtApellidoMaterno.Text, _
                            modelo.idPlantilla, 0, 0, "CICLO ESCOLAR: " & modelo.idCicloEscolar & " - Funcion: " & addPersonal.cmbFuncion.Text & " - Puesto: " & addPersonal.cmbFuncion.Text)
            'MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub eliminarPlantilla(ByVal idPlantilla As Integer)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "delete from plantillas where idPlantilla = @idPlantilla; delete from horarios where idPlantilla = @idPlantilla;"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idPlantilla", idPlantilla)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("PLANTILLA ELIMINADA CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub eliminarPersonalS(ByVal idPlantilla As Integer)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "delete from pesonalSustituye where idPersonalSustituye = @idPlantilla"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idPlantilla", idPlantilla)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("ELIMINADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub insertaEliminacion(ByVal idPlantilla As Integer, ByVal idPersonal As Integer, ByVal datos As String, ByVal idUsuario As Integer, ByVal usuario As String, ByVal personal As String)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "INSERT INTO plantillaeliminada(idPlantilla,idPersonal,datos,idUsuario,usuario,personal,fecha)" & _
                                "VALUES(@idPlantilla,@idPersonal,@datos,@idUsuario,@usuario,@personal,@fecha)"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idPlantilla", idPlantilla)
                .Parameters.AddWithValue("@idPersonal", idPersonal)
                .Parameters.AddWithValue("@datos", datos)
                .Parameters.AddWithValue("@idUsuario", idUsuario)
                .Parameters.AddWithValue("@usuario", usuario)
                .Parameters.AddWithValue("@personal", personal)
                .Parameters.AddWithValue("@fecha", Now)
            End With

            cmd.ExecuteNonQuery()
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub insertaBitacora(ByVal accion As String, ByVal usuario As String, ByVal idUsuario As Integer, ByVal idCT As Integer, ByVal CT As String, _
                               ByVal idPersonal As Integer, ByVal personal As String, ByVal idPlantilla As Integer, ByVal idEstadistica As Integer, _
                               ByVal idHorario As Integer, ByVal descripcion As String)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "INSERT INTO bitacora(accion,usuario,idUsuario,idCT,CT,idPersonal,personal,idPlantilla,idEstadistica,idHorario,descripcion,fecha)" & _
                                "VALUES(@accion,@usuario,@idUsuario,@idCT,@CT,@idPersonal,@personal,@idPlantilla,@idEstadistica,@idHorario,@descripcion,@fecha)"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@accion", accion)
                .Parameters.AddWithValue("@usuario", usuario)
                .Parameters.AddWithValue("@idUsuario", idUsuario)
                .Parameters.AddWithValue("@idCT", idCT)
                .Parameters.AddWithValue("@CT", CT)
                .Parameters.AddWithValue("@idPersonal", idPersonal)
                .Parameters.AddWithValue("@personal", personal)
                .Parameters.AddWithValue("@idPlantilla", idPlantilla)
                .Parameters.AddWithValue("@idEstadistica", idEstadistica)
                .Parameters.AddWithValue("@idHorario", idHorario)
                .Parameters.AddWithValue("@descripcion", descripcion)
                .Parameters.AddWithValue("@fecha", Now)
            End With

            cmd.ExecuteNonQuery()
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Function traerUltimaPlantilla() As Integer
        Try
            Dim valor As Integer = 0
            variables.conexion.abrirConexion()
            variables.sql = "select * from plantillas order by idPlantilla DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                valor = variables.SQLdr("idPlantilla")
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return valor
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Sub guardarEstadistica(ByVal modelo As modelos.modeloEstadistica)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into estadisticas_CCT(idCt,idCicloEscolar,idGrado,nGrupos," & _
                "numHombres,numMujeres)" & _
                         "values (@idCt,@idCicloEscolar,@idGrado,@nGrupos," & _
                "@numHombres,@numMujeres) SELECT SCOPE_IDENTITY()"


            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idCt", modelo.idCt)
                .Parameters.AddWithValue("@idCicloEscolar", modelo.idCicloEscolar)
                .Parameters.AddWithValue("@idGrado", modelo.idGrado)
                .Parameters.AddWithValue("@nGrupos", modelo.nGrupos)
                .Parameters.AddWithValue("@numHombres", modelo.numHombres)
                .Parameters.AddWithValue("@numMujeres", modelo.numMujeres)
            End With
            Dim idRegistro As Integer = 0
            idRegistro = Convert.ToInt32(cmd.ExecuteScalar())
            'cmd.ExecuteNonQuery()
            insertaBitacora("AGREGAR ESTADISTICA", variables.usuario, variables.idUsuario, variables.idCCT, frmPlantillaPersonal.txtNombreCT.Text, _
                            0, "", 0, idRegistro, 0, "CICLO ESCOLAR: " & modelo.idCicloEscolar & " - GRADO: " & modelo.idGrado & " - GRUPOS: " & modelo.nGrupos & _
                            " - HOMBRES: " & modelo.numHombres & " - MUJERES: " & modelo.numMujeres)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarEstadistica(ByVal modelo As modelos.modeloEstadistica)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE estadisticas_CCT set idCt=@idCt,idCicloEscolar=@idCicloEscolar,idGrado=@idGrado,nGrupos=@nGrupos," & _
                "numHombres=@numHombres,numMujeres=@numMujeres where idEstadisticas=@idEstadisticas"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idCt", modelo.idCt)
                .Parameters.AddWithValue("@idCicloEscolar", modelo.idCicloEscolar)
                .Parameters.AddWithValue("@idGrado", modelo.idGrado)
                .Parameters.AddWithValue("@nGrupos", modelo.nGrupos)
                .Parameters.AddWithValue("@numHombres", modelo.numHombres)
                .Parameters.AddWithValue("@numMujeres", modelo.numMujeres)
                .Parameters.AddWithValue("@idEstadisticas", modelo.idEstadisticas)
            End With
            cmd.ExecuteNonQuery()
            insertaBitacora("ACTUALIZAR ESTADISTICA", variables.usuario, variables.idUsuario, variables.idCCT, frmPlantillaPersonal.txtNombreCT.Text, _
                            0, "", 0, modelo.idEstadisticas, 0, "CICLO ESCOLAR: " & modelo.idCicloEscolar & " - GRADO: " & modelo.idGrado & " - GRUPOS: " & modelo.nGrupos & _
                            " - HOMBRES: " & modelo.numHombres & " - MUJERES: " & modelo.numMujeres)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub modificarEstadistica(ByVal modelo As modelos.modeloEstadistica)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE estadisticas_CCT(idCt,idCicloEscolar,idGrado,nGrupos," & _
                "numHombres,numMujeres)" & _
                         "values (@idCt,@idCicloEscolar,@idGrado,@nGrupos," & _
                "@numHombres,@numMujeres) SELECT SCOPE_IDENTITY()"


            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idCt", modelo.idCt)
                .Parameters.AddWithValue("@idCicloEscolar", modelo.idCicloEscolar)
                .Parameters.AddWithValue("@idGrado", modelo.idGrado)
                .Parameters.AddWithValue("@nGrupos", modelo.nGrupos)
                .Parameters.AddWithValue("@numHombres", modelo.numHombres)
                .Parameters.AddWithValue("@numMujeres", modelo.numMujeres)
            End With
            Dim idRegistro As Integer = 0
            idRegistro = Convert.ToInt32(cmd.ExecuteScalar())
            'cmd.ExecuteNonQuery()
            insertaBitacora("AGREGAR ESTADISTICA", variables.usuario, variables.idUsuario, variables.idCCT, frmPlantillaPersonal.txtNombreCT.Text, _
                            0, "", 0, idRegistro, 0, "CICLO ESCOLAR: " & modelo.idCicloEscolar & " - GRADO: " & modelo.idGrado & " - GRUPOS: " & modelo.nGrupos & _
                            " - HOMBRES: " & modelo.numHombres & " - MUJERES: " & modelo.numMujeres)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Function obtenerEstadistica(ByVal idEstadistica As Integer) As modelos.modeloEstadistica
        Try
            Dim _m As New modelos.modeloEstadistica
            variables.conexion.abrirConexion()
            variables.sql = "select * from estadisticas_CCT where idEstadisticas=" & idEstadistica & " "
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                _m.idCicloEscolar = variables.SQLdr("idCicloEscolar")
                _m.idCt = variables.SQLdr("idCt")
                _m.idGrado = variables.SQLdr("idGrado")
                _m.nGrupos = variables.SQLdr("nGrupos")
                _m.numHombres = variables.SQLdr("numHombres")
                _m.numMujeres = variables.SQLdr("numMujeres")
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return _m
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Sub eliminarEstadistica(ByVal idEstadistica As Integer)
        Dim modelo As New modelos.modeloEstadistica
        Try
            modelo = obtenerEstadistica(idEstadistica)
            variables.conexion.abrirConexion()

            Dim sql As String = "delete from estadisticas_CCT where idEstadisticas = @idEstadisticas"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idEstadisticas", idEstadistica)
            End With

            cmd.ExecuteNonQuery()
            insertaBitacora("ELIMINAR ESTADISTICA", variables.usuario, variables.idUsuario, variables.idCCT, frmPlantillaPersonal.txtNombreCT.Text, _
                            0, "", 0, idEstadistica, 0, "CICLO ESCOLAR: " & modelo.idCicloEscolar & " - GRADO: " & modelo.idGrado & " - GRUPOS: " & modelo.nGrupos & _
                            " - HOMBRES: " & modelo.numHombres & " - MUJERES: " & modelo.numMujeres)
            MsgBox("ESTADISTICA ELIMINADA CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub guardarSustituye(ByVal modelo As modelos.modelosSustituye)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into pesonalSustituye(idPlantilla,idPersonal,idPersonalS,observaciones)" & _
                         "values (@idPlantilla,@idPersonal,@idPersonalS,@observaciones)"


            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idPlantilla", modelo.idPlantilla)
                .Parameters.AddWithValue("@idPersonal", modelo.idPersonal)
                .Parameters.AddWithValue("@idPersonalS", modelo.idPersonalS)
                .Parameters.AddWithValue("@observaciones", modelo.observaciones)
            End With

            cmd.ExecuteNonQuery()
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarSustituye(ByVal modelo As modelos.modelosSustituye)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE pesonalSustituye SET idPlantilla=@idPlantilla,idPersonal=@idPersonal,idPersonalS=@idPersonalS," & _
                "observaciones=@observaciones WHERE idPersonalSustituye=@idPersonalSustituye"


            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idPlantilla", modelo.idPlantilla)
                .Parameters.AddWithValue("@idPersonal", modelo.idPersonal)
                .Parameters.AddWithValue("@idPersonalS", modelo.idPersonalS)
                .Parameters.AddWithValue("@observaciones", modelo.observaciones)
                .Parameters.AddWithValue("@idPersonalSustituye", modelo.idPersonalSustituye)
            End With

            cmd.ExecuteNonQuery()
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub eliminarSustituye(ByVal idPersonalSustituye As Integer)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "delete from pesonalSustituye where idPersonalSustituye = @idPersonalSustituye"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idPersonalSustituye", idPersonalSustituye)
            End With

            cmd.ExecuteNonQuery()

        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub guardarMaterias(ByVal modelo As modelos.modeloMateria)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into materias(materia,horas,agrupacion,id_nivel," & _
                "id_grado)" & _
                         "values (@materia,@horas,@agrupacion,@id_nivel," & _
                "@id_grado)"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@materia", modelo.materia)
                .Parameters.AddWithValue("@horas", modelo.horas)
                .Parameters.AddWithValue("@agrupacion", modelo.agrupacion)
                .Parameters.AddWithValue("@id_nivel", modelo.id_nivel)
                .Parameters.AddWithValue("@id_grado", modelo.id_grado)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarMaterias(ByVal modelo As modelos.modeloMateria)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE materias SET materia=@materia,horas=@horas,agrupacion=@agrupacion,id_nivel=@id_nivel," & _
                "id_grado=@id_grado " & _
                         "where id_materia = @id_materia"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@materia", modelo.materia)
                .Parameters.AddWithValue("@horas", modelo.horas)
                .Parameters.AddWithValue("@agrupacion", modelo.agrupacion)
                .Parameters.AddWithValue("@id_nivel", modelo.id_nivel)
                .Parameters.AddWithValue("@id_grado", modelo.id_grado)
                .Parameters.AddWithValue("@id_materia", modelo.id_materia)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub eliminarMaterias(ByVal modelo As modelos.modeloMateria)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "DELETE  FROM materias where id_materia = @id_materia"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@id_materia", modelo.id_materia)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ELIMINADO CORRECTAMENTE", vbCritical)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Function traerUltimaMateria() As modelos.modeloMateria
        Dim modelo As New modelos.modeloMateria
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from materias order by id_materia DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.id_materia = Val(variables.SQLdr("id_materia").ToString)
                modelo.materia = Val(variables.SQLdr("materia").ToString)
                modelo.horas = Val(variables.SQLdr("horas").ToString)
                modelo.agrupacion = variables.SQLdr("agrupacion").ToString
                modelo.id_nivel = Val(variables.SQLdr("id_nivel").ToString)
                modelo.id_grado = variables.SQLdr("id_grado").ToString
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Function validarReceptor(ByVal GbxDatos As GroupBox) As Boolean
        Dim res As Boolean = True

        funcionesLocales.pintarControles(GbxDatos)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                If String.IsNullOrEmpty(ctl.Text) Then
                    If ctl.Name <> "txtidCampus" And ctl.Name <> "txtidMateria" And ctl.Name <> "especialidadTxt" Then
                        ctl.BackColor = Drawing.Color.Aqua()
                        res = False
                    End If
                End If
            End If
        Next ctl

        Return res
    End Function
    Public Function validarReceptorTabs(ByVal GbxDatos As TabPage) As Boolean
        Dim res As Boolean = True

        funcionesLocales.pintarControlesTabs(GbxDatos)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                If String.IsNullOrEmpty(ctl.Text) Then
                    If ctl.Name <> "txtNumInt" And ctl.Name <> "txtId" And ctl.Name <> "txtFicha" And ctl.Name <> "txtHAP" And ctl.Name <> "txtHD" And ctl.Name <> "txtTelefono" And ctl.Name <> "txtCelular" And ctl.Name <> "txtFG" Then
                        ctl.BackColor = Drawing.Color.Aqua()
                        MsgBox("Falta llenar: " & ctl.Name)
                        res = False
                    End If
                End If
            End If
        Next ctl

        Return res
    End Function
    Public Function validarFicha(ByVal ficha As Integer) As Boolean
        Dim nombre As String = ""
        Dim res As Boolean = True
        variables.conexion.abrirConexion()
        variables.sql = "SELECT * from personal where Ficha=" & ficha & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            nombre = variables.SQLdr2("Nombre").ToString
            res = False
        End While
        variables.conexion.cerrarConexion()
        Return res
    End Function
    Public Function validarPersonalEnPlantilla(ByVal idp As Integer, ByVal idCt As Integer, ByVal idCiclo As Integer) As Boolean
        Dim idplantilla As Integer = 0
        Dim res As Boolean = True
        variables.conexion.abrirConexion()
        variables.sql = "SELECT * from plantillas where idPersonal=" & idp & " AND idCCT =" & idCt & " and idCicloEscolar=" & idCiclo & " "
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            idplantilla = variables.SQLdr2("idplantilla")
            res = False
        End While
        variables.conexion.cerrarConexion()
        Return res
    End Function
    Public Sub pintarControles(ByVal GbxDatos As GroupBox)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                ctl.BackColor = Drawing.Color.White
            End If
        Next ctl
    End Sub
    Public Sub pintarControlesTabs(ByVal GbxDatos As TabPage)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                ctl.BackColor = Drawing.Color.White
            End If
        Next ctl
    End Sub
    Public Sub buscarXDescripcion(ByVal busqueda)
        variables.conexion.abrirConexion()
        'If variables.banderaAccion = "personal" Then
        variables.dt = variables.conexion.getDataSet("select * from Personal where ((LTRIM(RTRIM(nombre)) + ' ' + LTRIM(RTRIM(apellido_paterno)) + ' ' + LTRIM(RTRIM(apellido_materno))) like '%" + busqueda + "%') or (nombrecompletoAnt like '%" + busqueda + "%')  ORDER BY apellido_paterno,apellido_materno,nombre")
        'End If
        'If variables.banderaAccion = "buscarPersonalAdd" Then
        'variables.dt = variables.conexion.getDataSet("select * from Personal where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        'End If
        'If variables.banderaAccion = "personalS" Then
        ' variables.dt = variables.conexion.getDataSet("select * from Personal where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        'End If
    End Sub
    Public Sub leerXmlConfig(ByVal DG As DataGridView)
        Dim doc As XDocument

        doc = XDocument.Load("configuracion.xml")

        Dim qx = From xe In doc.Descendants.Elements("conexion") _
                 Select New With { _
                            .server = xe.Element("server").Value, _
                            .database = xe.Element("database").Value, _
                            .user = xe.Element("user").Value, _
                            .password = xe.Element("password").Value _
                            }

        DG.DataSource = qx.ToList

    End Sub


    Public Sub CopiarArchivo(ByVal ArchivoOrigen As String, ByVal ArchivoDestino As String)
        Dim Capturista As String = ""
        Dim TipoMedio As String = ""
        Dim Ambito As String = ""
        Dim TipoPrensa As String = ""
        Dim Nombre As String = ""

        Dim ImagenBD As String = ""
        Using source As New IO.FileStream(ArchivoOrigen, IO.FileMode.Open)
            Using target As New IO.FileStream(ArchivoDestino, IO.FileMode.Create)
                Const BUFFER_SIZE As Integer = 1024
                Dim buffer(BUFFER_SIZE - 1) As Byte
                Dim bytesRead As Integer = source.Read(buffer, 0, BUFFER_SIZE)

                While bytesRead > 0
                    target.Write(buffer, 0, bytesRead)
                    bytesRead = source.Read(buffer, 0, BUFFER_SIZE)
                End While

                target.Close()
            End Using

            source.Close()
        End Using
    End Sub

End Module