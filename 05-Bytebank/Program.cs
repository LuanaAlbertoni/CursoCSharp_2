
using _05_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bytebank
{
    class Program
    {
        //Referência Nula.
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "434.562.878-20";
            //conta.titular.profissao = "Desenvolvedora C#";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563674;

            if(conta.titular==null)
            {
                Console.WriteLine("A referencia é nula");
            }

            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
