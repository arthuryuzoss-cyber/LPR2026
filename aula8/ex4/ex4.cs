
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public struct Herois
    {
      public string nome;
        public int poder;
     public int pontuacao;
     public int total;
     public int equipe;
    };

    public class Program{
      static  Herois[] lista_de_herois = new Herois[5];

      // vetor lista_de_herois[] = [ 
      //                    struct heroi 1,
                                // nome
                                // poder
                                // pontuacao
      //                    struct heroi 2.... struct heroi 5]
      
      static  Herois[] equipe= new Herois[3];
      
      // vetor herois[] = [ 
      //    struct heroi 1,
                                // nome
                                // poder
                                // pontuacao 
      // struct heroi 2, struct heroi 3]
     //static int[] pontuacao = new int[5];    
     //static int[] equipe = new int[3];   
            static void cadastrarHeroi ()
{
   
                for (int i=0; i<5; i++)
        {
            Console.WriteLine($"Heroi {i+1}");
            Console.WriteLine("Digite o nome do heroi:");
            lista_de_herois[i].nome = Console.ReadLine();
            Console.WriteLine("Digite o poder do heroi:");
            lista_de_herois[i].poder = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a pontuacao do heroi:");
            lista_de_herois[i].pontuacao = int.Parse(Console.ReadLine());
        }
}
static void selecionarequipe()
    {
        Console.WriteLine("Selecione os seus herois");
        for (int i=0;i<5;i++){
         Console.WriteLine($"{i+1}-{lista_de_herois[i].nome}");
        }
        Console.WriteLine("Digite o numero do seu heroi");
        for (int i = 0; i < 3; i++)
        {
            
          equipe[i] = lista_de_herois[int.Parse(Console.ReadLine())-1];
          //equipe[i] = int.Parse(Console.ReadLine());
        }
    }
    static void calcularpontuacaototal()
    {
        int da=0;
        for (int w=0; w<3; w++)
        {
            da += equipe[w].pontuacao;
        }
       Console.WriteLine("Pontuacao total "+ da);   
    }
    static void exibirEquipe()
    {
        Console.WriteLine("Sua equipe é ");
        for (int w=0; w<3; w++)
        {
           Console.WriteLine("Nome: "+ equipe[w].nome+" Poder: "+ equipe[w].poder+ " Pontuacao: "+ equipe[w].pontuacao);
        }
        
    }
    static void menuPrincipal()
    {
        Console.WriteLine("-------MENU-----------");
            Console.WriteLine("1-CADASTRO DE HEROIS");
            Console.WriteLine("2-SELEÇÃO DE EQUIPE");
            Console.WriteLine("3-EXIBIÇÃO DE EQUIPE");
            Console.WriteLine("4-SAIR");
            int arthur = int.Parse(Console.ReadLine());
            if (arthur == 1)
        {
            cadastrarHeroi();
        }
        if (arthur ==2)
        {
            selecionarequipe();
        }
       if (arthur == 3)
        {
            exibirEquipe();
        }
       if (arthur == 4)
        {
            return;
        }
        else
        {
            Console.WriteLine("digito invalido");
        }


    }
    static void Main(string[] args)
    {
        menuPrincipal();

      

      
      
        
} 
    }