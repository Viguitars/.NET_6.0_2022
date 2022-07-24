//Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:




//6)        Mostrar el vector nuevamente.


Console.Clear();

//1) Pedir al usuario la longitud de un vector:
Console.Write("Ingrese la longitud del vector que desea crear: ");
var dato = Console.ReadLine();
if (dato == null)
{
    dato = "0";
}
int longitudVector = int.Parse(dato);

//2) Crear el vector del tamaño ingresado:
int[] miVector = new int[longitudVector];

//3) Llenar el mismo con datos aleatorios:
Random datosAleatorios = new Random();

for (int i = 0; i < miVector.Length; i++)
{
    miVector[i] = datosAleatorios.Next(50);
}

//4) Mostrar el vector por pantalla:
Console.WriteLine($"Los {longitudVector} datos generados aleatoriamente son: ");
foreach (int i in miVector)
{
    Console.Write($" {i} ");
}
Console.WriteLine();

/*
5) Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero;
el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector
es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe quedar
así: 50, 40, 30, 20, 10.
Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.
Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
*/

Console.WriteLine("Si invertimos los datos generados aleatoriamente, nos queda asi: ");

//for (int i = miVector.Length; i > 0; i--)
//{
//    foreach (int i in miVector)
//    {
//        Console.Write($" {i} ");
//    }
//}

Console.WriteLine();




Console.ReadKey();
