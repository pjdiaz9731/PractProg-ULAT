namespace ListasEn;

public class Nodo
{
    // Propiedades públicas para acceder al dato y a los nodos vecinos.
    public int Dato { get; set; }
    public Nodo Siguiente { get; set; }
    public Nodo Anterior { get; set; }

    // Constructor que inicializa el nodo con un dato.
    public Nodo(int dato)
    {
        this.Dato = dato;
        this.Siguiente = null;
        this.Anterior = null;
    }
}

