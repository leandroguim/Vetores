using ExplorandoExemplo.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//new ExemploExecao().Metodo1();


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

















//Stack<int> pilha = new Stack<int>();
//pilha.Push(4);
//pilha.Push(6);
//pilha.Push(10);

//foreach (int i in pilha)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}"); 









//Queue<int> fila = new Queue<int>();

//fila.Enqueue(2);
//fila.Enqueue(4);
//fila.Enqueue(6);
//fila.Enqueue(8);    

//foreach (int item in fila)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine($"Removendo o elemento {fila.Dequeue()}"); 

//decimal valorMonetario = 82.40M;

//Console.WriteLine($"{ valorMonetario:c}");


//try
//{

//    string[] linhas = File.ReadAllLines("C:\\Projetos\\ExemploExplorando\\ExplorandoExemplo\\ExplorandoExemplo\\Arquivos\\arquivo_Leitura.txt");

//    foreach (string line in linhas)
//    {
//        Console.WriteLine(line);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}");
//}




//Pessoa p1 = new Pessoa("Leandro", "Gui");
//Pessoa p2 = new Pessoa("Carlos", "Rangel");

//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Ingles";
//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListarAlunos();
