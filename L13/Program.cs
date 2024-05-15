using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Data;
using System.Numerics;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        OperacionesMatrices operacionesMatrices = new OperacionesMatrices();
        char opcion = 'a';
        operacionesMatrices.CrearMatriz();
        operacionesMatrices.IngresarDatosMatriz();

        while (opcion != 'd')
        {
            Console.WriteLine("Menú opciones");
            Console.WriteLine(" a) Multiplicación de matriz por escalar");
            Console.WriteLine(" b) Devolver todas las posiciones por fila de un elemento menor");
            Console.WriteLine(" c) Convertir a arreglo de numeros pares");
            Console.WriteLine(" d) Salir");
            Console.WriteLine("Ingrese opción: ");
            opcion = Console.ReadLine()[0];

            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("Ingrese un escalar");
                    int escalar = Int32.Parse(Console.ReadLine());
                    operacionesMatrices.ImprimirMatriz(operacionesMatrices.MultiplicaciónMatrizEscalar(escalar));
                    break;
                case 'b':
                    Console.WriteLine("Ingrese un valor a buscar");
                    int ValoraBuscar = int.Parse(Console.ReadLine());
                    operacionesMatrices.EscribirValoresMenores(operacionesMatrices.DevolverValoresMenores(ValoraBuscar));
                    break;
                case 'c':
                    Console.WriteLine("Arreglo de números pares: ");
                    operacionesMatrices.EscribirArregloPares(operacionesMatrices.ArregloDePares());
                    break;
            }
        }
    }
}