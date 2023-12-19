
using intro_propriedades_métodos_contrutores.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Fulano";
// p1.Idade = 20;
// p1.Apresentar();

Pessoa p1 = new Pessoa("Fulano","Fulaninho" );
// p1.Nome = "Fulano";
// p1.Sobrenome = "Fulaninho";

Pessoa p2 = new Pessoa("Fu","Lano" );
// p2.Nome = "Fu";
// p2.Sobrenome = "Lano";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AddAlunos(p1);
cursoDeIngles.AddAlunos(p2);
cursoDeIngles.ListarAlunos();