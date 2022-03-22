namespace _02_BityBank
{
    class Program
    {
        public static void Main(string[] args) //VALORES PADRÃO
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Titular = "Haroldo Costa";

            Console.WriteLine(conta.Titular);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Conta);
            Console.WriteLine(conta.Saldo);

            //Valores padrões para int e double é 0
                   
        }
    }
}