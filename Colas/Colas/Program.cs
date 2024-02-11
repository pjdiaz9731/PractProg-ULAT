using System;
using System.Collections.Generic;

namespace EjemploColas
{
    class Program
    {
        static void Main(string[] args)
        {
            COLAS cola = new COLAS();

            Console.WriteLine("Ingrese elementos a la cola (ingrese 'fin' para terminar):");

            string entrada;
            do
            {
                Console.Write("Elemento: ");
                entrada = Console.ReadLine();

                if (entrada.ToLower() != "fin")
                {
                    if (int.TryParse(entrada, out int elemento))
                    {
                        cola.Insertar(elemento);
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Introduzca un número o 'fin' para terminar.");
                    }
                }

            } while (entrada.ToLower() != "fin");

            Console.WriteLine("\nElementos extraídos de la cola:");

            while (!cola.Vaciar())
            {
                int elemento = cola.Extraer();
                Console.WriteLine($"Elemento extraído: {elemento}");
            }
        }
    }

    internal class Nodo
    {
        public int info;
        public Nodo sig;
    }

    internal class COLAS
    {
        private Nodo raiz, fondo;

        public COLAS()
        {
            raiz = null;
            fondo = null;
        }

        public bool Vaciar()
        {
            return raiz == null;
        }

        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig = null;

            if (Vaciar())
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.sig = nuevo;
                fondo = nuevo;
            }
        }

        public int Extraer()
        {
            if (!Vaciar())
            {
                int elemento = raiz.info;
                raiz = raiz.sig;
                return elemento;
            }
            else
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
        }
    }
}
