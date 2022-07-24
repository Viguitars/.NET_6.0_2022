//PRIMERA PARTE

//public interface IBebida
//{
//    decimal Volumen { get; set; }
//    bool Gasificada { get; set; }
//    string Color { get; set; }
//    decimal Calorias { get; set; }
//    bool Alcoholica { get; set; }
//}
//public interface IBebidasAlcoholicas : IBebida
//{
//    decimal Graduacion { get; set; }
//}
//public interface ICerveza : IBebidasAlcoholicas, IBebida
//{
//    int IBU { get; set; }
//}
//public class Gaseosa : IBebida
//{
//    public decimal Volumen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public bool Gasificada { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public decimal Calorias { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public bool Alcoholica { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//}
//public class Cerveza : ICerveza
//{
//    public decimal Volumen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public bool Gasificada { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public decimal Calorias { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public bool Alcoholica { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public int IBU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public decimal Graduacion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//}


//SEGUNDA PARTE

using clase18.Modelos;

var alumno = new Alumno()
{
    Nombre = "Joaquin",
    Apellido = "Perez",
    DNI = "12345678",
    Legajo = "12345"
};
var docente = new Docente()
{
    Nombre = "Eze",
    Apellido = "Etchecoin",
    DNI = "34125678",
    Horas = 12345
};

var listado = new List<IPersona>();
listado.Add(alumno);
listado.Add(docente);

var nuevoListado = ObtenerPersonasPorNombre(listado, "Eze");

Console.WriteLine(nuevoListado.Count);

List<IPersona> ObtenerPersonasPorNombre(List<IPersona> personas, string nombre)
{
    var nuevaLista = new List<IPersona>();
    
    foreach (var persona in personas)
    {
        if (persona.Nombre == nombre)
        {
            nuevaLista.Add(persona);
        }
    }
    {
    return nuevaLista;
}

string ObtenerDatos(IPersona persona)
{
    var datos = persona.Nombre + " " + persona.Apellido;
    return datos;
}