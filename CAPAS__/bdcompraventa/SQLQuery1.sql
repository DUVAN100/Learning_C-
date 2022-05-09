use hospital
create procedure consultar_paciente
@id_paciente varchar(20)
as select * from paciente where id_paciente=@id_paciente
--actualizar paciente
create procedure actualizar_paciente
@id_paciente varchar(20)
as update paciente set activo= 0 where id_paciente=@id_paciente
--guardar medico
create procedure guardar_medico
@id_medico varchar(20),
@nom_medico varchar(60),
@especialida varchar(60),
@cell_medico varchar(20),
@activo bit
as insert into medico(id_medico,nom_medico,especialida,cell_medico,activo)values(@id_medico,@nom_medico,@especialida,@cell_medico,@activo)
---anular medico
create procedure actualizar_medico
@id_mediico varchar(20)
as update medico set activo= 0 where id_medico= @id_mediico
---consultar medico 
create procedure consultar_medico
@id_medico varchar(20)
as select*from medico where id_medico=@id_medico

--



create procedure actualizar_cita
@cod_cita varchar(10)
as update cita set activo=0 where cod_cita=@cod_cita
--
create procedure eliminar_cita
@cod_cita varchar(10)
as delete cita where cod_cita=@cod_cita
