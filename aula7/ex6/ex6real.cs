using System;
class Program
{
    static void Main(string[] args)
    {
        int linha=0;
        int coluna=0;
        int distancia=0;
        
        int[,] matriz = new int[,] {{0, 524,521,882}, {524,0,434,586}, {521,434,0,429},{882,586,429,0}};
        Console.WriteLine("Digite uma das cidades VITORIA,BELO HORIZONTE, RIO DE JANEIRO e SAO PAULO");
        string cidade = Console.ReadLine().ToUpper();
         Console.WriteLine("Digite uma das cidades VITORIA,BELO HORIZONTE, RIO DE JANEIRO e SAO PAULO");
        string city = Console.ReadLine().ToUpper();
       
      
       switch (cidade)
        {
            case "VITORIA": 
                 linha = 0;
                break;
            case "BELO HORIZONTE":
                linha = 1;
                break;
                case "RIO DE JANEIRO":
                linha = 2;
                break;
                case "SAO PAULO":
                linha = 3;
                break;

        } 

        switch (city)
        {
            case "VITORIA": 
                 coluna = 0;
                break;
            case "BELO HORIZONTE":
            coluna=1;
            break;
            case "RIO DE JANEIRO":
            coluna=2;
            break;
            case "SAO PAULO":
            coluna=3;
            break;
            
        } 
       distancia = matriz [linha,coluna];
if (distancia == 0)
        {
            return;
        }
       Console.WriteLine("A distancia entre as duas cidades é de "+ distancia);
    return;
    
    }

  

}
    
