using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BityBank.Sistemas
{

    public class ParceiroComercial : IAutenticavel //implementa a interface
    {
        //Essa repetição de código aqui, é apenas uma coincidencia, poque essa classe não participa da hierarquia de um funcionario, essa classe nada tem haver com o banco BityBank
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
