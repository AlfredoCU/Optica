SELECT EXAMEN.[Id Paciente], PACIENTE.Nombre, PACIENTE.Apellido, EXAMEN.[Id Doctor], DOCTOR.Nombre,
	DOCTOR.Apellido, DOCTOR.Matricula, EXAMEN.[Id Examen], EXAMEN.[Fecha de Examen], EXAMEN.Observaciones,
	EXAMEN.Costo

FROM PACIENTE, DOCTOR, EXAMEN

WHERE PACIENTE.[Id Paciente] = EXAMEN.[Id Paciente] AND 
	DOCTOR.[Id Doctor] = EXAMEN.[Id Doctor]
	

