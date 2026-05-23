using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private readonly Dictionary<int, Alumno> _alumnos = new();


    public void AgregarAlumno(Alumno alumno)
    {
        if (alumno == null) throw new ArgumentNullException(nameof(alumno));
        _alumnos[alumno.Id] = alumno;
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        return _alumnos.TryGetValue(legajo, out Alumno? alumno) ? alumno : null;
    }

    public Dictionary<int, Alumno> ObtenerDiccionario()
    {

        if (_alumnos.Count == 0)
        {
            throw new InvalidOperationException("El diccionario de alumnos está vacío.");
        }
        return _alumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        if (!_alumnos.Remove(legajo))
        {
            throw new KeyNotFoundException($"No se encontró un alumno con el legajo {legajo} para eliminar.");
        }
    }


}