public class Cachorro
{
    public string nome;
    public string raca;

    public void Latir(string barulho/*é um parametro(você pode passar quantos parametros forem necessarios)*/) 
    {
        Console.WriteLine("O cachorro " + nome + " é da raça " + raca + " e faz "  + barulho);
    }

}
