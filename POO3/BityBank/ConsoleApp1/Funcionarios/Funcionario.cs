using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BityBank.Funcionarios
{
    public class Funcionario
    {
        //quando for 0 será funcionário
        //quando for 1 será cargo executivo


        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao() //Criando um método baseado na regra de negocio
        {
            return Salario * 0.20;
        }
    }
}
