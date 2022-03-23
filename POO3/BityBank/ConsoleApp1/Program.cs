using BityBank.Funcionarios;
using BityBank.Sistemas;

namespace BityBank
{
    public class Program
    {
         public static void Main(string[] args)
        {
           CalcularBonificaco();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("016.066.077-55");
            roberta.Nome = "Roberta Campos";
            roberta.Senha = "abc";
            sistemaInterno.Logar(roberta, "abc");

            GerenteDeConta astoufo = new GerenteDeConta("030.889.555-22");
            astoufo.Nome = "Astoufo Pinto da Cunha";
            astoufo.Senha = "123";
            sistemaInterno.Logar(astoufo, "123");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "xyz";
            sistemaInterno.Logar(parceiro, "xyz");

        }
        public static void CalcularBonificaco() //Método statico para que o Main funcione, pq não dá para chamar um método de instancia a partir de um método statico
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("015.236.963-00");
            pedro.Nome = "Pedro Ramos";
                                
            Auxiliar ivete = new Auxiliar("020.266.555-88");
            ivete.Nome = "Ivete Sangalo";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(ivete);
            Console.WriteLine("Total de bonificações no mês: " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
              
    }
}
