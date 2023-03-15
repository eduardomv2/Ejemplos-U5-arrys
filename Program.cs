using System;
class Program
{
    static void Main()
    {
        // Ejemplo de arreglo unidimensional
        int[] arreglo1D = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Elementos del arreglo unidimensional:");
        for (int i = 0; i < arreglo1D.Length; i++)
        {
            Console.Write("{0} ", arreglo1D[i]);
        }
        Console.WriteLine();

        // Ejemplo de arreglo bidimensional
        int[,] arreglo2D = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.WriteLine("Elementos del arreglo bidimensional:");
        for (int i = 0; i < arreglo2D.GetLength(0); i++)
        {
            for (int j = 0; j < arreglo2D.GetLength(1); j++)
            {
                Console.Write("{0} ", arreglo2D[i, j]);
            }
            Console.WriteLine();
        }

        // Ejemplo de arreglo tridimensional
        int[,,] arreglo3D = new int[2, 2, 2] {
            { { 1, 2 }, { 3, 4 } },
            { { 5, 6 }, { 7, 8 } }
        };
        Console.WriteLine("Elementos del arreglo tridimensional:");
        for (int i = 0; i < arreglo3D.GetLength(0); i++)
        {
            for (int j = 0; j < arreglo3D.GetLength(1); j++)
            {
                for (int k = 0; k < arreglo3D.GetLength(2); k++)
                {
                    Console.Write("{0} ", arreglo3D[i, j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
