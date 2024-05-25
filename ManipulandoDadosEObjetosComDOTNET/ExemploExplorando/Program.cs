using System.Globalization;
using System.Runtime.InteropServices;
using ExemploExplorando.Models;
using Newtonsoft.Json;


string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto} - Preço: {venda.Preco}, Data da Venda: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}

















/* Exemplo se Serialização e Deserialização de um arquivo Json
// Serializando um objeto com o pacote Newtonsoft.Json
DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);
*/

/* Exemplo de Operador Ternário
// operador ternário

int numero = 10;
bool ehpar = false;

// if ternário
ehpar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é {(ehpar ? "par" : "impar")}");

// if normal
// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }
*/

/* Intanciando uma Classe, construindo um objeto
Pessoa p1 = new Pessoa("Leonardo", "Seraphim");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome}  {sobrenome}");
*/

/* Usando tuplas e lendo arquivos txt
LeituraArquivo arquivo = new LeituraArquivo();

// É possível descartar uma informação usando o _ na tupla
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
   // Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}
*/

/*
// Exemplos de Tuplas
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Leonardo", "Seraphim", 1.75M);
ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Leonardo", "Seraphim", 1.75M);
var maisUmExemploTupla = Tuple.Create(1, "Leonardo", "Seraphim", 1.75M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");
*/

/* Exemplo de Tuplas
// Chaves(KEY) NÃO podem se repetir!
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

// Usar chave para remover, em um dictionary a chave é a referencia pra tudo
Console.WriteLine("===============");

estados.Remove("BA");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando a existencia da chave: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor Existente: {chave}");
}
else
{
    Console.WriteLine($"É seguro adicionar a chave {chave}");
}

// Acessando valor da chave
Console.WriteLine(estados["MG"]);
*/

/* Exemplo de Stack
Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
pilha.Push(9);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}
*/

/* Exemplo de Queue
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item  in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int item  in fila)
{
    Console.WriteLine(item);
}
*/

//new ExemploExcecao().Metodo1();

/* Exemplo de Try, Catch e Finally
//  try serve para executar um programa e tentar prever algum tipo de erro para que o programa não se encerre, usando as exceções podemos retornar uma mensagem ou um comando
//  o catch é onde o erro é recebido, e damos esse comando, ou mensagem.
//  o finally é executado independente se aconteceu alguma exceção ou não, mesmo se correr tudo certo ele ainda será executado. É util para fechar conexão com banco de dados
try 
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
} 
finally
{
    Console.WriteLine("Chegou até aqui!");
}
*/

/* Exemplos de DateTime e formatação de dados
DateTime date = DateTime.Now;

Console.WriteLine(date);    
Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(date.ToShortDateString());
Console.WriteLine(date.ToShortTimeString());

// Parse permite converter uma string para DateTime mas a data precisa ser válida, caso seja um dia acima de 31 ou mes acima de 12, ele ira retornar um erro
DateTime data1 = DateTime.Parse("11/10/2002 13:51");
Console.WriteLine(data1);

// Com esse metodo TryParseExact ele tenta fazer a conversão de uma data em string para o DateTime e se não der certo, ele não encerra o programa e retorna um valor padrão
string data2 =  "2022-18-17 14:17";
// DateTime.TryParseExact(data2, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data3);
// Console.WriteLine(data3);

// Como fazer a validação abaixo:
bool sucesso = DateTime.TryParseExact(data2, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data3);
if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data3}");
} 
else 
{
    Console.WriteLine($"{data2} não é uma data válida!");
}
*/

/* Exemplo de formatação de Dados e como mudar a "cultura" do projeto
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal valorMonetario = 1082.40M;
Console.WriteLine(valorMonetario.ToString("C"));

double porcentagem = .345;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 11102002;
Console.WriteLine(numero.ToString("##-##-####"));
*/

/* Exemplo de Classes e Listas
Pessoa p1 = new Pessoa(nome: "Julio", sobrenome:"Lardino");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome:"Neves Queiroz");


Curso cursoDeIngles = new Curso();
cursoDeIngles.NomeCurso = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
*/
