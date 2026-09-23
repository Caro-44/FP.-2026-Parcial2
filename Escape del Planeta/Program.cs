// EJERCICIO: ESCAPE DEL PLANETA

/*

Crear un juego en el que el jugador controla una nave que debe abandonar la atmósfera antes de perder sus sistemas,
cumpliendo con ciertas condiciones.

 */

const int DISTANCIA_AL_ESPACIO_KM = 10;
const int COMBUSTIBLE_INICIAL     = 10;
const int ESCUDO_MAXIMO           = 50;
const int ESCUDO_POR_TURNO        = 5;
const int PERDIDA_KM_POR_TURNO    = 3;
const int COMBUSTIBLE_POR_TURNO   = 2;
const int ASCENSO_POR_TURNO       = 2;

var kmRecorridos      = 0;
var combustibleActual = COMBUSTIBLE_INICIAL;
var escudoActual      = ESCUDO_MAXIMO;

Console.WriteLine("\n");
Console.WriteLine("Bienvenido a la simulación del viaje al espacio.");
Console.WriteLine("Estos son tus datos:");

Console.WriteLine("Distancia: " + kmRecorridos);
Console.WriteLine("Combustible: " + combustibleActual);
Console.WriteLine("Escudo: " + escudoActual);

Console.WriteLine("¡Iniciamos el viaje!");
Console.WriteLine("\n");

while (kmRecorridos < DISTANCIA_AL_ESPACIO_KM && combustibleActual > 0)
{
    var esZonaDeEscombros = false;
    var esZonadDeCalma    = false;
    var esZonaNeutral =! esZonaDeEscombros && !esZonadDeCalma;

    string opcion;
    do
    {
        if (esZonaDeEscombros)
        {
            Console.WriteLine("Estás en una zona de escombros.");
        }
        else if (esZonadDeCalma)
        {
            Console.WriteLine("Estás en una zona de calma.");
        }
        else if (esZonaNeutral)
        {
            Console.WriteLine("Estás en una zona neutral.");
        }

        Console.WriteLine("¿Qué acción deseas realizar?");
        Console.WriteLine("1. Ascender");
        Console.WriteLine("2. Esperar");
        opcion = Console.ReadLine() ?? "";

        if (opcion !="1" && opcion != "2")
        {
            Console.WriteLine("Opción inválida, intenta de nuevo.");
        }
    } while (opcion !="1" && opcion != "2");

    if (opcion == "1")
    {
        Console.WriteLine("Ascendiendo...");
        kmRecorridos      += ASCENSO_POR_TURNO;
        combustibleActual -= COMBUSTIBLE_POR_TURNO;
        Console.WriteLine("Distancia: " + kmRecorridos);
        Console.WriteLine("Combustible: " + combustibleActual);
        Console.WriteLine("Escudo: " + escudoActual);

    }
    else if (opcion == "2")
    {
        Console.WriteLine("Esperando...");
        escudoActual = Math.Min(ESCUDO_MAXIMO, escudoActual + ESCUDO_POR_TURNO);
        kmRecorridos = Math.Max(0, kmRecorridos - PERDIDA_KM_POR_TURNO);
        Console.WriteLine("Escudo: " + escudoActual);
        Console.WriteLine("Distancia: " + kmRecorridos);
    }
}

if (kmRecorridos >= DISTANCIA_AL_ESPACIO_KM)
{
    Console.WriteLine("¡Llegaste al espacio!");
}
else
{
    Console.WriteLine("No llegaste al espacio.");
}
