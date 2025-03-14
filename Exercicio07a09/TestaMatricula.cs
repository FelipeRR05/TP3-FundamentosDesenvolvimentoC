namespace Exercicio07a09
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestaMatricula
    {
        public static void Executar()
        {
            Matricula matricula = new Matricula
            {
                NomeDoAluno = "Felipe Roberto Rocha",
                Curso = "Engenharia de Software",
                NumeroMatricula = 123456,
                Situacao = "Ativa",
                DataInicial = "25/01/2024"
            };

            matricula.ExibirInformacoes();

            Console.WriteLine("\nTrancando matrícula...");
            matricula.Trancar();
            matricula.ExibirInformacoes();

            Console.WriteLine("\nReativando matrícula...");
            matricula.Reativar();
            matricula.ExibirInformacoes();
        }
    }
}