using System.Diagnostics.Contracts;
using ExemploFundamentos.Common.Models;

/*string opcao;
// Laço de repetição While, com switch case

bool exibirMenu = true;

while(exibirMenu) 
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de clientes");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exite(0);
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
} 

Console.WriteLine("O programa se encerrou");

*/
/*Pessoa pessoa1 = new Pessoa();
// Uso de uma classe

pessoa1.Nome = "Lucas";
pessoa1.Idade = 22;
pessoa1.Apresentar();
*/

/*
// Uso de Arrays, manipulação de array, com laço de repetição for e foreach
int[] arrayInteiros = new int[3];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

//array com o for
Console.WriteLine("Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Array com o FOREACH");
int contadorForeach = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
    contadorForeach++;
}
*/

// Uso de Listas com laço de repetição for e foreach, e funções para tamanho, capacidade, adicionar e retirar elementos da lista
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

listaString.Remove("SP");

int contadorForeach = 0;
foreach (string item in listaString)
{
        Console.WriteLine($"Posição N° {contadorForeach} - {item}");
        contadorForeach++;
}