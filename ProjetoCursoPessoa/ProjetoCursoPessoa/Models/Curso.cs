using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCursoPessoa.Models
{
    public class Curso
    {
        public Curso() { }
        public Curso(string nome) {
            this.Nome = nome;
        }
		public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } 


        public void AdicionarAluno(Pessoa p)
        {
            Alunos.Add(p);  
        }

        public void Removealuno(Pessoa p)
        {
            if (Alunos.IndexOf(p) != -1)
            {
                Alunos.Remove(p);
            }
            else
            {
                Console.WriteLine("Esse aluno não está matriculado");
            }
        }

        public void ListarAlunos()
        {
            foreach (Pessoa p in Alunos)
            {
                p.Apresentar();
            }
        }

        public int NumeroDeAlunosMatriculados()
        {
            return Alunos.Count;
        }
	}
}
