using System;

class Program
{
    static void Main()
    {
        string h1 = "", h2 = "", h3 = "", h4 = "", h5 = "";
        string p1 = "", p2 = "", p3 = "", p4 = "", p5 = "";
        int pt1 = 0, pt2 = 0, pt3 = 0, pt4 = 0, pt5 = 0;

        string th1 = "", th2 = "", th3 = "";
        string tp1 = "", tp2 = "", tp3 = "";
        int tpt1 = 0, tpt2 = 0, tpt3 = 0;

        string opt = "";

        while (opt != "4")
        {
            Console.WriteLine("\n1- cadastrar herois | 2- selecionar equipe | 3- ver equipe | 4- sair");
            Console.Write("opcao: ");
            opt = Console.ReadLine();

            if (opt == "1")
            {
                Cadastrar(1, ref h1, ref p1, ref pt1);
                Cadastrar(2, ref h2, ref p2, ref pt2);
                Cadastrar(3, ref h3, ref p3, ref pt3);
                Cadastrar(4, ref h4, ref p4, ref pt4);
                Cadastrar(5, ref h5, ref p5, ref pt5);
                Console.WriteLine("\nos 5 herois foram cadastrados!");
            }
            else if (opt == "2")
            {
                if (h1 == "")
                {
                    Console.WriteLine("erro: cadastre os herois na opcao 1 primeiro.");
                }
                else
                {
                    Selecionar(h1, p1, pt1, h2, p2, pt2, h3, p3, pt3, h4, p4, pt4, h5, p5, pt5,
                              ref th1, ref tp1, ref tpt1, ref th2, ref tp2, ref tpt2, ref th3, ref tp3, ref tpt3);
                }
            }
            else if (opt == "3")
            {
                Exibir(th1, tp1, tpt1, th2, tp2, tpt2, th3, tp3, tpt3);
            }
        }
    }

    static void Cadastrar(int n, ref string nome, ref string poder, ref int pts)
    {
        Console.WriteLine("\n--- heroi " + n + " ---");
        Console.Write("nome: ");
        nome = Console.ReadLine();
        Console.Write("poder: ");
        poder = Console.ReadLine();
        Console.Write("pontuacao: ");
        pts = int.Parse(Console.ReadLine());
    }

    static void Selecionar(string h1, string p1, int pt1, string h2, string p2, int pt2,
                          string h3, string p3, int pt3, string h4, string p4, int pt4,
                          string h5, string p5, int pt5,
                          ref string s1, ref string sp1, ref int st1,
                          ref string s2, ref string sp2, ref int st2,
                          ref string s3, ref string sp3, ref int st3)
    {

        Console.WriteLine("\nopcoes: 1-" + h1 + " 2-" + h2 + " 3-" + h3 + " 4-" + h4 + " 5-" + h5);

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("escolha o " + i + "º heroi (1-5): ");
            int esc = int.Parse(Console.ReadLine());

            string n = ""; string p = ""; int pt = 0;

            if (esc == 1) { n = h1; p = p1; pt = pt1; }
            else if (esc == 2) { n = h2; p = p2; pt = pt2; }
            else if (esc == 3) { n = h3; p = p3; pt = pt3; }
            else if (esc == 4) { n = h4; p = p4; pt = pt4; }
            else if (esc == 5) { n = h5; p = p5; pt = pt5; }

            if (i == 1) { s1 = n; sp1 = p; st1 = pt; }
            else if (i == 2) { s2 = n; sp2 = p; st2 = pt; }
            else if (i == 3) { s3 = n; sp3 = p; st3 = pt; }
        }
        Console.WriteLine("equipe selecionada!");
    }

    static int CalcularTotal(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Exibir(string h1, string p1, int pt1, string h2, string p2, int pt2, string h3, string p3, int pt3)
    {
        if (h1 == "")
        {
            Console.WriteLine("selecione o time na opcao 2 antes de exibir.");
            return;
        }

        Console.WriteLine("--- equipe ---");
        Console.WriteLine(h1 + " (" + p1 + ") - " + pt1 + " pts");
        Console.WriteLine(h2 + " (" + p2 + ") - " + pt2 + " pts");
        Console.WriteLine(h3 + " (" + p3 + ") - " + pt3 + " pts");

        int total = CalcularTotal(pt1, pt2, pt3);
        Console.WriteLine("pontuacao total: " + total);
        Console.WriteLine("\npressione qualquer tecla para acaba");
        Console.ReadKey();
    }
}