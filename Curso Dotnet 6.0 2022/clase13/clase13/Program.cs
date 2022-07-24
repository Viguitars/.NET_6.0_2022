using Constructores.Modelos;

var persona1 = new Persona("Juan Perez", "12345678", 30, false);

Console.WriteLine(persona1.ObtenerSaludo());
Console.WriteLine(persona1.ObtenerSaludo("Juan"));

var persona2 = new Persona { NombreCompleto = "Carlos Moscoso" };

// Esta clase también se incorpora desde el namespace Constructores.Modelo
var miOcupacion = new Ocupacion();

Console.ReadKey();
