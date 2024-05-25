using EXEMPLO_POO.Models;
using EXEMPLO_POO.Interfaces;

/* Exemplo de Abstração
// Ao instanciar uma Classe, criamos um objeto, ele poderá receber todas as propriedades da Classe.
// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.Idade = 22;
// p1.Apresentar();
*/

/* Exemplo de Encapsulamento

// Não é possível alterar o valor do campo Saldo diretamente, pois ele está como private. 
ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.Sacar(1001);
c1.ExibirSaldo();
*/

/* Exemplo de Herança
Aluno a1 = new Aluno();
// Propriedades herdadas da Classe Pessoa.
a1.Nome = "Renato Cariani";
a1.Idade = 99;
a1.Email = "teste@gmailteste.com";
// Propriedades da própria Classe Aluno.
a1.Nota = 10;
// Método herdado da Classe Pessoa.
a1.Apresentar();
*/

/* Exemplo de Polimorfismo com herança (Override/Late Binding)

Aluno a1 = new Aluno();
a1.Nome = "Renato Cariani";
a1.Idade = 16;
a1.Email = "teste@gmailteste.com";
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Julio Balestrin";
p1.Idade = 37;
p1.Salario = 1200;
p1.Apresentar();
*/

// Exemplo de Polimorfismo em tempo de compilação (Overload/Early Binding) na Classe Calculadora

/* Instanciando uma Classe que herdou uma Classe abstrata
// Corrente c = new Corrente();
*/

/* Exemplo de Construtor herdad
// Agora as classes herdadas também exigem o nome, pois herdaram o construtor de Pessoa.
Pessoa p1 = new Pessoa("Ferdinando");
Aluno a1 = new Aluno("Lucas");
Professor prof1 = new Professor("Miguel");
*/

/* Exemplo de Classe Selada (sealed class)
// Também a Classes que chamamos de seladas, ao criar uma classe selada, ímpedimos que qualquer outra classe possa herda-la
// Vou mostrar como ficaria uma classe selada:
// public sealed class Teste
// {

// }
// Qualquer classe que tentar herda-la ficara com erro, ao passar o mouse em cima, será possível ver o motivo.
*/

/* Exemplo de herança da System.Object
// Aqui sobrescrevemos uma classe objetc, que foi herdada diretemante da System.Objetc, todas as classes do dotnet herdam da System.Objetc por padrão
Computador  c = new Computador();
Console.WriteLine(c.ToString());
*/

/* Exemplo de Interface com uma Classe
// Podemos ver que uma Interface não pode ser instanciada, pois ela serve apenas para ser implementada
// ICalculadora calc = new ICalculadora();
// Podemos usar a classe que foi Implementada pela Interface ICalculadora, para criar um objeto.
// Algo desse tipo:
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));
// Se tentarmos usar a Interface ICalculadora com uma classe que não foi implementada com ela, dará erro.
// ICalculadora calc = new Computador();
*/


