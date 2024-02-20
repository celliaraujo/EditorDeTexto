namespace EditorDeTexto;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------");
        Console.WriteLine(" ------ Editor de Texto ------ ");
        Console.WriteLine("===============================");
        Console.WriteLine("  Selecione o que deseja fazer ");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("1) Abrir Arquivo");
        Console.WriteLine("2) Criar Novo Arquivo");
        Console.WriteLine("0) Sair da Aplicação");

        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 0: System.Environment.Exit(0); break;
            case 2: Editar(); break;

        }
    }

    static void Abrir() { }

    static void Editar()
    {
        Console.Clear();

        Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        Console.WriteLine("---------------------------------------");

        string texto = "";

        do
        {
            texto += Console.ReadLine();
            texto += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.Write(texto);


    }


}
