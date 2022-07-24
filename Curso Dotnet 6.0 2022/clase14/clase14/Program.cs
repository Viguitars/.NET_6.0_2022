//using clase14;

//Persona p = null;// se debe asignar p para que se pueda compilar
//var Persona = new List<Persona>();
//for (int i = 0; i < 10; i++)
//{
//    var p = new Persona();
//    Persona.Add(p);
//}

//Console.WriteLine(p.Nombre + " " + p.Apellido);

//PROGRAMA HERENCIA

using clase14.Colegio;

Console.WriteLine("Hola clase heredada");

Alumno alumno = new Alumno();

Console.WriteLine(alumno.NombreCompleto);

Console.WriteLine(alumno.Clave());

Console.ReadKey();