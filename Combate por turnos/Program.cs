/* EJERCICIO 01: Combate por turnos

ANÁLISIS DE PROBLEMA

PROBLEMA:
Crear un juego en el que un jugador se enfrenta a un enemigo en un combate por turnos, cumpliendo con ciertas condiciones.

OBJETIVO:
Generar un programa que permita al jugador enfrentarse a un enemigo por turnos, ambos personajes tienen puntos de vida y ataque.
Se elegirá de forma aleatoria quién hace el primer movimiento. En cada turno, el jugador puede elegir si curarse o atacar.
El daño provocado variará por cada golpe y la pelea continuará turno por turno hasta que uno sea derrotado.

ENTRADAS:
Vida jugador
Vida enemigo
Ataque jugador
Ataque enemigo
Curación

SALIDAS:
Vida final jugador
Vida final enemigo
Personaje derrotado

*/

const int VIDA_JUG = 200;
const int VIDA_ENM = 200;

var       vidaJug  = VIDA_JUG;
var       vidaEnm  = VIDA_ENM;

Random    rdm     = new Random();
int       turno    = rdm.Next(0, 2);
string    decision;

Console.WriteLine("La vida del jugador es de: " + vidaJug);
Console.WriteLine("La vida del enemigo es de: " + vidaEnm);
Console.WriteLine("¡Empecemos el combate!");

while (vidaJug > 0 && vidaEnm > 0)
{
    int ataque = rdm.Next(20, 50+1);
    int cura   = rdm.Next(40, 80+1);

    if (turno == 1)
    {
        Console.WriteLine("¡Turno del jugador!");
        Console.WriteLine("¿Deseas atacar o curarte? 1 para atacar, 2 para curarte.");
        decision = Console.ReadLine();

        if (decision != "1" && decision != "2")
        {
            Console.WriteLine("Dato inválido. Intenta de nuevo.");
            turno = 1;
        }
        else if (decision == "1")
        {
            Console.WriteLine("Has decidido atacar.");
            Console.WriteLine("El daño recibido por el enemigo es de: " + ataque);
            vidaEnm = Math.Max(0, vidaEnm - ataque);
            Console.WriteLine("La vida del enemigo es de: " + vidaEnm);

            turno = 0;
        }
        else if (decision == "2")
        {
            Console.WriteLine("Has decidido curarte. Obtienes: " + cura);
            vidaJug = Math.Min(VIDA_JUG, vidaJug + cura);
            Console.WriteLine("Tu vida ahora es de: " + vidaJug);

            turno = 0;
        }

    }
    else if (turno == 0)

    {
        Console.WriteLine("¡Turno del enemigo!");
        Console.WriteLine("El enemigo ha atacado. Has perdido: " + ataque);
        vidaJug = Math.Max(0, vidaJug - ataque);
        Console.WriteLine("Tu vida ahora es de: " + vidaJug);

        turno = 1;

    }
    if (vidaJug <= 0)
    {
        Console.WriteLine("Has perdido el combate.");
    }
    else if (vidaEnm <= 0)
    {
        Console.WriteLine("¡Has ganado el combate! ¡Felicidades!");
    }
}
