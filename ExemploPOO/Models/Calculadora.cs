using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EXEMPLO_POO.Interfaces;

namespace EXEMPLO_POO.Models
{
    // Aqui podemos ver a implementação da Interface ICalculadora.
    // Onde devemos adicionar o using dela acima e dentro da classe, foi adicionado os métodos que foram criados na Interface ICalculadora.
    // Se esses passos não forem seguidos, a classe ficara com erro.
    // Apesar da implementação ser parecida com uma herança. são conceitos totalmente diferentes.
    public class Calculadora : ICalculadora
    {
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        // Aqui está um exemplo de Polimorfismo que não depende de herança.
        // Caso seja passado 2 parâmetros será executado o primeiro método.
        // Caso seja passado 3 parâmetros será executado o segundo método.
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}