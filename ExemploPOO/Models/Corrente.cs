using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLO_POO.Models
{
    // Essa é uma classe que herdou uma classe abstrata, ela deve receber os mesmos métodos da classe abstrata
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}