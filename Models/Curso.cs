using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intro_propriedades_métodos_contrutores.Models
{
    public class Curso
    {

        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AddAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQtdAlunosMatriculado()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        //Ou
        // public void RemoverAluno(Pessoa aluno)
        // {
        //     Alunos.Remove(aluno);
        // }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}"); 

            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto); 
            }
        }
    }
}