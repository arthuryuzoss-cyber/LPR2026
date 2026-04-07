sing System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 100);
        Console.WriteLine("---------------JOGO DA ADIVINHAÇÃO");
        Console.WriteLine("Digite um número aleatório e tente acertar: ");
        do
        {
            
            numero = int.Parse(Console.ReadLine());
            if (numero > valorInteiro)
            {
                Console.WriteLine("Você digitou um numero maior do que o correto tente novamente: ");
            }
            else if (numero < valorInteiro)
     
            {
                Console.WriteLine("Você digitou um numero menor do que o correto tente novamente: ");
            }
            else
            {
                Console.WriteLine("Parabéns você acertou o numero correto ");
                return;
            }
        } while (numero != 0);
     

    }
}