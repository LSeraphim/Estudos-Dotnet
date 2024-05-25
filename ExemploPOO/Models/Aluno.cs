using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLO_POO.Models
{
    // Uma herança é declarada usando os ':' e o nome da Classe que vai ser herdada
    // Assim como esta abaixo:
    public class Aluno  : Pessoa
    {
        // Agora podemos instancia-la sem a obrigação de dar um Nome.
        public Aluno()
        {
            
        }
        // Construtor herdado da classe Pessoa. O ': base(nome)' está enviando o o nome recebido para a classe pai (Pessoa).
        public Aluno(string nome) : base(nome)
        {

        }
        // A herança nos permite reutilizar atributos, métodos e comportamentos de uma classe em outra classe.
        // Serve para agrupar objetos que são do mesmo tipo, porém com características diferentes.
        public double Nota { get; set; }

        // Exemplo de Polimorfismo:
        // Mais detalhes na Classe Professor.
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}