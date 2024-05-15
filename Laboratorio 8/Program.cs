using System.Threading.Tasks.Dataflow;

class program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        string entrada;
        string res;
        int num1 = 0;
        int resultado = 0;
        int num2 = 0;

        Console.WriteLine("Ingrese un número 1-4");
        entrada = Console.ReadLine();

        try
        {
            opcion = int.Parse(entrada);
        }
        catch(FormatException)
        {
            Console.WriteLine("Error");
        }

        do
        {
            Console.WriteLine("a. Sumatoria");
            Console.WriteLine("b. Factorial");
            Console.WriteLine("c. Tablas de multiplicar");
            Console.WriteLine("d. Salir");
            Console.WriteLine("");
            Console.WriteLine("Ingrese la letra de opción");
            res = Console.ReadLine();
            res = res.ToUpper();
            if(res != "")
            {
                Console.WriteLine("Gracias!");
            }
            else
            {
                Console.WriteLine("INGRESE UNA LETRA DE OPCIÓN");
                res = Console.ReadLine() + ""; 
            }
            switch(res)
            {
                case "A":
                    Console.WriteLine("Ingrese un número entero mayor a cero");
                    int.TryParse(Console.ReadLine(), out num1);
                    for( int i = 0; i <= num1; i++)
                    {
                    Console.Write(i);
                    if(i < num1)
                    {
                        Console.Write(" + ");
                    }
                    resultado = resultado + i;
                    }
                    Console.WriteLine(" = " + resultado);
                break;
                case "B":
                    Console.WriteLine("Ingrese un número entero mayor a cero");
                    int.TryParse(Console.ReadLine(), out num2);
                    resultado = num2;
                    num1 = num2;
                    Console.Write(num2 + " * ");
                    for(int i = 1; i < num2; i++)
                    {
                        num1--;
                        Console.Write(num1);
                        if(i < num2)
                        {
                            Console.Write(" * ");
                        }
                        resultado = resultado * i;
                    }
                    Console.WriteLine(" = " + resultado);
                break;
                case "C":
                    string titulo = "\t";
                    Console.WriteLine("Tablas de multiplicar");
                    for(int a = 1; a <= 10; a++)
                    {
                        titulo += a + "\t";
                    }
                    Console.WriteLine(titulo);

                    string fila = "";
                    for(int filai = 1; filai <= 10; filai++)
                    {
                        fila = filai + "\t";
                        for(int multiplo = 1; multiplo <= 10; multiplo++)
                        {
                            fila += filai * multiplo + "\t";
                        }
                        Console.WriteLine(fila);
                    }
                break;

            }

        }while(res != "D");
        
    }
}