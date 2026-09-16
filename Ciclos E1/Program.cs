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
