namespace _04_BityBank;
class Program
{
    public static void Main(string[] args)
    {
        ContaCorrente contaDoBruno = new ContaCorrente();

        contaDoBruno.Titular = "Bruno Neves";

        Console.WriteLine("Seu saldo é de: R$" + contaDoBruno.Saldo);

        bool resultadoSaque = contaDoBruno.Sacar(50); //Acessando a função, o que está entre parentese é o argumento, é nele que passo os valores que quero na função, nesse caso vai acessar o double que declaramos ao criar a função

        Console.WriteLine("Seu saldo atual é: R$" + contaDoBruno.Saldo);
        Console.WriteLine(resultadoSaque);

        contaDoBruno.Depositar(1000);
        Console.WriteLine(contaDoBruno.Saldo);

        ContaCorrente contaDaGabriela = new ContaCorrente();
        contaDaGabriela.Titular = "Gabriela";

        Console.WriteLine("Saldo Bruno: " + contaDoBruno.Saldo);
        Console.WriteLine("Saldo Gabriela: " + contaDaGabriela.Saldo);

        bool resultTansferencia = contaDoBruno.Transferir(200, contaDaGabriela); //invocamos o método passando esses argumentos entre ()

        Console.WriteLine("Saldo Bruno: " + contaDoBruno.Saldo);
        Console.WriteLine("Saldo Gabriela: " + contaDaGabriela.Saldo);
        Console.WriteLine("Retorno da tranferencia: " + resultTansferencia);
    }
}