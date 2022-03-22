namespace _05_BityBank;
class Program //A classe busca as informações passadas dentro do namespace
{
    public static void Main(string[] args)
    {
        Cliente gabriela = new Cliente(); //Criando um objeto do tipo Cliente, o termo "populando o objeto" é usado quando colocamos as informações 

        gabriela.nome = "Gabriela Nunes";
        gabriela.profissao = "Advogada";
        gabriela.cpf = "015.402.556-17";

        ContaCorrente conta = new ContaCorrente();

        conta.Titular = gabriela; //a referencia da conta.Titular é a mesma refrencia da variavel gabriela
        conta.Agencia = 563;
        conta.Conta = 452756;
        conta.Saldo = 500;

        conta.Titular.nome = "Osmar Prado"; //Quando faço isso eu insiro a mesma informãção tanto na variavel gabriela quando no titular, porque estou acessando o mesmo objeto, ambos estão alocado no mesmo local da memória do computador

        Console.WriteLine(gabriela.nome); //acesso a variavel gabriela
        Console.WriteLine(conta.Titular.nome); //tenho acesso ao campo titular que é o mesmo objeto acessado através do nome
       
        //IMPORTANTE - o valor padrão de um tipo de refrencia é Nulo
    }
        
}