using BityBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BityBank.Sistemas
{
    //C# não aceita herança multipla
    //Inteface não implementa um método, ela é apenas um contrato (método, que possui um tipo e tem uma lista de argumentos), não tem implementação e por isso ela não pode ser uma classe, porque é tudo abstrato
    public interface IAutenticavel //caracteristica da interface, não pode ter implementação no método mas toda classe que herdar essa interface deverá ter um método bool e uma string senha
    {
        bool Autenticar(string senha); //Em uma interface todos os membros são publicos
    }
}
