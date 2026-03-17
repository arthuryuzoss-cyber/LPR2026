using System;
class Program

{
static void Main(string[] args)
{
Console.WriteLine("Digite seu numero da empresa: ");
int F= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite seu numero de horas trabalhadas: ");
int H= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor que voce recebe em horas: ");
int V= Convert.ToInt32(Console.ReadLine());
int salario= (H*V);
 Console.WriteLine ($"Voce {F} tem o seu salario de:{salario} Reais");

}
}