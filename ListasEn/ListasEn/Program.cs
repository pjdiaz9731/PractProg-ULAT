
using ListasEn;

class Program
{
    static void Main(string[] args)
    {
        Listas lista = new Listas ();
        while (true)
        {
            Console.WriteLine("\nMenú de opciones");
            Console.WriteLine("1- Agregar datos a la lista");
            Console.WriteLine("2- Eliminar datos de la lista");
            Console.WriteLine("3- Mostrar los datos de la lista");
            Console.WriteLine("4- Salir de la aplicación");
            Console.Write("Ingrese una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el dato a agregar: ");
                    int datoAgregar = int.Parse(Console.ReadLine());
                    lista.Agregar(datoAgregar);
                    break;
                case "2":
                    Console.Write("Ingrese el dato a eliminar: ");
                    int datoEliminar = int.Parse(Console.ReadLine());
                    if (lista.Eliminar(datoEliminar))
                    {
                        Console.WriteLine("Dato eliminado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Dato no encontrado.");
                    }
                    break;
                case "3":
                    lista.Mostrar();
                    break;
                case "4":
                    Console.WriteLine("Saliendo de la aplicación...");
                    return;
                default:
                    Console.WriteLine("Opción no válida, intente nuevamente.");
                    break;
            }
        }
    }
}

