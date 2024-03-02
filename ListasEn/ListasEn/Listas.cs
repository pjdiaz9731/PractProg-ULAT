using System.Reflection;

namespace ListasEn;

public class Listas
{
    // Referencias al primer y último nodo de la lista.
    private Nodo cabeza = null;
    private Nodo cola = null;

    // Agrega un nuevo nodo al final de la lista.
    public void Agregar(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (cabeza == null)
        {
            // Si la lista está vacía, el nuevo nodo es ahora cabeza y cola.
            cabeza = cola = nuevo;
        }
        else
        {
            // Enlaza el nuevo nodo al final de la lista y actualiza la cola.
            cola.Siguiente = nuevo;
            nuevo.Anterior = cola;
            cola = nuevo;
        }
    }

    // Elimina un nodo que contenga el dato especificado.
    public bool Eliminar(int dato)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato == dato)
            {
                if (actual.Anterior != null)
                {
                    // Reconecta el nodo anterior con el siguiente del actual.
                    actual.Anterior.Siguiente = actual.Siguiente;
                }
                else
                {
                    // Si se elimina la cabeza, actualiza la cabeza al siguiente.
                    cabeza = actual.Siguiente;
                }

                if (actual.Siguiente != null)
                {
                    // Reconecta el nodo siguiente con el anterior del actual.
                    actual.Siguiente.Anterior = actual.Anterior;
                }
                else
                {
                    // Si se elimina la cola, actualiza la cola al anterior.
                    cola = actual.Anterior;
                }

                return true;
            }
            actual = actual.Siguiente;
        }
        return false;
    }

    // Muestra todos los datos de la lista, navegando desde la cabeza hasta la cola.
    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " <-> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}
