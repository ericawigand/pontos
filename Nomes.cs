public class Nomes
{
    public void Executar(string letras)
    {
        var tam = letras.Length;
        var i = 0;
        var f = tam -1;

        for(; i <= f; i++, f--)
        {
            Console.Write(letras[i]);

            if(i < f)
            {
                Console.Write(letras[f]);
            }
        }
    }
}