using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //Método 
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidadeDeAlunos = Alunos.Count;
            return quantidadeDeAlunos;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}\n".ToUpper());

            for (int count = 0; count < Alunos.Count; count++)
            {
                // string ordemDoAluno = "N° " + (count + 1) + " - ";
                string ordemDoAluno = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(ordemDoAluno);
            }
        }

    }
}