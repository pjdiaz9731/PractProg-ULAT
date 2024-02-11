using System;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Método QuickSort");
            Console.Write("¿Cuál es la longitud del vector? ");
            int n = Int32.Parse(Console.ReadLine());

            Llenar llenar = new Llenar(n);
        }
    }

    class Llenar
    {
        int valor;
        int[] vector;

        public Llenar(int n)
        {
            valor = n;
            vector = new int[valor];

            for (int i = 0; i < valor; i++)
            {
                Console.Write("Ingrese valor {0}: ", i + 1);
                vector[i] = Int32.Parse(Console.ReadLine());
            }

            QuickSort(vector, 0, valor - 1);
            Mostrar();
        }

        private void QuickSort(int[] vector, int primero, int ultimo)
        {
            if (primero < ultimo)
            {
                int pivot = Particionar(vector, primero, ultimo);

                if (pivot > 1)
                {
                    QuickSort(vector, primero, pivot - 1);
                }
                if (pivot + 1 < ultimo)
                {
                    QuickSort(vector, pivot + 1, ultimo);
                }
            }
        }

        private int Particionar(int[] vector, int primero, int ultimo)
        {
            int pivot = vector[primero];

            while (true)
            {
                while (vector[primero] < pivot)
                {
                    primero++;
                }

                while (vector[ultimo] > pivot)
                {
                    ultimo--;
                }

                if (primero < ultimo)
                {
                    if (vector[primero] == vector[ultimo]) return ultimo;

                    int temp = vector[primero];
                    vector[primero] = vector[ultimo];
                    vector[ultimo] = temp;
                }
                else
                {
                    return ultimo;
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Vector ordenado:");
            for (int i = 0; i < valor; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }
    }
}

