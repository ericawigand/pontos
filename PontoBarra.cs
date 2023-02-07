public class PontoBarra
{
   public void Executar(int pontos)
    {
        for (int i = 0; i < pontos; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine("\\");
        }
    }
}