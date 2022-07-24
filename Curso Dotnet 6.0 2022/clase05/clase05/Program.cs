//Console.WriteLine("Desea continuar? (S/N)");
//var texto = Console.ReadLine();

//if (texto.ToUpper() == "S")//ToUpper() convierte todo a mayuscula y ToLower() a minuscula
//{
//    Console.WriteLine("Usted ingreso que SI");
//}
//else if (texto.ToUpper() == "N")
//{
//    Console.WriteLine("Usted ingreso que NO");
//}
//else
//{
//    Console.WriteLine("Usted no entendio nada");
//}




//Console.WriteLine("Cuantas vueltas quiere dar?");

//var respuesta = "S";
//var contador = 0;

//while (respuesta.ToUpper() != "N")
//{
//    contador++;// contador = contador + 1 
//    Console.WriteLine("Seguimos dando vueltas, vuelta numero: " + contador);

//    Console.WriteLine("Seguimos? (S/N)");
//    respuesta = Console.ReadLine(); 
//}



/*FOR
 *      DECLARACION VARIABLE
 *      CONDICION
 *      PASO
 * for (DECLARACION; CONDICION; PASO)
 * {
 *      tomoCaramelo();
 * }
 * CARAMELOS EN LA BOLSITA = 0
 * CONDICION MENOR A 12
 * PASO = 1
 */

for (var cantCaramelos = 0; cantCaramelos < 12; cantCaramelos++)// la primer ejecucion del for, NO TIENE INCREMENTO
{
    Console.WriteLine($"Mi bolsita tiene {cantCaramelos} caramelos."); // ESTO SE DENOMINA INTERPOLACION DE STRING (String interpolation) -> $"string {variable a concatenar} string"
    //EL PASO LO HACE AL FINALIZAR LA EJECUCION
}

var cantCaramelos2 = 0;
while (cantCaramelos2 < 12)
{
    cantCaramelos2++;
    Console.WriteLine("Mi bolsita tiene" + cantCaramelos2 + " caramelos.");
}
