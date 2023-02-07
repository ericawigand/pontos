public class PontoBarraCheia
{
    public void Executar(int pontos)
    {
        for (int i = 0; i < pontos; i++)
        {
            for (int j = 0; j < pontos; j++)
            {
                if (j == i)
                {
                    Console.Write("\\");

                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}