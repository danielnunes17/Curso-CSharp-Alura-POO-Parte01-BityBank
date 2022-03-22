
namespace _07_BityBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; } //o compilador cria tudo debaixo dos panos
        private int _agencia;
        public int Agencia
        {
            get { return _agencia; }
            set { 
                if(_agencia < value)
                {
                    _agencia = value;
                }
            }
        }
        public int Numero { get; set; }
        public int Conta { get; set; }
        private double _Saldo = 500; //Ecapsulamento, manupulamos através dos métodos, usar o _ para campo private
        public static int TotaldeContasCriadas { get; private set; } // Caracteristica da classe - Static diz que essa é uma propriedade que pertence apenas a essa classe, todos os objetos dentro da classe tem acesso a ela, seclarando o set como private eu proibo inserção de dados errados, isso tem haver com a regra de negócio, é uma forma de proteger os dados
        public double Saldo
        {
            get { return _Saldo; } //get Sempre retorna
            set { //set defini o valor
                if(value < 0) //value que seria o nome do argumento palavra reservada para uso dentro do contexto set
                {
                    return;
                }
                _Saldo = value;
                }
        }

        //public void SetSaldo(double saldo) //criando um método para definição de saldo, Set para definir
        //{
        //    if(saldo < 0)
        //    {
        //        return;

        //    }
        //    Saldo = saldo;
        //}
        //public double GetSaldo() //declarando um método para acessar o saldo, Get para obter
        // {
        // return Saldo; //retorna o saldo, mas sem altera-lo
        // } 

        public ContaCorrente(int agencia, int numero) //Método construtor, regra de negócio: tada conta precisa de uma agencia e um número. Estou obrigando o console a inserir essas informações
        {
            Agencia = agencia;
            Numero = numero;

            ContaCorrente.TotaldeContasCriadas++; //Todas as vezes que essa variável for acessada, ela vai incrementar. Quando estamos manipulando membros estáticos não é necessário declarar por isso está apagado
        }
        public bool Sacar(double valor) //Função, toda função representa uma ação (verbos), sempre usar a primeira letra Maiuscula e o verbo no infitivivo. Chamamos de função quando ele retorna algo
        {
            if (_Saldo < valor) //This para acessar os dados dessa instancia, desse objeto
            {
                return false;
            }

            _Saldo -= valor;
            return true;

        }

        public void Depositar(double valor) //Void sem retorno, vazio, chamamos de Métodos quando não há retorno
        {
            _Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente ContaDestino) //Usando o "ContaCorrente" como argumento
        {
            if (_Saldo < valor)
            {
                return false;
            }

            _Saldo -= valor;
            ContaDestino.Depositar(valor); //Utilizando a declaração do método depositar 
            return true;

        }
    }

}

