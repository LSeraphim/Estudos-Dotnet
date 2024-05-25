using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLO_POO.Models
{
    // Uma classe abstrata tem como objetivo ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada.
    // Você pode implementar métodos ou deixa-los a cargo de quem herdar.
    // Olhe a classe Corrente para ver como funciona
    public abstract class Conta
    {
        // protectede serve para deixar esse campo ser alterado APENAS pelas classes que herdarem ela, ou pela própria classe.
        protected decimal saldo { get; set; }

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }   
    }
}