using ExemploExplorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Lucas";
// p1.Sobrenome = "Brandão";
// p1.Idade = 33;
// p1.Apresentar();

Pessoa p1 = new Pessoa("Caio", "Brandão");
Pessoa p2 = new Pessoa(nome: "Arthur", sobrenome: "Brandão");
Pessoa p3 = new Pessoa();
p3.Nome = "Lucas";
p3.Sobrenome = "Brandão";

Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Ingles";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.AdicionarAluno(p3);
CursoDeIngles.ListaAluno();