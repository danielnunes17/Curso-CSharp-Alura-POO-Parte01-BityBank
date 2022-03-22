namespace _06_BityBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Belmiro Braga";
            cliente.Profissao = "Marceneiro";
            cliente.CPF = "CPF: 123.456-70";
            
            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(cliente.Profissao);
            Console.WriteLine(cliente.CPF);
            Console.WriteLine(conta.Saldo);
          
        }
    
    }
}            