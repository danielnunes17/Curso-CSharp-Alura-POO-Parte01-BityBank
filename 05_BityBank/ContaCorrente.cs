
namespace _05_BityBank
{
    public class ContaCorrente
    {
        public Cliente Titular;
        public int Agencia;
        public int Conta;
        public double Saldo = 100;

        public bool Sacar(double valor) //Função, toda função representa uma ação (verbos), sempre usar a primeira letra Maiuscula e o verbo no infitivivo. Chamamos de função quando ele retorna algo
        {
            if (this.Saldo < valor) //This para acessar os dados dessa instancia, desse objeto
            {
                return false;
            }

            this.Saldo -= valor;
            return true;

        }

        public void Depositar(double valor) //Void sem retorno, vazio, chamamos de Métodos quando não há retorno
        {
            this.Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente ContaDestino) //Usando o "ContaCorrente" como argumento
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            ContaDestino.Depositar(valor); //Utilizando a declaração do método depositar 
            return true;

        }
    }

}

