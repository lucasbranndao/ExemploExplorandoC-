using System.Runtime.CompilerServices;
using ExemploExplorando.Models;
using System.Globalization;
using System.Transactions;
using System.Data;


Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Rewmovendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
























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