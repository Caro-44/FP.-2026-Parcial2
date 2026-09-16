//Micro-Ejercicios de Ciclos

/* EJERCICIO 1
Genera un programa que muestre un log de combate donde el jugador realiza 5 puntos de daño al enemigo cada turno.
Probar con diferentes valores iniciales de vida (-50, 5, 0).
*/

int    daño        = 5;
Random rnd         = new Random();
int    numero      = rnd.Next(1,50);
int    vidaEnemigo = numero;
int    vidaFinal;

while (vidaEnemigo > 0)
{

    Console.WriteLine("La vida del enemigo es: " + vidaEnemigo);
    vidaEnemigo = vidaEnemigo - daño;
    Console.WriteLine("La vida del enemigo despúes del ataque es: " + vidaEnemigo);
    Console.WriteLine("\n");
}

Console.WriteLine("¡Haz derrotado al enemigo!");

Console.WriteLine("\n\n");

/* EJERCICIO 2
Generar un programa que le solicite al usuario un número entero. Seguir pidiendo valores hasta que el usuario
ingrese un valor correcto, mostrando un mensaje de error o éxito según sea el caso.
Intentar con los siguientes valores para comprobar: 9.5 = Error, H = Error, 5 = Correcto
*/

string num;
bool   si;
int    numINT;
int    numCorrecto = 5;

do
{
    Console.WriteLine("Escriba un número entero.");
    num = Console.ReadLine();
    si  = int.TryParse(num, out numINT);
    if (si == true)
    {
        if (numINT == numCorrecto)
        {
            Console.WriteLine("Numero válido");
        }
        else
        {
            Console.WriteLine("Numero inválido. Se requiere un número entero.");
        }
    }
    else
    {
        Console.WriteLine("Dato inválido ");
    }

} while (numCorrecto != numINT);

Console.WriteLine("\n\n");

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
