using System.Globalization;
using System.Reflection;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre: ");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Hola mundo");
        Console.WriteLine("Soy " + Nombre);

        /* El comando WriteLine escribe el mensaje y deja una linea de espacio, 
        en cambio el Write escribe sobre la misma linea, sin dejar una de espacio*/

        Console.Write("Hola Mundo");
        Console.WriteLine("Soy " + Nombre);

        /* EJERCICIO 2 */

        Console.WriteLine("Ejercicio 1: Operaciones aritméticas");

        int num1;
        int num2;

        Console.WriteLine("Ingrese los numeros solicitados a continuación");
        Console.Write("Numero 1: ");num1 = Int32.Parse(Console.ReadLine());
        Console.Write("Numero 2: ");num2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Suma: " + (num1 + num2));
        Console.WriteLine("Resta: " + (num1 - num2));
        Console.WriteLine("Multiplicación: " + (num1 * num2));
        Console.WriteLine("División: " + (num1 / num2));
        Console.WriteLine("Mod: " + (num1 % num2));

        /*EJERCICIO 3 */

        Console.WriteLine("Ejercicio 2: Operaciones booleanas");
        Console.WriteLine("El número 1 es mayor que el número 2 = " + (num1 > num2));
        Console.WriteLine("El número 1 es menor que el número 2 = " + (num1 < num2));
        Console.WriteLine("El número 1 es igual que el número 2 = " + (num1 == num2));

        /*EJERCICIO 4 */

        int a;
        int b;
        int c;

        Console.WriteLine("Ejercicio 3: jerarquía de operaciones");
        Console.WriteLine("Ingrese los numeros a continuación: ");
        Console.Write("a: "); a = Int32.Parse(Console.ReadLine());
        Console.Write("b: "); b = Int32.Parse(Console.ReadLine());
        Console.Write("c: "); c = Int32.Parse(Console.ReadLine());
        Console.WriteLine("a * b + c = " + (a * b + c));
        Console.WriteLine("a * (b + c) = " + (a * (b + c)));
        Console.WriteLine("a / (b * c) = " + (a / (b * c)));
        Console.WriteLine("3a + 2b / c^2 = " + ( (3*a + 2*b) / c*c));

        /*EJERCICIO 5 */

        Console.WriteLine("Ejercicio 4");
        Console.WriteLine("Positivo = " + ((-b + Math.Sqrt((b*b)- (4 * a * c)))/(2*a)));
        Console.WriteLine("Negativo = " + ((-b + Math.Sqrt((b*b)- (4 * a * c)))/(2*a)));
        
    }
}