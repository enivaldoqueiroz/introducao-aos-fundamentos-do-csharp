using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula61ResolvendoDesafioDeEncapsulamento
{
    internal class ContaBancaria
    {
        private double _saldo;
        private char _simOuNao;
        public int Numero { get; set; }
        public string Titular { get; set; }

        public ContaBancaria()
        {
            _saldo = 0;
        }
        public ContaBancaria(double saldo, char simOuNao) : this()
        {
            _saldo = saldo;
            _simOuNao = simOuNao;
        }

        public void SimoOuNão(char simOuNao)
        {
            if (simOuNao == 's')
                Desposito();
                            
        }

        public void Desposito()
        {
            Console.Write("Entre o valor de depósito inicial: ");
            int valorDepositado = int.Parse(Console.ReadLine());
             _saldo = _saldo + valorDepositado;
        }

        public double Saque(double valorSaque)
        {
            return _saldo - valorSaque;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + " Saldo: "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
