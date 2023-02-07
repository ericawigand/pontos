// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Pontos");
Console.WriteLine("2. PontoLinha");
Console.WriteLine("3. PontoBarra");
Console.WriteLine("4. PontoBarraCheia");
Console.WriteLine("5. PontoBarraNatal");
Console.WriteLine("6. Pares");
Console.WriteLine("7. Nomes");

var input = Console.ReadLine();

var dicio = new Dictionary<int, string> {
    {0, ""},
    {1, "#"}, 
    {2, "\\"},
    {3, " "},
    {4, "/"}

};

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
        Imprime(b.Executar(5), dicio);
        break;
    case "4":
        PontoBarraCheia c = new();
        c.Executar(6);
        break;
    case "5":
        PontoBarraNatal n = new();
        Imprime(n.Executar(10), dicio);
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

void Imprime(int[][] arr, Dictionary<int, string> dicionario)
{
    Console.Clear();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("[ ");
        Console.Write(string.Join(' ', arr[i]));
        Console.WriteLine(" ]");
    }

Console.WriteLine();

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr[i].Length; j++)
        {
            Console.Write(dicionario[arr[i][j]]);
        }
        Console.WriteLine();
    }

}

