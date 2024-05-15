using System.Data;
using Microsoft.VisualBasic;

class OperacionesMatrices
{

    public int[,] matriz = new int[0,0];
   
    public int cantidadFilas = 0;
    public int cantidadCols = 0;
    public OperacionesMatrices()
    {
    }

    public void CrearMatriz()
    {
       

        Console.WriteLine("Ingrese la cantidad de filas de la matriz");
        cantidadFilas = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
        cantidadCols = int.Parse(Console.ReadLine());

        matriz = new int[cantidadFilas,cantidadCols];
    }

    public void IngresarDatosMatriz()
    {
        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                Console.WriteLine($"Ingrese valor para la posicion [{fila}][{columna}]");
                matriz[fila,columna] = int.Parse(Console.ReadLine());
            }
        }
    }  

    public int[,] MultiplicaciónMatrizEscalar(int escalar)
    {
        int[,] matrizMultiplicada  = new int[matriz.GetLength(0),matriz.GetLength(1)];

        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                matrizMultiplicada[fila,columna] = matriz[fila,columna] * escalar;
            }
        }

        return matrizMultiplicada;
    }

    public void ImprimirMatriz(int[,] matrizMultiplicada)
    {
        for(int i = 0; i < matrizMultiplicada.GetLength(0); i++)
        {
            for(int j = 0; j < matrizMultiplicada.GetLength(1); j++)
            {
                Console.Write(matrizMultiplicada[i,j] + " " );
            }
            Console.WriteLine("");

        }
    }

    public int[,] DevolverValoresMenores(int ValoraBuscar)
    {
        int[,] ValoresMenores = new int[cantidadFilas,2];
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            int contador = 0;
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] < ValoraBuscar)
                {
                    contador++;
                }
            }
            ValoresMenores[i,0] = i;
            ValoresMenores[i,1] = contador;
            contador = 0;
        }
        return ValoresMenores;
    }

    public void EscribirValoresMenores(int[,] ValoresMenores)
    {
        for(int i = 0; i < ValoresMenores.GetLength(0); i++)
        {
            for(int j = 0; j < ValoresMenores.GetLength(1); j++)
            {
                Console.Write(" " + ValoresMenores[i,j]);
            }
            Console.WriteLine("");
        }
    }
    public int [] ArregloDePares()
    {
        int[] ArregloPares = new int[1];
        int valorMatriz = 0, p = 1;
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                valorMatriz = matriz[i,j];
                Console.WriteLine(valorMatriz);
                int verificador = valorMatriz % 2;
                if(verificador == 0)
                {
                    ArregloPares[i] = valorMatriz;
                    p++;
                    Array.Resize(ref ArregloPares,p);
                }
            }
        }
        return ArregloPares;
    }
    public void EscribirArregloPares(int[] ArregloPares)
    {
        for(int i = 0; i < ArregloPares.Length;)
        {
            Console.WriteLine(ArregloPares[i]);
        }
    }

}