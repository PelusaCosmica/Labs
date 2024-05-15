using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laboratorio No.7 Bruno Antonio Urías Castillo - 1184524");
        int N;
        bool ConversionAInt = false;
        bool nPositivo = false;

        do
        {
            Console.WriteLine("Ingrese un número mayor a 0");
            ConversionAInt = int.TryParse(Console.ReadLine(), out N);
            if(ConversionAInt)
            {
                if(N > 0)
                {
                    nPositivo = true;
                }
            }
        }while(!ConversionAInt || !nPositivo);

        int A = 0;
        int B = 1;
        int C = 1;
        double resultado = 0.00;
        
        if(nPositivo)
        {
            resultado = A;
            Console.Write(resultado + ", ");
            if(N > 1)
        {
            resultado += B;
            Console.Write(resultado + ", ");
            for(int i = 2; i < N; i = i + 1)
            {
                Console.Write(resultado + ", ");
                resultado += C;
                C = A + B;
                A = B;
                B = C;
            }
        }
        }
        Console.WriteLine();
        Console.WriteLine("TAREA");
        int contador = 0;
        double n = 0;
        double a = 0;
        double x = 0;
        double k = 0;
        double r = 0;
        double j = 1;

        
        if(nPositivo)
        {
            Console.WriteLine("Serie 1: ");
            resultado = 0;
            do
            {
                contador += 1;
                j = contador;
                Console.Write("1/"+ j + " + ");
                resultado = 1/j;
                r = r + resultado;
            }while(contador < N);
            Console.WriteLine("El resultado es: " + r);

            r = 0;
            contador = 0;
            resultado = 0;

            Console.WriteLine("Serie 2: ");
            do
            {
                contador += 1;
                j = contador;
                Console.Write("1/2^"+ j + " + ");
                x = Math.Pow(2,j);
                resultado = 1/x;
                r = r + resultado;
            }while(contador < N);
            Console.WriteLine("El resultado es: " + r);

            contador = 0;
            r = 0;
            x = 0;
            double m = 0.00;
            double b = 0.00;
            resultado = 0;

            Console.WriteLine("Serie 3: ");
            Console.Write("Ingrese a: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.Write("Ingrese x: ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("Ingrese n: ");
            double.TryParse(Console.ReadLine(), out n);
            do
            {
                j = k;
                Console.Write(x + "^" + k +" * " + a + "^(" + n + "-" + k +")" + " + ");
                m = Math.Pow(x,k);
                b = Math.Pow(a,(n - k));
                resultado = m * b;
                r = r + resultado;
                k += 1;
            }while(k <= n);
            Console.WriteLine("El resultado es: " + r);
        }
    }
}