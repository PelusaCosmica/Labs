using System.Reflection.PortableExecutable;

class Program{

static void Main(string[] args){

int op;    double bas; double alt; double lad; double ancho; double radio; int num;


Figuras objfiguras = new Figuras();
do{
Console.WriteLine("Qué acción desea realizar? \n 1) Area de un triangulo \n 2) Area de un cuadrado \n 3) Area de un rectangulo \n 4) Area de un circulo \n 5) salir");
int.TryParse(Console.ReadLine(), out op);


switch(op){
    case 1:
    Console.WriteLine("Ingrese la base: ");
    double.TryParse(Console.ReadLine(), out bas);
    Console.WriteLine("Ingrese la altura: ");
    double.TryParse(Console.ReadLine(), out alt);
    objfiguras.AreaTriangulo(bas, alt);
    Console.WriteLine("Su resultado es: "+ objfiguras.GetResultado());
    break;
    case 2:
    Console.WriteLine("Ingrese un lado: ");
    double.TryParse(Console.ReadLine(), out lad);
    objfiguras.Areacuadrado(lad);
    Console.WriteLine("Su resultado es: "+ objfiguras.GetResultado());
    break;
    case 3:
    Console.WriteLine("Ingrese la base: ");
    double.TryParse(Console.ReadLine(), out bas);
    Console.WriteLine("Ingrese la altura: ");
    double.TryParse(Console.ReadLine(), out alt);
    objfiguras.Areareactangulo(bas, alt);
    Console.WriteLine("Su resultado es: "+ objfiguras.GetResultado());
    break;
    case 4:
    Console.WriteLine("Ingrese el radio: ");
    double.TryParse(Console.ReadLine(), out radio);
    objfiguras.Areacuadrado(radio);
    Console.WriteLine("Su resultado es: "+ objfiguras.GetResultado());
    break;
}}while(op !=5);

string opcion;
Personaje objpersona = new Personaje(0, 0);
do{
Console.WriteLine("Ingrese la opción \n a) Sube \n b) baja \n c) izquierda \n d) derecha \n e) salir");
opcion = Console.ReadLine();

switch(opcion){

    case "a": 
    Console.WriteLine("Cuántos numeros se quiere mover: ");
    int.TryParse(Console.ReadLine(), out num);
    objpersona.MoverHaciaArriba(num);
    break;
    case "b":
     Console.WriteLine("Cuántos numeros se quiere mover: ");
    int.TryParse(Console.ReadLine(), out num);
    objpersona.MoverHaciaAbajo(num);
    break;
    case "c":
    Console.WriteLine("Cuántos numeros se quiere mover: ");
    int.TryParse(Console.ReadLine(), out num);
    objpersona.MoverHaciaIzquierda(num);
    break;
    case "d":
     Console.WriteLine("Cuántos numeros se quiere mover: ");
    int.TryParse(Console.ReadLine(), out num);
    objpersona.MoverHaciaDerecha(num);
    break;
    case "e":
    Console.WriteLine("Su personaje recorrio en x: "+ objpersona.x+ " y: "+ objpersona.y);
    break;
}
}while (opcion!="e");


}
}