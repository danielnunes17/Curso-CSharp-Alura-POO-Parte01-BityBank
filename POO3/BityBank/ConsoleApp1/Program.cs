using BityBank.Funcionarios;

namespace BityBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos Ramalho";
            carlos.CPF = "202.203.204-48";
            carlos.Salario = 5000;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
        }
      
        
    }
}
