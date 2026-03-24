using System;

class Programs
{
    static void Main(string[] args)
    {   Console.WriteLine("Bem-vindo ao RPG!");
        Console.WriteLine("Digite a classe do seu personagem (Guerreiro, Mago, Arqueiro):");
        string classe = Console.ReadLine();
        if (classe == "Guerreiro")
        {
            Console.WriteLine("Você escolheu a classe Guerreiro. Ataque pesado e Defesa total são suas principais características.");
        }
        else if (classe == "Mago")
        {
            Console.WriteLine("Você escolheu a classe Mago. Bola de fogo e escudo de gelo são suas principais características.");
        }
        else if (classe == "Arqueiro")
        {
            Console.WriteLine("Você escolheu a classe Arqueiro. disparo triplo e flecha precisa são suas principais características.");
        }
        else
        {
            Console.WriteLine("Classe inválida. Por favor, escolha entre Guerreiro, Mago ou Arqueiro.");
        }

        Console.WriteLine($"Classe: {classe}, ");
    }
}       