// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Datos numericos
//Primero se indica el tipo de dato, luego el nombre de la variable y por ultimo el valor del mismo

byte numeroByte = 0;
int numeroInteger = 527738;
long numeroLong = 200;
double numeroDouble = 300;
float numeroFloat = 400;

//Datos logicos
bool datoBoolVerdadero = true;
bool datoBoolFalso = false;


//Datos de texto
string datoString = "Texto de prueba numero uno";

//Constante
//Se indica la constante, el tipo, el nombre, el operador de asignacion y el valor de la misma
const string constanteTexto = "Bienvenidos";

Console.WriteLine(constanteTexto);


//Instruccion de salida - output
Console.WriteLine(datoString);

//Instruccion de entrada - input. En este caso al hacer andar el programa, me va a pedir que ingrese por teclado
//(sin que aparezca mas que el cursor, ya que no indique la instruccion), el valor de la variable datosSring. Asignandole 
//lo que escriba a la misma.

Console.WriteLine("Ingrese el valor de datosString:");

datoString = Console.ReadLine();

//La diferencia entre writeline y write es que el primero da un salto de linea, mientras que el segundo no lo hace

Console.Write(datoString);

Console.WriteLine(numeroInteger);
