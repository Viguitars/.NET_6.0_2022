// Ejercicio Clase 8:
//Crear un programa que cumpla con los siguientes pasos:

Console.Clear();

//1) Crear una matriz de dos dimensiones de tipo int llamada numeros:

Console.WriteLine("Ingrese la cantidad de COLUMNAS: ");
int cantidadColumnas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de FILAS: ");
int cantidadFilas = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantidadFilas, cantidadColumnas];

//2) Determinar el tamaño de cada dimension (fila, columnas) mediante valores ingresados por pantalla:

Console.WriteLine("========================================");
int lenghtColumnas = numeros.GetUpperBound(1) + 1;
Console.WriteLine($"El número de COLUMNAS ingresado es: {lenghtColumnas}.");

int lengthFilas = numeros.GetUpperBound(0) + 1;
Console.WriteLine($"El número de FILAS ingresado es: {lengthFilas}.");

//4) Recorrer la matriz para su carga con elementos de tipo int:

for (int columna = 0; columna < lenghtColumnas; columna++)
{
    Console.WriteLine("========================================");
    Console.WriteLine($"Ingrese los valores de la columna número {columna + 1}: ");

    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Valor de fila número {fila + 1}: ");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
}

//5) Recorrer la matriz para mostrar cada valor de la matriz:

for (int columna = 0; columna < lenghtColumnas; columna++)
{
    Console.WriteLine("========================================");
    Console.WriteLine($"Los valores ingresados en la columna número {columna + 1} son: ");

    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Valor de fila número {fila + 1}: ");
        Console.WriteLine(numeros[fila, columna]);
    }
}

//3) Declarar un vector de tipo double llamado promedios:

double[] promedios = new double[lenghtColumnas];

for (int columna = 0; columna < lenghtColumnas; columna++)
{
    double suma = 0;
    double promedioColumna = 0;

    for (int fila = 0; fila < lengthFilas; fila++)
    {
        suma += numeros[fila, columna];
    }

    //6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios:

    promedioColumna = suma / lengthFilas;
    promedios[columna] = promedioColumna;

    //7) Mostrar los promedios recorriendo el vector promedios:

    Console.WriteLine("========================================");
    Console.WriteLine($"El promedio de la columna número {columna + 1} es: {promedios[columna]}");
}

Console.WriteLine("========================================");

Console.ReadKey();
