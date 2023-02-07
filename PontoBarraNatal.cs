public class PontoBarraNatal
{
    public void Executar(int pontos)
    {
        for (int i = 0; i < pontos; i++)
        {
            for (int j = 0; j < pontos; j++)
            {
                if (i + j == pontos - 1)
                {
                    Console.Write("/");
                }

                else if (i + j < pontos -1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(".");
                }
            }

            for (int j = 0; j < pontos; j++)
            {
                if (i == j)
                {
                    Console.Write("\\");
                }

                else if (j > i)
                {
                    Console.Write(" ");
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
