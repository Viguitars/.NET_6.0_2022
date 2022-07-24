using clase19.Frontend;
using clase19.Repositorio;
using clase19.Modelo;

//Gestor de personas trabajadoras (empleados, desempleados, jubilados)
//Insertar personas en una base de datos, mostrar datos de una determinada persona o
//de todas las personas.


//INGRESE 1 PARA TRABAJAR SOBRE PERSONA
//INGRESE 2 PARA TRABAJAR SOBRE DESEMPLEADO
var repoArchivoPersona = new RepositorioEnArchivos<Persona>();
var MenuPersona = new MenuAplicacionPersona(repoArchivoPersona);

MenuPersona.Iniciar();

new MenuAplicacionDesempleado(new RepositorioEnArchivos<Desempleado>()).Iniciar();
