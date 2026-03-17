class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade que voce necessita da primeira peça: ");
        int pecaq1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor da primeira peça: ");
        int pecav1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o codigo da segunda peça: ");
        int peca2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a quantidade que voce necessita da segunda peça: ");
        int pecaq2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor da segunda peça: ");
        int pecav2 = Convert.ToInt32(Console.ReadLine());

        int valor = (pecaq1 * pecav1) + (pecaq2 * pecav2);

        Console.WriteLine("O valor a ser pago é: " + valor);
    }
}