//////////////////PRIMERA PARTE///////////////////////

//int primerNumero = 1986;
//int segundoNumero = primerNumero;

//Console.WriteLine(primerNumero);
//Console.WriteLine(segundoNumero);

//primerNumero = 1978;

//Console.WriteLine(primerNumero);
//Console.WriteLine(segundoNumero);

//////////////////SEGUNDA PARTE///////////////////////

//using clase15.Modelos;

//var miPrimerClase = new MiClase
//{
//    Id = 1,
//    Nombre = "Juancito Perez"
//};
//Console.WriteLine(miPrimerClase.Nombre);

//var miSegundaClase = miPrimerClase;
//Console.WriteLine(miSegundaClase.Nombre);

//miPrimerClase.Nombre = "Andres Gomez";
//Console.WriteLine(miPrimerClase.Nombre);
//Console.WriteLine(miSegundaClase.Nombre);

//////////////////TERCERA PARTE///////////////////////

//using clase15.Modelos;
////instanciamos una primer clase
//var miPrimerClase = new MiClase
//{
//    Id = 1,
//    Nombre = "PEPE"
//};
////instanciamos una segunda clase
//var miSegundaClase = new MiClase
//{
//    Id = 2,
//    Nombre = "QUINO"
//};
////creamos una lista con las instancias
//var miLista = new List<MiClase>();
//miLista.Add(miPrimerClase);
//miLista.Add(miSegundaClase);

////imprimimos los valores de las dos instancias y realizamos una condicion
//foreach (var item in miLista)
//{
//    Console.WriteLine(item.Nombre);
//    if (item.Id == 1)
//        item.Nombre = "ROBERTO";
//}
////imprimimos los valores de las dos instancias
//Console.WriteLine(miPrimerClase.Nombre);
//Console.WriteLine(miSegundaClase.Nombre);


//////////////////TERCERA PARTE///////////////////////

using clase15.Modelos;

var primeraPersona = new Persona
{
    Apellido = "Mateos",
    Nombre = "Joaquin"
};

var primerDocente = new Docente
{
    Salario = 70000,
    Nombre = "Juan Pablo",
    Apellido = "Ferreyra"
};

var primerAlumno = new Alumno
{
    Legajo = 1234,
    Nombre = "Andres",
    Apellido = "Gomez"
};

var personas = new List<Persona>();
personas.Add(primeraPersona);
personas.Add(primerDocente);
personas.Add(primerAlumno);

foreach (var persona in personas)
{
    //if (persona.GetType() == typeof(Docente))
    {
        //Console.WriteLine(persona.Nombre);
        var docente = (Docente)persona;
        Console.WriteLine(docente.Salario);
    }
}

Console.ReadKey();
