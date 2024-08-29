namespace Bootcamp.Common.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade; /* Todo metodo diferente de void, precisa conter retorno*/
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            // Podemos formatar valores em diversas representações. Essa formatação de valores é conhecida por concatenação ou interpolação.
            Console.WriteLine($"Alunos do curso: {Nome}");
            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine($"{aluno.NomeCompleto}");
            // }

            for(int i = 0; i < Alunos.Count; i++){
                // string texto = "N° " + i + " - " + Alunos[i].NomeCompleto;
                string texto = $"N° {i + 1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}