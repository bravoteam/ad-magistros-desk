-- obtener municipios, localidades, colonias y codigo postal
select 
cp.id_codigo_postal, cp.id_cp as 'cp', cp.id_municipio, c.id_colonia, c.nombre, m.NOMBRE,
e.ID_ESTADO, e.NOMBRE
from bc_codigo_postal cp
inner join bc_colonia c on c.id_codigo_postal = cp.id_codigo_postal
inner join bc_municipio m on m.ID_MUNICIPIO = cp.id_municipio
inner join bc_estados e on e.ID_ESTADO = m.ID_ESTADO
where cp.id_cp = '28010'

-- buscar
select c.Id_CT, c.CCT, c.Nombre, c.Domicilio, c.Id_Colonia, co.nombre as colonia, 
c.Id_Localidad, l.descripcion as localidad, m.NOMBRE as municipio, cp.id_cp as codigopostal,
Telefono, c.Id_Turno, t.Descripcion as turno
from incidencias.dbo.inc_CT c
inner join bc_colonia co on co.id_colonia = c.Id_Colonia
inner join bc_localidad l on l.id_localidad = c.Id_Localidad
inner join bc_municipio m on m.ID_MUNICIPIO = l.id_municipio
inner join bc_codigo_postal cp on cp.id_codigo_postal = co.id_codigo_postal
inner join incidencias.dbo.inc_Turno t on t.id_turno = c.Id_Turno
order by c.Nombre

-- registro en busquedas
c_1
Búsqueda de Personal	
inc_ct	
c.CCT, c.Nombre, c.Domicilio, co.nombre as colonia, l.descripcion as localidad, m.NOMBRE as municipio, cp.id_cp as 'código postal', Telefono, t.Descripcion as turno	
'' + cast(c.id_ct as varchar) + '|' + c.cct + '|' + c.nombre + '|' c.domicilio + '|' + cast(c.id_colonia as varchar) + '|' + co.nombre + '|' + cast(cp.id_cp as varchar) + '|' + c.telefono + '|' + cast(c.id_turno as varchar) + '|' + t.descripcion + ''
inner join bc_colonia co on co.id_colonia = c.Id_Colonia inner join bc_localidad l on l.id_localidad = c.Id_Localidad inner join bc_municipio m on m.ID_MUNICIPIO = l.id_municipio inner join bc_codigo_postal cp on cp.id_codigo_postal = co.id_codigo_postal inner join incidencias.dbo.inc_Turno t on t.id_turno = c.Id_Turno

-- registros en busquedas_campos
27	Clave		c.CCT			1
27	Nombre		c.Nombre		1
27	Localidad	l.descripcion	1
27	Municipio	m.Municipio		1
27	Domicilio	c.Domicilio		1