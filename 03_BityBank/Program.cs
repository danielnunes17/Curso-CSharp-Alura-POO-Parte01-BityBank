namespace _03_BityBank
{
    class Program
    {
        public static void Main(string[] args) //TIPO DE VALOR E TIPO DE REFERENCIA
            //Quando criamos uma classe no C#, não temos mais um tipo de valor, mas de refrencia

        {
            ContaCorrente contaDaGabriela = new ContaCorrente(); //quando uso a palavra New estou criando na memória do computador esse objeto, quando eu uso contaDaGabriela = new ContaCorrente(), o = significa a refrencia, é uma flecha apontando na memória onde está guaradado o endereço dessa variável, 

            contaDaGabriela.Titular = "Gabriela Garcia";
            contaDaGabriela.Agencia = 1013;
            contaDaGabriela.Conta = 000023155;
            contaDaGabriela.Saldo = 300;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.Titular = "Gabriela Costa";
            contaDaGabrielaCosta.Agencia = 1013;
            contaDaGabrielaCosta.Conta = 000023155;
            contaDaGabrielaCosta.Saldo = 300;

            Console.WriteLine("Igualdade de tipo de refrencia: " + (contaDaGabriela == contaDaGabrielaCosta)); //"False" pq são objetos diferentes com endereços difentees, mesmo contendo os mesmos dados, mas o que se tem aqui é referencia e não igualdade

            int idade2 = 27;
            int idade1 = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade2 == idade1)); //"True" porque tem o mesmo endereço de memória, aqui é igualdade de tipo de valor e não referencia

            contaDaGabrielaCosta = contaDaGabriela;
            Console.WriteLine("2 váriaveis apontando para o mesmo lugar: " + (contaDaGabriela == contaDaGabrielaCosta)); //"True" Pq atribuimos uma a outra e nesse caso a igualdade é de valor e não de referencia

            contaDaGabriela.Saldo = 300;
            Console.WriteLine(contaDaGabriela.Saldo);
            Console.WriteLine(contaDaGabrielaCosta.Saldo); //Aqui terão o mesmo saldo porque estão recebendo a referencia do mesmo objeto

        }
    }
}