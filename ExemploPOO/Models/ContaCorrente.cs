using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLO_POO.Models
{
    public class ContaCorrente
    {
        // Encapsulamento: Serve para proteger  uma classe e definir limites para alterações  de suas propriedades. 
        // Serve para ocultar seu comportamento e expor somente o necessário.
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor) 
        {
            if (saldo >= valor) 
            {
                saldo = saldo - valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é: {saldo.ToString("C")}");
        }
    }
}