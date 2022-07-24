//Escribe un programa que:

Console.Clear();

//1) Pida 10 números al usuario.
int[] numeros = new int[10];

Console.WriteLine("Por favor ingrese 10 números: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el numero {i + 1} : ");
    numeros[i] = int.Parse(Console.ReadLine());
}

//6) Mostrar todos los números ingresados por pantalla.
Console.WriteLine("Los 10 números ingresados son: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"{numeros[i]}");
}

//2) Obtener la suma de todos los números ingresados.
float suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}
Console.WriteLine($"La suma de los números ingresados es: {suma}.");

//3) Obtener cual es el mayor de todos los números.
Console.WriteLine($"El mayor de los números ingresados es: {numeros.Max()}.");
