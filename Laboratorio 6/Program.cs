using System.ComponentModel.Design;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("EJERCICIO 1");

        int numes;
        string entrames;
        string mesca = "";

        Console.WriteLine("Ingrese un número del 1 al 12 para mostrar el nombre del mes");
        entrames = Console.ReadLine();
        if(int.TryParse(entrames, out numes))
        {
            Console.WriteLine($"Se convirtió '{entrames}' a '{numes}'");
        }
        else
        {
            Console.WriteLine("Error: Ingrese un número del 1 al 12");
        }

        switch(numes)
        {
            case 1:
                mesca = "Enero";
                break;
            case 2:
                mesca = "Febrero";
                break;
            case 3:
                mesca = "Marzo";
                break;
            case 4:
                mesca = "Abril";
                break;
            case 5:
                mesca = "Mayo";
                break;
            case 6:
                mesca = "Junio";
                break;
            case 7:
                mesca = "Julio";
                break;
            case 8:
                mesca = "Agosto";
                break;
            case 9:
                mesca = "Septiembre";
                break;
            case 10:
                mesca = "Octubre";
                break;
            case 11:
                mesca = "Noviembre";
                break;
            case 12:
                mesca = "Diciembre";
                break;
            default:
                Console.WriteLine("El número ingresado debe estar entre 1 y 12");
                break;
        }
        Console.WriteLine($"Mes: '{mesca}'");

        Console.WriteLine("EJERCICIO 2");
        int a;
        int b;
        int c;

        Console.WriteLine("Ingrese primer número entero");
        int.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Ingrese segundo número entero");
        int.TryParse(Console.ReadLine(), out b);
        Console.WriteLine("Ingrese tercer número entero");
        int.TryParse(Console.ReadLine(), out c);

        if(a > b)
        {
            if(a > c)
            {
                Console.WriteLine("El numero mayor es: " + a);
            }
            else
            {
                if(a == c)
                {
                    Console.WriteLine("Los números: " + a + " y "+ c +" son iguales");
                }
                else
                {
                    Console.WriteLine("El número mayor es: " + c);
                }
            }
        }
        else
        {
            if(a == b)
            {
                if(a > c)
                {
                    Console.WriteLine("El número mayor es: " + a);
                }
                else
                {
                    if(a == c)
                    {
                        Console.WriteLine("Los números: " + a + " y "+ c +" son iguales");
                    }
                    else
                    {
                        Console.WriteLine("El número mayor es: " + c);
                    }
                }
                Console.WriteLine("Los números: " + a + " y "+ b +" son iguales");
            }
            else
            {
                if(b > c)
                {
                    Console.WriteLine("El número mayor es: "+ b);
                }
                else
                {
                    if(b == c)
                    {
                        Console.WriteLine("Los números: " + b + " y "+ c +" son iguales");
                    }
                }
            }
        }
        Console.WriteLine("EJERCICIO 3");

        string año = "";
        string mes = "";
        string dia = "";
        int idia = 0;
        int imes = 0;

        Console.WriteLine("¿Cuál es su año de nacimiento?");
        año = Console.ReadLine();   
        
        Console.WriteLine("¿Cuál es el mes de su nacimiento?");
        mes = Console.ReadLine();
        mes = mes.ToUpper();

        Console.WriteLine("¿Cuál es el día de su nacimiento?");
        int.TryParse(Console.ReadLine(), out idia);   

        switch(mes)
        {
            case "ENERO":
                imes = 1;
                break;
            case "FEBRERO":
                imes = 2;
                break;
            case "MARZO":
                imes = 3;
                break;
            case "ABRIL":
                imes = 4;
                break;
            case "MAYO":
                imes = 5;
                break;
            case "JUNIO":
                imes = 6;
                break;
            case "JULIO":
                imes = 7;
                break;
            case "AGOSTO":
                imes = 8;
                break;
            case "SEPTIEMBRE":
                imes = 9;
                break;
            case "OCTUBRE":
                imes = 10;
                break;
            case "NOVIEMBRE":
                imes = 11;
                break;
            case "DICIEMBRE":
                imes = 12;
                break;
            default:
                Console.WriteLine("Ingrese un nombre de mes válido");
                break;
        }
        if(imes == 1)
        {
            if(idia <= 19)
            {
                Console.WriteLine("Su signo del zodiaco es: Capricornio");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Acuario");
            }
        }
        if(imes == 2)
        {
            if(idia <= 18)
            {
                Console.WriteLine("Su signo del zodiaco es: Acuario");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Piscis");
            }
        }
        if(imes == 3)
        {
            if(idia <= 20)
            {
                Console.WriteLine("Su signo del zodiaco es: Piscis");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Aries");
            }
        }
        if(imes == 4)
        {
            if(idia <= 19)
            {
                Console.WriteLine("Su signo del zodiaco es: Aries");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Tauro");
            }
        }
        if(imes == 5)
        {
            if(idia <= 20)
            {
                Console.WriteLine("Su signo del zodiaco es: Tauro");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Géminis");
            }
        }
        if(imes == 6)
        {
            if(idia <= 20)
            {
                Console.WriteLine("Su signo del zodiaco es: Géminis");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Cancer");
            }
        }
        if(imes == 7)
        {
            if(idia <= 22)
            {
                Console.WriteLine("Su signo del zodiaco es: Cancer");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Leo");
            }
        }
        if(imes == 8)
        {
            if(idia <= 22)
            {
                Console.WriteLine("Su signo del zodiaco es: Leo");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Virgo");
            }
        }
        if(imes == 9)
        {
            if(idia <= 22)
            {
                Console.WriteLine("Su signo del zodiaco es: Virgo");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Libra");
            }
        }
        if(imes == 10)
        {
            if(idia <= 22)
            {
                Console.WriteLine("Su signo del zodiaco es: Libra");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Escorpio");
            }
        }
        if(imes == 11)
        {
            if(idia <= 22)
            {
                Console.WriteLine("Su signo del zodiaco es: Escorpio");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Sagitario");
            }
        }
        if(imes == 12)
        {
            if(idia <= 21)
            {
                Console.WriteLine("Su signo del zodiaco es: Sagitario");
            }
            else
            {
                Console.WriteLine("Su signo del zodiaco es: Capricornio");
            }
        }
    }
}