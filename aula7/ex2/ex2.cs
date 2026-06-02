using System;
class Program
{
    static void Main(string[] args)
    {
       
        int[] vetor = new int[10]; 
           Console.WriteLine("Digite 10 números:"); // digitar os 10 numeros para preencher o vetor
        for (int i = 0; i < 10; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }
     

        Console.WriteLine("Digite um número para pesquisar no vetor:"); 
        int numeroPesquisar = int.Parse(Console.ReadLine());

        bool encontrado = false;
        int contador = 0;

        for (int i = 0; i < 10; i++)
        {
            if (vetor[i] == numeroPesquisar)  // verificar se o numero digitado para pesquisar é igual a algum numero do vetor
            {
                encontrado = true;
                contador++;
                Console.WriteLine($"Número encontrado na posição {i}");
            }
        }

        if (encontrado==false )
        {
            Console.WriteLine("Número não encontrado no vetor.");
        }
        else
        {
            Console.WriteLine($"O número {numeroPesquisar} aparece {contador} vez(es) no vetor.");
        }
    }
}