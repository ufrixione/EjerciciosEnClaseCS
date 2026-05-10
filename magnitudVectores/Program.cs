double[] V = { 3, 4, 5, 6, 7 };
double sumaCuadrados = 0;
for (int i = 0; i < V.Length; i++)
{
sumaCuadrados += Math.Pow(V[i], 2);
}
double magnitude = Math.Sqrt(sumaCuadrados);
Console.WriteLine("La magnitud del vector es: " + magnitude);