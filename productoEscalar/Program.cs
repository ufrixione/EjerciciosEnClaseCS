int[] vectorA = { 1, 2, 3, 4, 5 };
int[] vectorB = { 5, 4, 3, 2, 1 };
        
int productoEscalar = 0;
for (int i = 0; i < vectorA.Length; i++)
{
int resultadoMultiplicacion = vectorA[i] * vectorB[i];
 productoEscalar += resultadoMultiplicacion;
Console.WriteLine($"Posición {i}: {vectorA[i]} * {vectorB[i]} = {resultadoMultiplicacion}");
}
Console.WriteLine($"\nEl producto escalar total es: {productoEscalar}");
