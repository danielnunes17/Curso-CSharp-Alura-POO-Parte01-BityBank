using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BityBank.Funcionarios
{
    public class Diretor : Funcionario //Herança
    {
        public double GetBonificacao()
        {
            return Salario;
        }
    }
}
