using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLO_POO.Models
{
    public class Pessoa
    {
        // Criando um construtor vazio também damos a possíbilidade de instanciarmos a classe sem ser obrigatorio um Nome.
        // Támbém é necessário fazer isso com as classes filhas.
        public Pessoa()
        {
            
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        // Abstração: Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.
        // Lembrar que a Classe é apenas um molde do que eu quero representar, e não um objeto.
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        // Exemplo de Polimorfismo:
        // Para este método ser modificado pelas Classes filhas, devemos incluir o 'virtual' antes do void, para que isso seja possível.
        // Assim as modificações deste método será possível nas classes que forem herda-la.
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }

    }
}