using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[,] matrizUno = {
            {17, 9, 36},
            {8, 7, 3},
            {15, 28, 57}
        };

        var elementos = matrizUno.Cast<int>().ToList();

        elementos = elementos.OrderBy(e => e).ToList();
        double mediana;

        if (elementos.Count % 2 == 0)
        {
         
            int indiceMedio1 = elementos.Count / 2 - 1;
            int indiceMedio2 = elementos.Count / 2;
            mediana = (elementos[indiceMedio1] + elementos[indiceMedio2]) / 2.0;
        }
        else
        {
            int indiceMedio = elementos.Count / 2;
            mediana = elementos[indiceMedio];
        }

        Console.WriteLine($"Elementos ordenados: {string.Join(",", elementos)}");
        Console.WriteLine($"Mediana: {mediana}");

        Console.ReadLine();
    }
}
