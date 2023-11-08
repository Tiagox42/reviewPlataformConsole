// See https://aka.ms/new-console-template for more information
using reviewPlataformConsole.Entities.Media;
using reviewPlataformConsole.Entities.Media.Comments;
using reviewPlataformConsole.Entities.Media.MediaTypes;

Console.WriteLine("PLATAFORMA DE REVIEWS");
Console.WriteLine("----- ----- ----- -----");
Menu();


void Menu() {
    Console.WriteLine("\nPor gentileza digite a opção desejada:");
    Console.WriteLine("\n1 - Criar objeto TesteMedia");
    Console.WriteLine("2 - Exibir objetos TesteMedia");
    Console.WriteLine("\n9 - Encerrar programa;");
    Console.Write("\nOpção: ");

    try
    {
        int opcao;
        opcao = int.Parse(Console.ReadLine());
        if (opcao == 1)
        {
            CriaTesteMedia();
        }
        else if (opcao == 2)
        {
            CriaTesteMedia();
        }
        else if (opcao == 9)
        {
            Console.WriteLine("\nAté mais!!");
        }
        else
        {
            Console.WriteLine("\nVocê não digitou uma opção válida");
            Menu();
        }

    }
    catch
    {
        Console.WriteLine("\nVocê não digitou uma opção válida");
        Menu();
    }
}

void CriaTesteMedia()
{
    Console.WriteLine("Digite o nome do teste:");
    string title = Console.ReadLine();
    Console.WriteLine("\nDigite o nome da desenvolvedora:");
    string developer = Console.ReadLine();
    Console.WriteLine("Digite a quantidade de pontos positivos:");
    int positivo = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de pontos negativos:");
    int negativo = int.Parse(Console.ReadLine());
    Console.WriteLine("Deseja adicionar comentários no objeto? s / n");
    string opcao = Console.ReadLine();
    List<Comment> listaComentarios = new List<Comment>();
    if (opcao == "s")
    {
        Console.WriteLine("Quantos?");
        int numeroComentarios = int.Parse(Console.ReadLine());
        for (int i = 1; i < numeroComentarios +1; i++)
        {
            Console.WriteLine($"Comentario {i}:");
            Console.WriteLine("Digite o texto em uma frase:");
            string texto = Console.ReadLine();
            Comment comentario = new Comment(texto);
            listaComentarios.Add(comentario);
        }
    }
    TesteMedia objetoTesteMedia = new TesteMedia(developer, negativo, positivo, listaComentarios, title);
    Console.WriteLine("Objeto criado com sucesso!");

    Console.WriteLine("\n\n\n" + objetoTesteMedia);
    Menu();
}

