Public Class modelos
    Public Class modeloPersonal
        Public Id_Personal As Integer
        Public Nombre As String
        Public Apellido_Paterno As String
        Public Apellido_Materno As String
        Public Domicilio As String
        Public numInt As String
        Public numExt As String
        Public Id_Colonia As Integer
        Public Id_Localidad As Integer
        Public Id_estado As Integer
        Public CURP As String
        Public Telefono As String
        Public Celular As String
        Public Ficha As String
        Public nivelMaximo As String
        Public preparacion As String
    End Class
    Public Class modeloAuxiliar
        Public nivel As String
        Public grado As String
    End Class
    Public Class modeloCP
        Public idCP As Integer
        Public nombreColonia As String
    End Class
    Public Class modeloDireccion
        Public idCP As Integer
        Public idColonia As Integer
        Public idLocalidad As Integer
        Public idEstado As Integer
        Public nombreColonia As String
        Public nombreMunicipio As String
        Public nombreCP As String
        Public nombreEstado As String
    End Class
    Public Class modeloPlantilla
        Public idPlantilla As Integer
        Public idPersonal As Integer
        Public idCCT As Integer
        Public idCicloEscolar As Integer
        Public idPuesto As Integer
        Public idFuncion As Integer
        Public HG As String
        Public HD As String
        Public HA As String
        Public grados As String
        Public grupos As String
        Public captura As String
        Public revisa As String
        Public fechaCaptura As Date
        Public fechaRevision As Date
    End Class
    Public Class modelosSustituye
        Public idPersonalSustituye As Integer
        Public idPlantilla As Integer
        Public idPersonal As Integer
        Public idPersonalS As Integer
        Public observaciones As String
    End Class
    Public Class modeloEstadistica
        Public idEstadisticas As Integer
        Public idCt As Integer
        Public idCicloEscolar As Integer
        Public idGrado As Integer
        Public nGrupos As Integer
        Public numHombres As Integer
        Public numMujeres As Integer
    End Class
    Public Class modeloMateria
        Public id_materia As Integer
        Public materia As String
        Public horas As Integer
        Public agrupacion As String
        Public id_nivel As Integer
        Public id_grado As Integer
    End Class
    Public Class modeloUsuario
        Public idUsuario As Integer
        Public usuario As String
        Public password As String
    End Class
    Public Class modeloPerfilesCt
        Public idmovimiento As Integer
        Public idCCt As Integer
        Public idUsuario As Integer
    End Class
End Class
