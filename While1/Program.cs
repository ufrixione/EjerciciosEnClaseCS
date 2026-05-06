//leer un numero entero y mostrar el cuadrado de sus antecesores

using System;

int num1;
while (true)
{
    Console.Write("Ingrese un numero entero ");
    if(int.TryParse(Console.ReadLine(), out num1))
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Porfavor, ingrese un numero entero.");
        Console.ResetColor();
    }
} 
Console.WriteLine("Mostrando el cuadrado de los antecedentes de " + num1 + ":");
int cont = 1;
while(cont < num1)
{
    Console.WriteLine("El cuadrado de " + cont + " es: " + Math.Pow(cont, 2));
    cont++;
}