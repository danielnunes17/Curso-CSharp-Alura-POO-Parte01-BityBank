namespace _07_BityBank
    
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(057, 12345678);
            Console.WriteLine("Agencia: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Numero);
            Console.WriteLine("Número de contas criadas até o momento: " +ContaCorrente.TotaldeContasCriadas);

            ContaCorrente contaDoGabriel = new ContaCorrente(050, 12345671);
            Console.WriteLine("Agencia: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Numero);
            Console.WriteLine("Número de contas criadas até o momento: " + ContaCorrente.TotaldeContasCriadas);
        }

    }
}