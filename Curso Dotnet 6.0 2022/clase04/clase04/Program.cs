///*Ejemplo de condicional IF */

//Console.Write("Ingrese su edad: "); //Le pedimos al usuario que ingrese su edad
//int edad = int.Parse(Console.ReadLine()); //Obtenemos la edad por teclado

//Console.WriteLine("Ingrese su equipo de futbol: ");
//string equipo = Console.ReadLine();

//Console.WriteLine("La edad ingresada es: " + edad);

///*
//    AND -> && (Y)
//    OR  -> || (O)
//    IGUAL QUE -> ==
//    DISTINTO QUE -> !=
//*/

//bool condicion = edad < 18 && equipo == "River";

//if (condicion) //Evaluamos
//{
//    //Instrucciones si se cumple la condicion ecavaluada
//    Console.WriteLine("Usted es menor de edad.");

//    Console.WriteLine("Prohibida la entrada");
//}
//else
//{
//    //Instrucciones si se cumple la condicion ecavaluada
//    //Cuando tenemos una sola linea, no tenemos que usar "{}"
//    Console.WriteLine("Usted es mayor de edad.");
//}

//Console.ReadKey();


/*Ejemplo if-elseif-else */

//Console.Write("Ingrese la edad: ");
//int edad = int.Parse(Console.ReadLine());


//if (edad < 0 || edad > 110)
//{
//    Console.WriteLine("La edad ingresada no es valida.");
//}
//else if (edad < 12)
//{
//    Console.WriteLine("Va a la primaria");
//}
//else if (edad < 18)
//{
//    Console.WriteLine("Va al secundario");
//}
//else if (edad < 28)
//{
//    Console.WriteLine("Va a la facultad");
//}
//else 
//{
//    Console.WriteLine("A trabajar. No queda otra.");
//}

//Console.ReadKey();

/*Ejemplo del switch */

Console.WriteLine("Ingrese el primer numero: ");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicacion");
Console.WriteLine("4 - Division");

Console.WriteLine("Ingrese la operacion a realizar: ");
string operacion = Console.ReadLine();

double resultado = 0;
switch (operacion)
{
    case "1":
        resultado = numero1 + numero2;
        break;
    case "2":
        resultado = numero1 - numero2;
        break;
    case "3":
        resultado = numero1 * numero2;
        break;
    case "4" when numero2 != 0://cuando el numero es distinto de cero
        resultado = numero1 / numero2;
        break;
    default:
        Console.WriteLine("Ingreso una opcion no valida.");
        break;
}

Console.WriteLine("El resultado es: " + resultado);
Console.ReadKey();
