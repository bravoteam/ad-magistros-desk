Imports sidep.PlantillaPersonal.PlantillaPersonal
Public Class horarioIsenco

    Private Sub cmbLicenciatura_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLicenciatura.DropDown
        Dim ds As New DataSet
        ds = getLicenciaturas()
        loadComboBox(ds, cmbLicenciatura, "idLicenciatura", "licenciatura")
    End Sub

    Private Sub cmbEspecialidad_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEspecialidad.DropDown
        Dim ds As New DataSet
        ds = getEspecialidades()
        loadComboBox(ds, cmbEspecialidad, "idEspecialidad", "especialidad")
    End Sub

    Private Sub cmbGrado_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrado.DropDown
        Dim ds As New DataSet
        ds = getGrados()
        loadComboBox(ds, cmbGrado, "idgrado", "grado")
    End Sub

    Private Sub cmbGrupo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupo.DropDown
        Dim ds As New DataSet
        ds = getGrupos(Val(cmbGrado.Text))
        loadComboBox(ds, cmbGrupo, "idgrupo", "grupo")
    End Sub

    Private Sub cmbMaestro_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMaestro.DropDown
        Dim ds As New DataSet
        ds = getMaestros(265)
        loadComboBox(ds, cmbMaestro, "id_personal", "nombre")
    End Sub

    Private Sub cmbMateria_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMateria.DropDown
        'Horarios - cargar materias
        Dim ds As New DataSet
        ds = getMaterias(variables.IdNivel)
        loadComboBox(ds, cmbMateria, "id_materia", "materia")
    End Sub
End Class