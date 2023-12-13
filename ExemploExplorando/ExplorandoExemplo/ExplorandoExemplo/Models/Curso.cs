using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoExemplo.Models
{
    internal class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos{ get; set; }

        public void AdicionarAluno(Pessoa aluno) 
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatricilados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public  void ListarAlunos()
        {
            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"Nº {count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }

        }

    }
}
