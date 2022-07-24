////Se dispone de un array de n números aleatorios (Usar la clase Random). 
////Diseñar un programa que permita insertar un valor x en el lugar k-ésimo del array

//Console.WriteLine("Ingrese el tamaño deseado para el listado: ");//solicitamos el tamaño del listado (array)
//var dato = Console.ReadLine();//leemos lo ingresado
//if (dato == null)// de esta manera se evita que el dato no sea nulo (nulo no es lo mismo que vacio)
//{
//    dato = "0";
//}
//int n = int.Parse(dato);//lo convertimos en un valor del tipo entero

//int[] miVector = new int[n];//asignamos ese valor al tamaño del array.
//                            //Los array estan obligados a recibir la cantidad de elemntos!!!

//Random aleatorio = new Random();//creamos una instancia de la clase aleatoria

//for (int i = 0; i < miVector.Length; i++)// aqui se carga el vector
//{
//    miVector[i] = aleatorio.Next(100);//esta es una propiedad que devuelve un número entero
//}

//var contador = 0;

//foreach (int i in miVector)//por cada elemento de vector
//{
//    contador++;
//    Console.WriteLine(contador + ": " + i + " ");
//}

//Console.WriteLine();
//Console.WriteLine("Ingrese posición a modificar: ");
//var k = int.Parse(Console.ReadLine());

//if (k > miVector.Length || k < 0)
//{
//    Console.WriteLine("Indice incorrecto.");
//}
//else
//{
//    Console.WriteLine("Ingrese un nuevo valor: ");
//    while (true)//bucle infinito
//    {
//        var nuevoValor = int.Parse(Console.ReadLine());
//        if (nuevoValor > 0 && nuevoValor < 100)
//        {
//            miVector[k - 1] = nuevoValor;
//            break;//para salir del bucle infinito
//        }
//        else
//        {
//            Console.WriteLine("Recuerde que el valor debe ser positivo y menor que 100");
//        }
//    }

//    contador = 0;

//    foreach (int i in miVector)//por cada elemento de vector
//    {
//        contador++;
//        Console.WriteLine(contador + ": " + i + " ");
//    }

//}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Ingrese cantidad de numeros primos deseados:");
var n = int.Parse(Console.ReadLine());

int[] primos = new int[n];
List<int> primos2 = new List<int>();


int posicion = 0;
int aux = 0;
int numero = 1;

while (posicion < n)
{
    aux = 0;
    for (var i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            aux++;
        }
    }
    if (aux == 2)
    {
        primos[posicion] = numero;
        posicion++;
    }
    numero++;
}
foreach (var i in primos)
{
    Console.WriteLine(i);
}
Console.ReadKey();
