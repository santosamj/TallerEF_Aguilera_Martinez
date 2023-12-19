// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using TallerEF_Aguilera_Martinez.Models;
using TallerEF_Aguilera_Martinez.Repositories;


/* 1.- AGREGAR ESTUDIANTE------------------------------------------------------------------------------------------------------*/

/*

Console.WriteLine("Guardar Estudiante");
Estudiante estudiante = new Estudiante();
EstudianteReposity estudianteReposity = new EstudianteReposity();

// Asignar los valores al objeto estudiante
estudiante.cedula = "0941192684";
estudiante.nombre = "Santos";
estudiante.apellido = "Aguilera";
estudiante.fechaNacimiento = new DateTime(1998, 05, 27); 
estudiante.FechaCreacion = DateTime.Today;

// Agregar el estudiante a la base de datos
estudianteReposity.agregarEstudiante(estudiante); 
*/
/* 2. Actualizar estudiante --------------------------------------------------------------------------------------------------------*/
/*
EstudianteReposity estudianteReposity = new EstudianteReposity();

Console.WriteLine("Ingrese el ID del estudiante que desea modificar:");
if (int.TryParse(Console.ReadLine(), out int idEstudiante))
{
    // Consultar el estudiante por su ID
    Estudiante estudianteAModificar = estudianteReposity.consultarEstudiantePorId(idEstudiante);

    if (estudianteAModificar != null)
    {
        Console.WriteLine($"Estudiante encontrado: {estudianteAModificar.nombre} {estudianteAModificar.apellido}");

        // Solicitar nuevos valores al usuario
        Console.WriteLine("Ingrese la nueva cedula:");
        estudianteAModificar.cedula = Console.ReadLine();

        Console.WriteLine("Ingrese el nuevo nombre:");
        estudianteAModificar.nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el nuevo apellido:");
        estudianteAModificar.apellido = Console.ReadLine();

        Console.WriteLine("Ingrese la nueva fecha de nacimiento (YYYY-MM-DD):");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime nuevaFechaNacimiento))
        {
            estudianteAModificar.fechaNacimiento = nuevaFechaNacimiento;

            // Actualizar el estudiante en la base de datos
            estudianteReposity.actualizarEstudiante(estudianteAModificar);

            Console.WriteLine("Estudiante actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("Formato de fecha incorrecto.");
        }
    }
    else
    {
        Console.WriteLine("No se encontró el estudiante con el ID especificado.");
    }
}
else
{
    Console.WriteLine("ID de estudiante inválido.");
}

Console.ReadLine(); 
*/
/* 3.Eliminar Estudiante ---------------------------------------------------------------------------------------*/
/*
EstudianteReposity estudianteReposity = new EstudianteReposity();

// Eliminar el estudiante con EstudianteId = 1
int idAEliminar = 9;
estudianteReposity.eliminarEstudiante(idAEliminar);

Console.WriteLine("Estudiante eliminado correctamente.");

// Otras operaciones o funcionalidades de tu aplicación
// ...

Console.ReadLine();

*/
/* 4. Consultar Estudiante por Id: --------------------------------------------------------------------------------*/
/*
EstudianteReposity estudianteReposity = new EstudianteReposity();


Estudiante estudiante = new Estudiante();

Console.WriteLine("Consultar Estudiante Por Id");
estudiante = new Estudiante();
estudiante = estudianteReposity.consultarEstudiantePorId(6);
Console.WriteLine("Cedula: " + estudiante.cedula + " Apellido: " + estudiante.apellido + " Nombre: " + estudiante.nombre + " Fecha Nacimiento: " + estudiante.fechaNacimiento);

*/
/* 5.  Consultar todos los estudiantes: ------------------------------------------------------------------------*/
/*
EstudianteReposity estudianteReposity = new EstudianteReposity();

Console.WriteLine("Consultar Estudiantes");
List<Estudiante> estudiantes = new List<Estudiante>();
estudiantes = estudianteReposity.consultarEstudiantes();
foreach (var item in estudiantes)
{
    Console.WriteLine("Cedula: " + item.cedula
        + " Apellido: " + item.apellido
        + " Nombre: " + item.nombre
            + " Estado: " + item.Estado
            + " Fecha de Creacion: " +item.FechaCreacion

    +" Fecha Nacimiento: " + item.fechaNacimiento);
  
}
*/

/*EstudianteReposity estudianteReposity = new EstudianteReposity();
/*
Console.WriteLine("Guardar Estudiante");
Estudiante estudiante = new Estudiante();

// Asignar los valores al objeto estudiante
estudiante.cedula = "0941192684";
estudiante.nombre = "Santos";
estudiante.apellido = "Aguilera";
estudiante.fechaNacimiento = new DateTime(1998, 5, 27);
estudiante.FechaCreacion = DateTime.Today;

// Agregar el estudiante a la base de datos
estudianteReposity.agregarEstudiante(estudiante);*/
/*Estudiante estudiante = new Estudiante();*/
/*
Console.WriteLine("Guardar Materia");
Materia materia = new Materia();
MateriaRepository materiaRepository = new MateriaRepository();

// Asignar los valores al objeto materia
materia.Nombre = "Seguridad Informatica";
materia.semestre = 8;
materia.Estado = 1;
materia.FechaCreacion = DateTime.Today;

// Agregar la materia a la base de datos
materiaRepository.AgregarMateria(materia);
  */  /*
Console.WriteLine("Guardar Profesor");
Profesor profesor = new Profesor();
ProfesorRepository profesorRepository = new ProfesorRepository();

// Asignar los valores al objeto profesor
profesor.Nombre = "Silvia ";
profesor.Apellido = "Tejada";
profesor.Estado = 1;
profesor.FechaCreacion = DateTime.Today;
// Agregar el profesor a la base de datos
profesorRepository.AgregarProfesor(profesor); 

*/  /*
Console.WriteLine("Guardar Profesor por Materia");
ProfesorPorMateria profesorPorMateria = new ProfesorPorMateria();
ProfesorPorMateriaRepository profesorPorMateriaRepository = new ProfesorPorMateriaRepository();

// Asignar los valores al objeto profesor por materia
profesorPorMateria.MateriaId = 3;
profesorPorMateria.ProfesorId = 3;

// Agregar la relación a la base de datos
profesorPorMateriaRepository.AgregarProfesorPorMateria(profesorPorMateria);*/
/*
using (var context = new EstudianteContext())
{
    var profesoresConMaterias = context.Profesores
        .Include(profesor => profesor.ProfesorPorMateria)
        .ThenInclude(ppm => ppm.Materia)
        .ToList();

    foreach (var profesor in profesoresConMaterias)
    {
        Console.WriteLine($"Profesor: {profesor.Nombre} {profesor.Apellido}");

        foreach (var ppm in profesor.ProfesorPorMateria)
        {
            Console.WriteLine($"- Materia: {ppm.Materia.Nombre}");
        }
        Console.WriteLine();
    }
}
*/
//CARGA EXPLICITA
//Consulta 2: Obtener una materia y los profesores que la enseñan

using (var context = new EstudianteContext())
{
    var materiaId = 2; // ID de la materia deseada

    var materia = context.Materias
        .Include(m => m.ProfesorPorMateria)
        .ThenInclude(ppm => ppm.Profesor)
        .FirstOrDefault(m => m.MateriaId == materiaId);

    if (materia != null)
    {
        Console.WriteLine($"Materia: {materia.Nombre}");

        foreach (var ppm in materia.ProfesorPorMateria)
        {
            Console.WriteLine($"- Profesor: {ppm.Profesor.Nombre} {ppm.Profesor.Apellido}");
        }
    }
    else
    {
        Console.WriteLine("Materia no encontrada.");
    }
}
/*
Console.WriteLine("Guardar Paralelo");
Paralelo paralelo = new Paralelo();
ParaleloRepository paraleloRepository = new ParaleloRepository();

// Asignar los valores al objeto profesor
paralelo.Nombre = " SOF-S-NO-8-6 ";
paralelo.Grupo = "03110313 ";
paralelo.Jornada = "NOCTURNO";
paralelo.Estado = 1;
paralelo.FechaCreacion = DateTime.Today;
// Agregar el profesor a la base de datos
paraleloRepository.AgregarParalelo(paralelo);*/

/*
using (var context = new EstudianteContext())
{
    var paralelosYMaterias = context.Paralelos
        .Select(p => new
        {
            Paralelo = p.Nombre,
            Materias = p.DetallesParalelos.Select(dp => dp.Materia.Nombre)
        })
        .ToList();

    foreach (var paralelo in paralelosYMaterias)
    {
        Console.WriteLine($"Paralelo: {paralelo.Paralelo}");
        foreach (var materia in paralelo.Materias)
        {
            Console.WriteLine($"\t- Materia: {materia}");
        }
    }
}*/


