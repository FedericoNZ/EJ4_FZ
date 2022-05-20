Console.WriteLine("Determine la cantidad de columnas que desea tener:");
int valorC = int.Parse(Console.ReadLine());

Console.WriteLine("\nDetermine la cantidad de filas que desea tener:");
int valorF = int.Parse(Console.ReadLine());

int[,] numeros = new int[valorC,valorF];
double[] promedios = new double[valorC];
double[] suma = new double[valorC];

for (int columna = 0; columna < valorC; columna++)
{
    Console.WriteLine("\n============================================\n");
    Console.WriteLine($"Establecer datos de la columna N° {columna + 1}");

    for(int fila = 0; fila < valorF; fila++)
    {
        Console.WriteLine($"\nIngrese el valor de la fila N° {fila + 1}");
        numeros[columna, fila] = int.Parse(Console.ReadLine());
        suma[columna] += numeros[columna , fila];
        promedios[columna] = suma[columna] / valorF;
    }
}

for (int columna = 0; columna < valorC; columna++)
{
    Console.WriteLine("\n============================================");
    Console.WriteLine($"\nDatos de la columna N° {columna + 1}\n");

    for (int fila = 0; fila < valorF; fila++)
    {
        Console.WriteLine($"Valor de la fila N° {fila + 1}: {numeros[columna, fila]}");
    }
    Console.Write($"\nPromedio de la columna N° {columna + 1}: ");
    Console.WriteLine(promedios[columna]);
}

Console.ReadKey();