// Parte 7 do curso 2. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotaldeContasCriadas);

            ContaCorrente conta = new ContaCorrente(876, 8764562);
            Console.WriteLine(ContaCorrente.TotaldeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(876, 87629322);

            Console.WriteLine(ContaCorrente.TotaldeContasCriadas);






            Console.ReadLine();
        }
    }
}
