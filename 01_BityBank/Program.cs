namespace _01_BityBank;
class Program
{
    public static void Main(string[] args)
    {
       ContaCorrente contaDaGabriela = new ContaCorrente(); //Declarando Objeto, criando uma instancia da classe conta corrente, referecia ou variável contaDaGabriela

        contaDaGabriela.Titular = "Gabriela Garcia";
        contaDaGabriela.Agencia = 1013;
        contaDaGabriela.Conta = 000023155;
        contaDaGabriela.Saldo = 300;

        Console.WriteLine("Cliente: " + contaDaGabriela.Titular);
        Console.WriteLine("Agencia: " + contaDaGabriela.Agencia);
        Console.WriteLine("Conta Corrente: " + contaDaGabriela.Conta);
        Console.WriteLine("Saldo atual: " + contaDaGabriela.Saldo);

        contaDaGabriela.Saldo += 200;
        Console.WriteLine("Lançamentos futuros: " + contaDaGabriela.Saldo);

    }
}