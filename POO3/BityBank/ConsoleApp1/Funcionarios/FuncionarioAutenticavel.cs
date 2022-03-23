using BityBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BityBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf) //Construtor
        {
        }

        public bool Autenticar(string senha) //Implementação da classe abstrata
        {
            return senha == Senha; 
        }
    }
}
