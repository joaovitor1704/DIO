using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCursoPessoa.Models
{
    public class Pessoa
    {
        public Pessoa() {}
        public Pessoa(string nome, int idade) {
            this.Nome = nome;
            this.Idade = idade;
        }

		private string _nome;
		private int _idade;
		public string Nome
		{
			get => _nome.ToUpper(); 
			set {
				if(value == "")
				{
					throw new ArgumentException("O nome não pode ser vazio");
				}
				_nome = value; 
			}
		}
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value;
            }
        }
        public void Apresentar()
        {
            Console.WriteLine($"NOME = {Nome} e IDADE = {Idade}");
        }
    }
}
