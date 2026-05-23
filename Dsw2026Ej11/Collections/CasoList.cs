using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> miListaAlumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alu)
    {
        // Solo agregamos si no es nulo
        if (alu != null)
        {
            miListaAlumnos.Add(alu);
        }
    }

    public List<Alumno> RetornarLista()
    {
        return miListaAlumnos;
    }

    public Alumno? BuscarPorNombre(string nom)
    {
        // busco el alumno pasando a minusculas
        foreach (var item in miListaAlumnos)
        {
            if (item.Nombre.ToLower() == nom.ToLower())
            {
                return item;
            }
        }
        return null;
    }

    public void EliminarAlumno(Alumno alu)
    {
        if (alu != null)
        {
            miListaAlumnos.Remove(alu);
        }
    }

    public void EliminarEnPosicion(int pos)
    {
        // compruebo que la posicion exista
        if (pos >= 0 && pos < miListaAlumnos.Count)
        {
            miListaAlumnos.RemoveAt(pos);
        }
    }
}

