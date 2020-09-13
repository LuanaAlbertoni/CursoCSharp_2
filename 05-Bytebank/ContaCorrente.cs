using _05_Bytebank;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular; // Campo de referência
        public int agencia;
        public int numero;
        public double saldo = 100;


        public bool Sacar(double valor)
        {
            if (this.saldo < valor) // this é uma palavra reservada: acessa o saldo da instancia/objeto
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor) // método ou função
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            contaDestino.Depositar(100);
            return true;
        }
    }
}