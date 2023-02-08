using System;

namespace ClienLabC
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            float valorPago;
            Console.WriteLine("Digite seu nome: ");
            string varNome =Console.ReadLine();
            Console.WriteLine("Digite seu endereço: ");
            string varEndereco =Console.ReadLine();
            //Definir tipo pessoa
            string tipoPessoa;
            Console.WriteLine("Digite (f) se você é pessoa fisica ou (j) caso seja Pessoa Juridica. ");
             tipoPessoa = Console.ReadLine();
            if (tipoPessoa == "f")
            {
            PessoaFisica pF = new PessoaFisica();
            pF.nome = varNome;
            pF.endereco= varEndereco;
            Console.WriteLine("Digite seu CPF: ");
            pF.cpf = Console.ReadLine();
            Console.WriteLine("Digite seu RG: ");
            pF.rg = Console.ReadLine();
            Console.WriteLine("Informe o valor da Compra: ");
            valorPago=float.Parse(Console.ReadLine());
            pF.PagarImpostos(valorPago);
            Console.WriteLine("-------- Pessoa Física ---------");
                    Console.WriteLine("Nome ..........: " + pF.nome);
                    Console.WriteLine("Endereço ......: " + pF.endereco);
                    Console.WriteLine("CPF ...........: " + pF.cpf);
                    Console.WriteLine("RG ............: " + pF.rg);
                    Console.WriteLine("Valor de Compra: " + pF.valor.ToString("C"));
                    Console.WriteLine("Imposto .......: " + pF.valorImposto.ToString("C"));
                    Console.WriteLine("Total a Pagar : " + pF.total.ToString("C"));
            
            }
            else if(tipoPessoa == "j")
            {
            PessoaJuridica pJ = new PessoaJuridica();
            Console.WriteLine("Digite seu CNPJ: ");
            pJ.cnpj = Console.ReadLine();
            Console.WriteLine("Digite seu IE: ");
            pJ.ie = Console.ReadLine();
             Console.WriteLine("Informe o valor da Compra: ");
            valorPago=float.Parse(Console.ReadLine());
            pJ.PagarImpostos(valorPago);
            Console.WriteLine("-------- Pessoa Jurídica ---------");
                    Console.WriteLine("Nome ..........: " + pJ.nome);
                    Console.WriteLine("Endereço ......: " + pJ.endereco);
                    Console.WriteLine("CNPJ ..........: " + pJ.cnpj);
                    Console.WriteLine("IE ............: " + pJ.ie);
                    Console.WriteLine("Valor de Compra: " + pJ.valor.ToString("C"));
                    Console.WriteLine("Imposto .......: " + pJ.valorImposto.ToString("C"));
                    Console.WriteLine("Total a Pagar : " + pJ.total.ToString("C"));
            }
            else
            {
                System.Console.WriteLine("Você não digitou uma opção valida! ");
            }
            }
            
            
        }
    }
