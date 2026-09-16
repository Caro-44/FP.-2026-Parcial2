/* EJERCICIO 3
Generar un programa que muestre la tabla del 7, del 0 al 100 de forma ordenada.
*/

Console.WriteLine("La tabla del siete");
Console.WriteLine("\n");

var siete = 7;

for (int tabla = 0;
     tabla <= 100;
     tabla++)
{
    Console.WriteLine(siete + " * " + tabla + " = " + tabla * 7);
}
