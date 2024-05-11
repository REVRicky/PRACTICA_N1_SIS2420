// See https://aka.ms/new-console-template for more information
using System;

public static class NumerosALetras
{
    private static string[] unidades = {"cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"};
    private static string[] especiales = {"diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve"};
    private static string[] decenas = {"", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"};
    private static string[] centenas = {"", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"};
    
    public static string ConvertirALetras(int numero)
    {
        if (numero < 10)
        {
            return unidades[numero];
        }
        else if (numero < 20)
        {
            return especiales[numero - 10];
        }
        else if (numero < 100)
        {
            int decena = numero / 10;
            int unidad = numero % 10;
            if (unidad == 0)
            {
                return decenas[decena];
            }
            else
            {
                return decenas[decena] + " y " + unidades[unidad];
            }
        }
        else
        {
            int centena = numero / 100;
            int decena = (numero % 100) / 10;
            int unidad = numero % 10;
            if (decena == 0 && unidad == 0)
            {
                return centenas[centena];
            }
            else
            {
                return centenas[centena] + " " + ConvertirALetras(numero % 100);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        string resultado = NumerosALetras.ConvertirALetras(numero);

        Console.WriteLine("Salida:");
        Console.WriteLine(resultado);
    }
}