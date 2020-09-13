using _07_Bytebank;
using System.Dynamic;

namespace _07_ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set;}

        public static int TotaldeContasCriadas { get; private set; }


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <=0 )
                {
                    return;
                }
                _agencia = value;
            }
        }


        public int Numero { get; set;  }


        private double _saldo = 100;

        public double Saldo // convenção de criação de propiedade = get set começa em Maiuscula
        {
            get //devolve uma propiedade da classe
            {
                return _saldo;
            }
            set
            {
                if (value < 0) // verifica o argumento 
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotaldeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor) // this é uma palavra reservada: acessa o saldo da instancia/objeto
            {
                return false;
            }
                _saldo -= valor;
                return true;
        }

        public void Depositar(double valor) // método ou função
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            contaDestino.Depositar(100);
            return true;
        }
    }
}