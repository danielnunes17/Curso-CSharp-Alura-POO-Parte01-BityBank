using BityBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BityBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel //Herança
    {
        public string Senha { get; set; }
        public Diretor(string cpf) : base(15000, cpf) //O construtor de Diretor chamando o construtor da classe base Funcionario dessa forma eu consigo passar um novo cpf a cada cadastro de um novo funcionário
        {
            Console.WriteLine("Criando cadastro de Diretor...");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15; //maneira de escrever mais simples o aumento de 15% para Diretores conforme regra de negócio
        }
        public override double GetBonificacao()//usando a palavra reservada override na classe derivada para sobreescrever o comportamento do funcionario44

        {
            return Salario * 0.5; //Declarando a regra de negócio que diz que a bonificação dos Diretores será de 50%, 
          
        }
    }
}
