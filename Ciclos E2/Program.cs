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
