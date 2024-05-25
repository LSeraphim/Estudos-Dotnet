using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void  AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQtdeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
            
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso {NomeCurso}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                // string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}