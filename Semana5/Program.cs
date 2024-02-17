using System;

public class Nodo
{
    public int datos; // Info, objeto para almacenar el valor del nodo
    public Nodo siguientePtr; // Liga, apuntador al nodo siguiente de la lista

    public Nodo(int datosNodo)
    {
        datos = datosNodo;
        siguientePtr = null;
    }
}

public class Lista
{
    private Nodo primerPtr;

    public Lista()
    {
        primerPtr = null;
    }

    // Destructor
    ~Lista()
    {
        Console.WriteLine("Destruyendo la lista...");
        // Lógica para liberar memoria o realizar otras tareas de limpieza
    }

    private bool estaVacia()
    {
        return primerPtr == null;
    }

    public void InsertarAlInicio(int datos)
    {
        Nodo nuevoNodo = new Nodo(datos);
        nuevoNodo.siguientePtr = primerPtr;
        primerPtr = nuevoNodo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Punto de entrada del programa
        Lista miLista = new Lista();
        miLista.InsertarAlInicio(10);
        miLista.InsertarAlInicio(20);
        // Puedes agregar más valores a la lista como sea necesario
    }
}