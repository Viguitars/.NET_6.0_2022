//MATRICES 
//Crear una matriz
//Las matrices se utilizan para almacenar múltiples valores en una sola variable, en lugar de declarar variables separadas para cada valor.
//Para declarar una matriz, defina el tipo de variable con corchetes: string[]cars;

//Ahora hemos declarado una variable que contiene una matriz de cadenas.
//Para insertarle valores, podemos usar una matriz literal: coloque los valores en una lista separadas por comas, dentro de llaves:
//                  string[]cars = {"Volvo", "BMW", "Ford", "Mazda"};
//                  Para crear una matriz de enteros, podría escribir:
//                  int[]myNum = {10, 20, 30, 40};
//Acceder a los elementos de un array
//*Accede a un elemento de matriz haciendo referencia al número indeice.
//*Esta sentencia accede al valor del primer elemento en coches:

//                  string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
//                  Console.WriteLine(cars[0]);


//string[] Cars = { "Ford", "Fiat", "Renault", "BMW", "Toyota"};//aqui c# sabe la cantidad de elementos que tiene la matriz

//Console.WriteLine(Cars[0]);

//string[] Frutas = new string[4];//aqui al no definir los elemntos se debe indicar la cantidad de los mismos

//Frutas[0] = "Pera";
//Frutas[1] = "Manzana";
//Frutas[2] = "Banana";
////para cambiar el valor de un elemento específico, consulte el numero de índice: cars[0] = "Opel";
//Frutas[3] = "Kiwi";
////Frutas[4] = "Naranja";

//Console.WriteLine(Frutas[2]);
//Console.WriteLine(Frutas[3]);
//Console.WriteLine("");
////Console.WriteLine(Frutas[4]);

int[] numeros = new int[5];
Console.WriteLine($"El array tiene {numeros.Length} posiciones");
Console.WriteLine("Por favor ingrese números");
//numeros[0] = int.Parse(Console.ReadLine());
//numeros[1] = int.Parse(Console.ReadLine());
//numeros[2] = int.Parse(Console.ReadLine());
//numeros[3] = int.Parse(Console.ReadLine());
//numeros[4] = int.Parse(Console.ReadLine());

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Por favor ingrese el numero: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    //suma += numeros[i];
    suma = suma + numeros[i];
}
Console.WriteLine($"El valor de la suma es = {suma}");

//Console.WriteLine($"Mostrando el numero en la posicion tres: {numeros[2]}");
Console.WriteLine("Los valores ingresados son: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}




Console.ReadKey();
