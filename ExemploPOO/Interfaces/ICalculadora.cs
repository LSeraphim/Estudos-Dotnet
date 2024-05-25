using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLO_POO.Interfaces
{
    // Isso é um exemplo de Interface, podemos cria-la para que possa ser implementada em outra Classe
    // A principal diferença é que uma classse pode ser implementada por varias Interfaces, mas podoe herdar APENAS UMA outra classe
    // Também, quando implementamos uma Interface em alguma classe, a classe é OBRIGADA a ter os métodos sem corpo da Interface nela.
    // veja na Classe Calculadora como faz par aimplementar essa Interface naquela Classe 
    public interface ICalculadora
    {
        // Nas interfaces não precisamos definir se o método é public, private, void, nada deste tipo
        // Também não precisamos abrir e fechar as chaves, para colocar um código, mas quando essa Interface for implementada a uma classe
        // Tudo isso precisará ser feito.
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);

        // Se adicionarmos um corpo ao método, ele se tornará opcional para a Classe.
        // Por Exemplo o método MultiplicarTres(), não precisará ser implementado na Classe Calculadora, ah não ser que precise.
        int MultiplicarTres(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
    }
}