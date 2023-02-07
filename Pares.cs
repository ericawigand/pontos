public class Pares
{
    public void Executar(int numeros)
    {
        for(int i = 0; i <= numeros; i++)
        {
            if (i % 2 == 0)
            {
                
                Console.Write($"{i} - ");
            }
            
        }
        Console.WriteLine();
    }
}
