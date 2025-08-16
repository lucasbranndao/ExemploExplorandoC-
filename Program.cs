using System.Runtime.CompilerServices;
using ExemploExplorando.Models;
using System.Globalization;
using System.Transactions;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;
Console.WriteLine($"Em dolar {valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");

Console.WriteLine($"Em reais {valorMonetario:C}");

Console.WriteLine($"Formatação personalizada: {valorMonetario.ToString("C2")}");

double porcentagem = .3421;
Console.WriteLine($"Porcentagem {porcentagem.ToString("P")}");

int numero = 123456;
Console.WriteLine($"Numeração personalizada {numero.ToString("##-##-##")}");






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