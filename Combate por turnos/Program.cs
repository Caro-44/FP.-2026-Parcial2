/* EJERCICIO 01: Combate por turnos

ANÁLISIS DE PROBLEMA

PROBLEMA:
Crear un juego en el que un jugador se enfrenta a un enemigo en un combate por turnos, cumpliendo con ciertas condiciones.

OBJETIVO:
Generar un programa que permita al jugador enfrentarse a un enemigo por turnos, ambos personajes tienen puntos de vida y ataque.
Se elegirá de forma aleatoria quién hace el primer movimiento. En cada turno, el jugador puede elegir si curarse o atacar.
El daño provocado variará por cada golpe y la pelea continuará turno por turno hasta ser derrotado.

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

ALGORITMO:

INICIO
Definir entradas
Mostrar vida de jugador (aleatorio)
Mostrar vida de (aleatorio)
Escoger quién irá primero
Si enemigo ataca primero
Restar vida de jugador
Sino
Preguntar si atacar o curar
Si se ataca
Restar vida al enemigo
Sino
Agregar vida al jugador
Repetir ciclos hasta llegar a cero
FIN

*/

Random rdm     = new Random();
int    VidaJug = rdm.Next(50, 100+1);
Random rdm2    = new Random();
int    VidaEnm = rdm2.Next(50, 100+1);
string comb;
bool   turno;

Console.WriteLine("La vida del jugador es: " + VidaJug);
Console.WriteLine("La vida del enemigo es: " + VidaEnm);
Console.WriteLine("¿Desea iniciar el combate?");


