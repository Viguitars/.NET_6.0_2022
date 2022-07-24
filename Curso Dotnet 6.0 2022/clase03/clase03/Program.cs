//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


////Borra la pantalla
//Console.Clear();
////Pedimos al usuario que introduzca su nombre 
//Console.WriteLine("Hola, ingrese su nombre.");
////Leemos el nombre del usuario
//string nombre = Console.ReadLine();
////Pedimos al usuario que introduzca su apellido 
//Console.WriteLine("Ahora por favor ingrese su apellido.");
//string apellido = Console.ReadLine();
////Mostramos el nombre
//Console.Write("Hola " + nombre + " " + apellido);// esta funcion no hace salto de linea
//Console.WriteLine(", este es su segundo programa.");
////PROGRAMAR es escribir la instrucccion corecta en el lugar correcto
//Console.ReadKey();

Console.Clear();

Console.WriteLine("Este programa calcula la superficie del rectangulo");
Console.WriteLine();

//Convierte el string a numero
//double v = double.Parse("311");

Console.WriteLine("Ingrese la base del rectangulo");
//string  baseRectanguloTexto = Console.ReadLine();   
//double baseRectangulo = double.Parse(baseRectanguloTexto);

double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectangulo");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo =
    baseRectangulo * alturaRectangulo;

Console.Write("La superficie del rectangulo es: ");
Console.WriteLine(superficieRectangulo);

bool esMayorADiez = superficieRectangulo > 10;

if (esMayorADiez)
{
    //Mostrar mensaje si es mayor a diez
    Console.WriteLine("La superficie del rectangulo es mayor a 10.");
}

Console.ReadKey();
