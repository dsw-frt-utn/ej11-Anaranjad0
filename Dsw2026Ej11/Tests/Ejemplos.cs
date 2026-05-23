using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList listado = new CasoList();

        Alumno a1 = new Alumno(100, "Tomás Juarez", 9);
        Alumno a2 = new Alumno(101, "Lucía López", 8.5);
        Alumno a3 = new Alumno(102, "Anna Colman", 5.3);

        listado.AgregarAlumno(a1);
        listado.AgregarAlumno(a2);
        listado.AgregarAlumno(a3);

        Console.WriteLine("--- Lista de alumnos ---");
        foreach (var item in listado.RetornarLista())
        {
            Console.WriteLine(item.Id + " - " + item.Nombre);
        }

        Console.WriteLine();
        Console.WriteLine("Buscando a Tomás Juarez:");
        var encontrado = listado.BuscarPorNombre("Tomás Juarez");
        if (encontrado != null)
        {
            Console.WriteLine("Se encontro: " + encontrado.Nombre);
        }

        Console.WriteLine();
        Console.WriteLine("Buscando a Carmelito:");
        var noEncontrado = listado.BuscarPorNombre("Carmelito");
        if (noEncontrado == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine();
        Console.WriteLine("Eliminando a Anna Colman...");
        listado.EliminarAlumno(a3);

        foreach (var item in listado.RetornarLista())
        {
            Console.WriteLine(item.Nombre);
        }

        Console.WriteLine();
        Console.WriteLine("Borrando el primer elemento...");
        listado.EliminarEnPosicion(0);
        foreach (var item in listado.RetornarLista())
        {
            Console.WriteLine(item.Nombre);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary dictAlumnos = new CasoDictionary();
        dictAlumnos.AgregarAlumno(new Alumno(10, "Marcos", 8));
        dictAlumnos.AgregarAlumno(new Alumno(11, "Carlos", 9));
        dictAlumnos.AgregarAlumno(new Alumno(12, "Martin", 5));

        Console.WriteLine("Listado diccionario:");
        foreach (var val in dictAlumnos.ObtenerDiccionario().Values)
        {
            Console.WriteLine("Alumno: " + val.Nombre + " - Legajo: " + val.Id);
        }

        int claveBuscada = 11;
        Console.WriteLine();
        Console.WriteLine("Buscando clave " + claveBuscada);
        var alu = dictAlumnos.BuscarAlumno(claveBuscada);
        if (alu != null)
        {
            Console.WriteLine("Encontrado: " + alu.Nombre);
        }

        int claveMala = 99;
        Console.WriteLine();
        Console.WriteLine("Buscando clave " + claveMala);
        var aluMalo = dictAlumnos.BuscarAlumno(claveMala);
        if (aluMalo == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine();
        Console.WriteLine("Eliminando clave " + claveBuscada);
        dictAlumnos.EliminarAlumno(claveBuscada);

        Console.WriteLine("Diccionario actualizado:");
        foreach (var val in dictAlumnos.ObtenerDiccionario().Values)
        {
            Console.WriteLine(val.Nombre);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq clinq = new CasoLinq();

        Console.WriteLine("1. Primero: " + clinq.GetPrimero().Titulo);

        Console.WriteLine("2. Ultimo: " + clinq.GetUltimo().Titulo);

        Console.WriteLine("3. Suma total: $" + clinq.GetTotalPrecios());

        Console.WriteLine("4. Promedio: $" + clinq.GetPromedioPrecios());

        Console.WriteLine("5. Id mayor a 15:");
        foreach (var l in clinq.GetListById())
        {
            Console.WriteLine(l.Titulo);
        }

        Console.WriteLine();
        Console.WriteLine("6. Formato moneda:");
        foreach (var str in clinq.GetLibros())
        {
            Console.WriteLine(str);
        }

        Console.WriteLine();
        Console.WriteLine("7. Mas caro: " + clinq.GetMayorPrecio().Titulo);

        Console.WriteLine("8. Mas barato: " + clinq.GetMenorPrecio().Titulo);

        Console.WriteLine();
        Console.WriteLine("9. Mayores al promedio:");
        foreach (var l in clinq.GetMayorPromedio())
        {
            Console.WriteLine(l.Titulo);
        }

        Console.WriteLine();
        Console.WriteLine("10. Orden descendente:");
        foreach (var l in clinq.GetLibrosOrdenadosDescendente())
        {
            Console.WriteLine(l.Titulo);
        }
    }
}

