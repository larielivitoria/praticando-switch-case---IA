Console.WriteLine("Qual o momento do dia? manhã tarde ou noite?");
string momentoDoDia = Console.ReadLine();

Console.WriteLine("Digite seu nome:");
string nome =  Console.ReadLine();

switch (momentoDoDia)
{
    case "manhã":
        Console.WriteLine($"Bom dia, seja muito bem vinda {nome}");
        break;
    case "tarde":
        Console.WriteLine($"Boa tarde, seja muito bem vinda {nome}");
        break;
    case "noite":
        Console.WriteLine($"Boa noite, seja muito bem vinda {nome}");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}