    public struct Livro
    {
        public string autor;
        public int AnoPublicado;
        public int numeroPaginas;
      public int preco;
    }
class Program
{
    static void Main(string[] args)
    {
        Livro[] livro = new Livro[3];
     for (int i=0; i<3; i++)
     {
   Console.WriteLine($"Livro {i+1}");
        Console.WriteLine("Digite o nome do autor:");
        livro[i].autor = Console.ReadLine();
        Console.WriteLine("Digite o ano de publicação:");
        livro[i].AnoPublicado = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de páginas:");
        livro[i].numeroPaginas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o preço do livro:");
        livro[i].preco = int.Parse(Console.ReadLine());
     }
        Console.WriteLine($"Preço: {livro[0].preco+livro[1].preco+livro[2].preco}");
        int media = (livro[0].numeroPaginas+livro[1].numeroPaginas+livro[2].numeroPaginas)/3; 
        Console.WriteLine($"Média de paginas {media}");
     }
}