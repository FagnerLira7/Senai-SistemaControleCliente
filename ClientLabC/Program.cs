using System;

namespace ClienLabC
{
    class Program
    {
        static void Main(string[] args)
        {
            var pF = new List<PessoaFisica>(){
             new PessoaFisica(){nome=Console.ReadLine(),cpf=Console.ReadLine(),dataNascimento=Console.ReadLine()},
             //new PessoaFisica(){nome=Console.ReadLine(),cpf=Console.ReadLine(),dataNascimento=Console.ReadLine()}
            };
            foreach(var item in pF){
                item.PagarImpostos();
            };
        
            
             
        }
    }
}