public class PontoBarra
{
    public int[][] Executar(int pontos)
    {
        int[][] retorno = new int[pontos][];

        for (int i = 0; i < pontos; i++)
        {
            retorno[i] = new int[pontos];
            int j = 0;
            for (; j < i; j++)
            {
                retorno[i][j] = 1;
            }
            retorno[i][j] = 2;
        }
        return retorno;
    }
}