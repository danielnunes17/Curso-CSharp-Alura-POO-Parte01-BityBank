using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BityBank.Funcionarios
{
    internal class Designer : Funcionario
    {
        public Designer(string cpf) : base(2000, cpf) //base para chamar o construtor da classe mãe
        {
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
