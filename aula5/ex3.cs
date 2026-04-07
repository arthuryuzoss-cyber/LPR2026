using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main(string[] args)
    {
        int contagem = 0;
        
        for (int i=50;  i <= 500; i ++) 
        {
            if (i % 3 == 0 && i % 2 != 0)
            {

                contagem++;
            }
        }
        Console.WriteLine($"a quantidade de numeros impares e multiplos de 3 sao "+ contagem);
    }
}