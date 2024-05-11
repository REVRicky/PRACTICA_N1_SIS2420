using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Salida:");
        Console.WriteLine("Serie 1: " + GenerarSerie1(numero));
        Console.WriteLine("Serie 2: " + GenerarSerie2(numero));
        Console.WriteLine("Serie 3: " + GenerarSerie3(numero));
    }

    static string GenerarSerie1(int n)
    {
        string serie = "";
        int resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
            serie += resultado + ", ";
        }
        return serie.TrimEnd(',', ' ');
    }

    static string GenerarSerie2(int n)
    {
        string serie = "";
        for (int i = 1; i <= n; i++)
        {
            serie += (i * 3) + ", ";
        }
        return serie.TrimEnd(',', ' ');
    }

    static string GenerarSerie3(int n)
    {
        string serie = "";
        for (int i = 1; i <= n; i++)
        {
            serie += (i * 6) + ", ";
        }
        return serie.TrimEnd(',', ' ');
    }
}