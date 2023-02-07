public class PontoBarraNatal
{
    public int[][] Executar(int pontos)
    {
        var retorno = new int[pontos][];
        for (int i = 0; i < pontos; i++)
        {
            retorno[i] = new int[pontos * 2];
            for (int j = 0; j < pontos; j++)
            {
                if (i + j == pontos - 1)
                {
                    retorno[i][j] = 2;
                }

                else if (i + j < pontos - 1)
                {
                    retorno[i][j] = 3;
                }
                else
                {
                    retorno[i][j] = 1;
                }
            }

            for (int j = 0; j < pontos; j++)
            {
                if (i == j)
                {
                    retorno[i][pontos + j] = 4;
                }

                else if (j > i)
                {
                    retorno[i][pontos + j] = 3;
                }
                else
                {
                    retorno[i][pontos + j] = 1;
                }
            }
        }
        return retorno;
    }
}
