int[] vector1 = new int [5];
int[] vector2 = new int [5];
int[] sumaVector = new int [5];

Console.WriteLine("Ingrese los elementos del primer vector:");
    for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar la entrada
        Console.ResetColor();
    }
}
Console.WriteLine("Ingrese los elementos del segundo vector:");
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar la entrada
        Console.ResetColor();
    }
}
for (int i = 0; i < vector1.Length; i++)
{
    sumaVector[i] = vector1[i] + vector2[i];
}
for (int i = 0; i < sumaVector.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"La suma de los elementos en la posición {i + 1} es: {sumaVector[i]}");
    Console.ResetColor();
}