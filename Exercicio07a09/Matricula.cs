namespace Exercicio07a09
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Matricula
    {
        public string NomeDoAluno;
        public string Curso;
        public int NumeroMatricula;
        public string Situacao;
        public string DataInicial;

        public void Trancar()
        {
            Situacao = "Trancada";
            Console.WriteLine($"Matrícula {NumeroMatricula} de {NomeDoAluno} foi trancada.");
        }

        public void Reativar()
        {
            Situacao = "Ativa";
            Console.WriteLine($"Matrícula {NumeroMatricula} de {NomeDoAluno} foi reativada.");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nAluno: {NomeDoAluno}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Número da Matrícula: {NumeroMatricula}");
            Console.WriteLine($"Situação: {Situacao}");
            Console.WriteLine($"Data de Início: {DataInicial}");
        }
    }
}
