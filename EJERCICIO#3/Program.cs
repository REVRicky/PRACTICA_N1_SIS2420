using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese 10 números separados por comas:");
        string entrada = Console.ReadLine();
        List<int> numeros = entrada.Split(',').Select(int.Parse).ToList();

        // Ordenar la lista utilizando expresiones lambda
        List<int> listaOrdenadaLambda = numeros.OrderBy(x => x).ToList();
        Console.WriteLine("Lista ordenada por expresiones lambda: " + string.Join(",", listaOrdenadaLambda));

        // Ordenar la lista utilizando consultas LINQ
        List<int> listaOrdenadaLinq = (from num in numeros
                                        orderby num
                                        select num).ToList();
        Console.WriteLine("Lista ordenada por consultas LINQ: " + string.Join(",", listaOrdenadaLinq));

        // Encontrar el menor y el mayor número en la lista
        int menor = numeros.Min();
        int mayor = numeros.Max();
        Console.WriteLine("Menor: " + menor);
        Console.WriteLine("Mayor: " + mayor);
    }
}