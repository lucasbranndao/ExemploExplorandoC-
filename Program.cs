using System.Runtime.CompilerServices;
using ExemploExplorando.Models;
using System.Globalization;
using System.Transactions;
using System.Data;
using Newtonsoft.Json;


Venda v1 = new Venda(1, "Material de escritorio", 23.00M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

Console.WriteLine(serializado);

























// int numero = 21;
// bool ehPar = false;

// // IF ternário

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));
// if (numero % 2 == 0)

// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }



















// Pessoa p1 = new Pessoa("Lucas", "Brandão");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");































// LeituraArquivo arquivo = new LeituraArquivo();


// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     // Console.WriteLine("Quantidade linhas do arquivo::" + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }

// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

// forma recomenada 
// (int, string, string, decimal) tupla = (1, "Lucas", "Brandão", 1.80M);


// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Lucas", "Brandão", 1.80M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Lucas", "Brandão", 1.80M);


// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");




























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("GO", "Goias");
// estados.Add("SP", "São Pualo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["BA"]);

// // foreach (KeyValuePair<string, string> item in estados)
// // {
// //     Console.WriteLine($" Chave: {item.Key}, valor: {item.Value}");
// // }

// foreach (var item in estados)
// {
//     Console.WriteLine($" Chave: {item.Key}, valor: {item.Value}");
// }

// Console.WriteLine("---------------");
// estados.Remove("MG");
// estados["SP"] = "São Paulo - valor alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($" Chave: {item.Key}, valor: {item.Value}");
// }

// string chave = "Gi";
// Console.WriteLine("Verificando o elemento");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar: {chave}");
// }





































// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);


// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }


























// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
























// new ExemploExececao().Metodo1();

















// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivo. Caminho da pasta não encontrado {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exeção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }




















// string dataString = "11/13/2024 18:00";
// bool sucesso = DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data valida!");
// }


// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());


// Console.WriteLine(data.ToShortTimeString());
// Console.WriteLine(data);









// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;
// Console.WriteLine($"Em dolar {valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");

// Console.WriteLine($"Em reais {valorMonetario:C}");

// Console.WriteLine($"Formatação personalizada: {valorMonetario.ToString("C2")}");

// double porcentagem = .3421;
// Console.WriteLine($"Porcentagem {porcentagem.ToString("P")}");

// int numero = 123456;
// Console.WriteLine($"Numeração personalizada {numero.ToString("##-##-##")}");






// interpolação de numeros
// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);








// Pessoa p1 = new Pessoa();
// p1.Nome = "Lucas";
// p1.Sobrenome = "Brandão";
// p1.Idade = 33;
// p1.Apresentar();


// execução do cruso
// Pessoa p1 = new Pessoa("Caio", "Brandão");
// Pessoa p2 = new Pessoa(nome: "Arthur", sobrenome: "Brandão");
// Pessoa p3 = new Pessoa();
// p3.Nome = "Lucas";
// p3.Sobrenome = "Brandão";

// Curso CursoDeIngles = new Curso();
// CursoDeIngles.Nome = "Ingles";
// CursoDeIngles.Alunos = new List<Pessoa>();

// CursoDeIngles.AdicionarAluno(p1);
// CursoDeIngles.AdicionarAluno(p2);
// CursoDeIngles.AdicionarAluno(p3);
// CursoDeIngles.ListaAluno();