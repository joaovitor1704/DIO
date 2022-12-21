using ProjetoCursoPessoa.Models;

Pessoa p1 = new Pessoa("João", 21);
Pessoa p2 = new Pessoa("Julia", 20);
Curso c1 = new Curso("Matematica");
Curso c2 = new Curso("Portugues");

c1.Alunos = new List<Pessoa>();
c2.Alunos = new List<Pessoa>();

c1.AdicionarAluno(p1);
c1.AdicionarAluno(p2);
c2.AdicionarAluno(p1);

c1.ListarAlunos();
c2.ListarAlunos();
