using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLO_POO.Models
{
    // Uma herança é declarada usando os ':' e o nome da Classe que vai ser herdada
    // Isso se chama classe Selada.
    // Assim como esta abaixo:
    public class Professor : Pessoa
    {
        // Agora podemos instancia-la sem a obrigação de dar um Nome.
        public Professor()
        {
            
        }
        // Construtor herdado pela classe Pessoa. O ': base(nome)' está enviando o o nome recebido para a classe pai (Pessoa).
        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario { get; set; }

        // Exemplo de Polimorfismo:
        // O override usado na utilização deste método serve para a classe filha poder modificar um método ja herdado
        // Nesse caso o Apresentar() é um método criado pela Classe Pessoa, onde também devemos fazer uma alteração para que isso seja possível
        // Devemos aplicar o override antes do void assim como está abaixo:
        // Também podemos selar o método, para que ele não possa ser sobrescrito, ou seja, ele poderá ser usado, mas não modificado;
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um professor e ganho {Salario.ToString("C")}");
        }
    }
}