// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Pontos");
Console.WriteLine("2. PontoLinha");
Console.WriteLine("3. PontoBarra");
Console.WriteLine("4. PontoBarraCheia");
Console.WriteLine("5. PontoBarraNatal");
Console.WriteLine("6. Pares");
Console.WriteLine("7. Nomes");

var input = Console.ReadLine();

switch (input)
{
    case "1":
        Pontos p = new();
        p.Executar(6);
        break;
    case "2":
        PontoLinha l = new();
        l.Executar(8);
        break;
    case "3":
        PontoBarra b = new();
        b.Executar(5);
        break;
    case "4":
        PontoBarraCheia c = new();
        c.Executar(6);
        break;
    case "5":
        PontoBarraNatal n = new();
        n.Executar(10);
        break;
    case "6":
        Pares f = new();
        f.Executar(100);
        break;
    case "7":
        Nomes e = new();
        e.Executar("abcde");
        break;
}


