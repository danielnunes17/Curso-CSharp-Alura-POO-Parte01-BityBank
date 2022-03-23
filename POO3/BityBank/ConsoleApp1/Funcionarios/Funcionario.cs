using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BityBank.Funcionarios
{
    public abstract class Funcionario //Abstract palavra reservada para o C# entender que funcionário é uma abstração e não deve ser diretamente instaciado, só devemos instaciar de classes concretas
    {
        //quando for 0 será funcionário
        //quando for 1 será cargo executivo
        public static int TotaldeFuncionarios { get; private set; }

        public string Senha { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } //palavra reservada protected para proteger porém permitir o acesso e mudanças para quem estiver dentro da classe

        //Incrementando o "TotalDeFuncionarios criamos um construtor:
        public Funcionario(double salario,  string cpf) //o C# sempre cria um construtor sem argumentos para a classe herdeira e para a base também
        {
            CPF = cpf; //Criando um construtor para que o CPF seja um campo obrogatório a ser preenchido cpf é o argumento CPF é a propriedade
            Salario = salario; //Criando um construtor para que o Salario seja um campo obrogatório a ser preenchido como um salário inicial
            TotaldeFuncionarios++;

            Console.WriteLine("Criando cadastro de Funcionário...");
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
        public abstract void AumentarSalario(); //Abstract as classes filhas serão obrigadas a implementar esse método, membros abstratos, métodos abstratos só podem fazer parte de classes abstratas
        public abstract double GetBonificacao(); //Criando um método baseado na regra de negocio, usando a palavra resrvada virtual na classe base, para conseguir sobrescrever o método

    }
}
